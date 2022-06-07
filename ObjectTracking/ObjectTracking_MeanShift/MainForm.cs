using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace ObjectTracking_MeanShift
{
    public partial class MainForm : Form
    {
        private const int timeDelay = 1000;

        private static readonly Pen targetRectPen = new Pen(Color.Red);

        private VideoCapture videoCapture;
        private double fps;
        private double frameCount;
        private bool stopFlag = false;
        private bool selectTargetFlag = false;
        private Rectangle pictureBoxTargetRect = Rectangle.Empty;
        private Rectangle firstFrameTargetRect = Rectangle.Empty;
        private Rectangle currentFrameRect = Rectangle.Empty;

        private Mat targetRoiHist;

        public MainForm()
        {
            InitializeComponent();

            UpdateStateOfControls();

            targetRectPen.DashStyle = DashStyle.Dash;
        }

        private void UpdateStateOfControls()
        {
            buttonSelectTarget.Enabled = pictureBoxFirstFrame.Image != null;
            buttonStartTracking.Enabled = pictureBoxFirstFrame.Image != null && !pictureBoxTargetRect.IsEmpty && !selectTargetFlag;
            buttonStopTracking.Enabled = !currentFrameRect.IsEmpty;
        }

        private void buttonLoadvideo_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (videoCapture != null)
                    {
                        videoCapture.Dispose();
                    }

                    videoCapture = new VideoCapture(dlg.FileName);
                    fps = videoCapture.GetCaptureProperty(CapProp.Fps);
                    frameCount = videoCapture.GetCaptureProperty(CapProp.FrameCount);

                    pictureBoxTargetRect = Rectangle.Empty;
                    firstFrameTargetRect = Rectangle.Empty;
                    targetRoiHist = null;
                    currentFrameRect = Rectangle.Empty;
                    pictureBoxVideo.Tag = null;
                    pictureBoxVideo.Image = null;
                    pictureBoxBackProj.Image = null;
                    pictureBoxRoi.Image = null;
                    pictureBoxRoiMasked.Image = null;
                    pictureBoxRoiHist.Image = null;

                    var m = new Mat();
                    videoCapture.Read(m);
                    pictureBoxFirstFrame.Tag = m.ToImage<Bgr, byte>();
                    pictureBoxFirstFrame.Image = m.Bitmap;

                    UpdateStateOfControls();
                }
            }
        }

        private void buttonSelectTarget_Click(object sender, EventArgs e)
        {
            if (pictureBoxFirstFrame.Image != null)
            {
                buttonLoadvideo.Enabled = false;
                buttonSelectTarget.Enabled = false;

                pictureBoxTargetRect = Rectangle.Empty;

                if (pictureBoxVideo.Tag != null)
                {
                    pictureBoxFirstFrame.Tag = pictureBoxVideo.Tag;
                    pictureBoxFirstFrame.Image = ((Image<Bgr, byte>)pictureBoxVideo.Tag).Bitmap;
                }
                else
                {
                    pictureBoxFirstFrame.Invalidate();
                }

                if (pictureBoxRoi.Image != null)
                {
                    pictureBoxRoi.Image = null;
                }

                selectTargetFlag = true;

                Cursor = Cursors.Cross;
            }
        }

        private void pictureBoxFirstFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectTargetFlag)
            {
                pictureBoxTargetRect = new Rectangle(e.Location, new Size(0, 0));
                pictureBoxFirstFrame.Invalidate();
            }
        }

        private void pictureBoxFirstFrame_Paint(object sender, PaintEventArgs e)
        {
            if (!pictureBoxTargetRect.IsEmpty)
            {
                e.Graphics.DrawRectangle(targetRectPen, pictureBoxTargetRect);
            }
        }

        private void pictureBoxFirstFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectTargetFlag &&
                !pictureBoxTargetRect.IsEmpty)
            {
                pictureBoxTargetRect.Size = new Size(e.Location.X - pictureBoxTargetRect.Location.X, e.Location.Y - pictureBoxTargetRect.Location.Y);
                pictureBoxFirstFrame.Invalidate();
            }
        }

        private void pictureBoxFirstFrame_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectTargetFlag)
            {
                selectTargetFlag = false;
                Cursor = Cursors.Default;
                buttonLoadvideo.Enabled = true;
                buttonSelectTarget.Enabled = true;

                firstFrameTargetRect = UtilityFunctions.FromZoomPictureBoxToImageCoordinates(pictureBoxFirstFrame, pictureBoxTargetRect);

                UpdateTargetRoi();

                UpdateStateOfControls();
            }
        }

        private void UpdateTargetRoi()
        {
            if (pictureBoxFirstFrame.Tag!=null &&
                !firstFrameTargetRect.IsEmpty)
            {
                //Calcolo delle feature colore sul frame del target
                Image<Bgr, byte> roi;
                Image<Hsv, byte> maskedRoi;
                targetRoiHist = ObjectTrackingFunctions.ComputeRoIColorHist((Image<Bgr, byte>)pictureBoxFirstFrame.Tag,
                                                                            firstFrameTargetRect,
                                                                            (byte)numericUpDownMinValidH.Value,
                                                                            (byte)numericUpDownMaxValidH.Value,
                                                                            (byte)numericUpDownMinValidS.Value,
                                                                            (byte)numericUpDownMaxValidS.Value,
                                                                            (byte)numericUpDownMinValidV.Value,
                                                                            (byte)numericUpDownMaxValidV.Value,
                                                                            out roi,
                                                                            out maskedRoi);

                pictureBoxRoi.Image = roi.Bitmap;
                pictureBoxRoiMasked.Image = maskedRoi.Bitmap;
                pictureBoxRoiHist.Image = DrawHistogram(targetRoiHist);
            }
        }

        private static Bitmap DrawHistogram(Mat hist)
        {
            var data = new float[hist.Width * hist.Height];
            Marshal.Copy(hist.DataPointer, data, 0, hist.Width * hist.Height);

            var bmp = new Bitmap(data.Length, 255, PixelFormat.Format24bppRgb);
            var grBmp = Graphics.FromImage(bmp);
            grBmp.FillRectangle(Brushes.White, 0, 0, data.Length, 255);

            for (int i = 0; i < data.Length; i++)
            {
                grBmp.DrawLine(Pens.Black, i, 254, i, 255 - data[i]);
            }

            return bmp;
        }

        private async void buttonStartTracking_Click(object sender, EventArgs e)
        {
            buttonLoadvideo.Enabled = false;
            buttonSelectTarget.Enabled = false;
            buttonStartTracking.Enabled = false;
            buttonStopTracking.Enabled = true;

            numericUpDownMinValidH.Enabled = false;
            numericUpDownMaxValidH.Enabled = false;
            numericUpDownMinValidS.Enabled = false;
            numericUpDownMaxValidS.Enabled = false;
            numericUpDownMinValidV.Enabled = false;
            numericUpDownMaxValidV.Enabled = false;

            currentFrameRect = firstFrameTargetRect;

            try
            {
                //Per ogni frame
                stopFlag = false;
                while (!stopFlag)
                {
                    var posFrame = videoCapture.GetCaptureProperty(CapProp.PosFrames);
                    if (posFrame >= frameCount)
                    {
                        break;
                    }

                    var frame = new Mat();
                    videoCapture.Read(frame);
                    if (!frame.IsEmpty)
                    {
                        //Esegue il mean-shift
                        Mat probabilityMask;
                        currentFrameRect = ObjectTrackingFunctions.ExecuteMeanShift(frame,targetRoiHist,currentFrameRect,out probabilityMask);

                        //Aggiorna la visualizzazione
                        pictureBoxVideo.Tag = frame.ToImage<Bgr, byte>();
                        pictureBoxVideo.Image = frame.Bitmap;
                        pictureBoxBackProj.Image = probabilityMask.Bitmap;

                        await Task.Delay(timeDelay / Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                buttonStopTracking.Enabled = false;
                buttonLoadvideo.Enabled = true;
                buttonSelectTarget.Enabled = true;
                buttonStartTracking.Enabled = true;

                numericUpDownMinValidH.Enabled = true;
                numericUpDownMaxValidH.Enabled = true;
                numericUpDownMinValidS.Enabled = true;
                numericUpDownMaxValidS.Enabled = true;
                numericUpDownMinValidV.Enabled = true;
                numericUpDownMaxValidV.Enabled = true;
            }
        }

        private void pictureBoxVideo_Paint(object sender, PaintEventArgs e)
        {
            if (!currentFrameRect.IsEmpty)
            {
                //var topLeftCorner = FromImageToZoomPictureBoxCoordinates(pictureBoxVideo, currentFrameRect.Location);
                //var bottomRightCorner = FromImageToZoomPictureBoxCoordinates(pictureBoxVideo,new Point(currentFrameRect.Right, currentFrameRect.Bottom));
                //var pictureBoxFrameRect = new Rectangle(topLeftCorner,
                //                                        new Size(bottomRightCorner.X - topLeftCorner.X, bottomRightCorner.Y - topLeftCorner.Y));
                var pictureBoxFrameRect = UtilityFunctions.FromImageToZoomPictureBoxCoordinates(pictureBoxVideo, currentFrameRect);

                e.Graphics.DrawRectangle(Pens.Red, pictureBoxFrameRect);
            }
        }

        private void buttonStopTracking_Click(object sender, EventArgs e)
        {
            stopFlag = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Dispose();
            }
        }

        private void pictureBoxBackProj_Paint(object sender, PaintEventArgs e)
        {
            if (!currentFrameRect.IsEmpty)
            {
                //var topLeftCorner = FromImageToZoomPictureBoxCoordinates(pictureBoxBackProj, currentFrameRect.Location);
                //var bottomRightCorner = FromImageToZoomPictureBoxCoordinates(pictureBoxBackProj, new Point(currentFrameRect.Right, currentFrameRect.Bottom));
                //var pictureBoxFrameRect = new Rectangle(topLeftCorner,
                //                                        new Size(bottomRightCorner.X - topLeftCorner.X, bottomRightCorner.Y - topLeftCorner.Y));
                var pictureBoxFrameRect = UtilityFunctions.FromImageToZoomPictureBoxCoordinates(pictureBoxBackProj, currentFrameRect);

                e.Graphics.DrawRectangle(Pens.Red, pictureBoxFrameRect);
            }
        }

        private void numericUpDownMinHsvRange_ValueChanged(object sender, EventArgs e)
        {
            UpdateTargetRoi();
        }
    }
}
