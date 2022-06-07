using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace ObjectTracking_BackgroundSub
{
    public partial class MainForm : Form
    {
        private const int timeDelay = 1500;

        private VideoCapture videoCapture;
        private double fps;
        private double frameCount;

        private bool trackingStarted = false;

        private Font idStringFont = new Font("Arial", 12);

        private ObjectTrackingWithBackgroundSubtractor objectTracker;

        #region COLORS
        public static readonly Color[] objectColors = {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.DarkViolet,
            Color.Chartreuse,
            Color.DarkOrange,
            Color.Brown,
            Color.CadetBlue,
            Color.Chocolate,
            Color.Coral,
            Color.CornflowerBlue,
            Color.Crimson,
            Color.Cyan,
            Color.DarkBlue,
            Color.DarkCyan,
            Color.DarkGoldenrod,
            Color.DarkGreen,
            Color.DarkKhaki,
            Color.BurlyWood,
            Color.DarkMagenta,
            Color.DarkOliveGreen,
            Color.DarkOrchid,
            Color.DarkRed,
            Color.DarkSalmon,
            Color.DarkSeaGreen,
            Color.DarkSlateBlue,
            Color.DarkTurquoise,
            Color.DeepPink,
            Color.DeepSkyBlue,
            Color.DodgerBlue,
            Color.Firebrick,
            Color.ForestGreen,
            Color.Fuchsia,
            Color.Gainsboro,
            Color.Gold,
            Color.Goldenrod,
            Color.GreenYellow,
            Color.Honeydew,
            Color.HotPink,
            Color.IndianRed,
            Color.Indigo,
            Color.Khaki,
            Color.Lavender,
            Color.LavenderBlush,
            Color.LawnGreen,
            Color.LemonChiffon,
            Color.LightBlue,
            Color.LightCoral,
            Color.LightCyan,
            Color.LightGoldenrodYellow,
            Color.LightGreen,
            Color.LightPink,
            Color.LightSalmon,
            Color.LightSeaGreen,
            Color.LightSkyBlue,
            Color.LightSteelBlue,
            Color.LightYellow,
            Color.Lime,
            Color.LimeGreen,
            Color.Linen,
            Color.Magenta,
            Color.Maroon,
            Color.MediumAquamarine,
            Color.MediumBlue,
            Color.MediumOrchid,
            Color.MediumPurple,
            Color.MediumSeaGreen,
            Color.MediumSlateBlue,
            Color.MediumSpringGreen,
            Color.MediumTurquoise,
            Color.MediumVioletRed,
            Color.MidnightBlue,
            Color.MintCream,
            Color.MistyRose,
            Color.Moccasin,
            Color.Navy,
            Color.OldLace,
            Color.Olive,
            Color.OliveDrab,
            Color.Orange,
            Color.OrangeRed,
            Color.Orchid,
            Color.PaleGoldenrod,
            Color.PaleGreen,
            Color.PaleTurquoise,
            Color.PaleVioletRed,
            Color.PapayaWhip,
            Color.PeachPuff,
            Color.Peru,
            Color.Pink,
            Color.Plum,
            Color.PowderBlue,
            Color.Purple,
            Color.RosyBrown,
            Color.RoyalBlue,
            Color.SaddleBrown,
            Color.Salmon,
            Color.SandyBrown,
            Color.SeaGreen,
            Color.SeaShell,
            Color.Sienna,
            Color.Silver,
            Color.SkyBlue,
            Color.SlateBlue,
            Color.Snow,
            Color.SpringGreen,
            Color.SteelBlue,
            Color.Tan,
            Color.Teal,
            Color.Thistle,
            Color.Tomato,
            Color.Turquoise,
            Color.Violet,
            Color.Wheat,
            Color.YellowGreen
            };
        #endregion

        public MainForm()
        {
            InitializeComponent();

            UpdateStateOfControls();
        }

        private void UpdateStateOfControls()
        {
            buttonStartTracking.Enabled = pictureBoxVideo.Image != null && !trackingStarted;
            buttonStopTracking.Enabled = pictureBoxVideo.Image != null && trackingStarted;
        }

        private void buttonLoadvideo_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;

                    if (videoCapture != null)
                    {
                        videoCapture.Dispose();
                    }

                    videoCapture = new VideoCapture(dlg.FileName);
                    fps = videoCapture.GetCaptureProperty(CapProp.Fps);
                    frameCount = videoCapture.GetCaptureProperty(CapProp.FrameCount);

                    //Inizializzazione del BackgroundSubtractor
                    objectTracker = new ObjectTrackingWithBackgroundSubtractor(videoCapture);

                    pictureBoxBGSub.Image = null;

                    var m = new Mat();
                    videoCapture.Read(m);
                    pictureBoxVideo.Image = m.Bitmap;

                    UpdateStateOfControls();

                    Cursor = Cursors.Default;
                }
            }
        }

        private async void buttonStartTracking_Click(object sender, EventArgs e)
        {
            try
            {
                trackingStarted = true;

                UpdateStateOfControls();

                ObjectInfo[] previousFrameTrackedObjects = null;
                while (trackingStarted)
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
                        //Track del frame corrente
                        Mat fgMask;
                        var currentSelectedObjects=objectTracker.Track(frame,
                                                                        previousFrameTrackedObjects,
                                                                        objectColors.Length,
                                                                        out fgMask);

                        previousFrameTrackedObjects = currentSelectedObjects;

                        var extraData = new object[]
                                        {
                                            currentSelectedObjects,
                                        };

                        pictureBoxVideo.Tag = extraData;
                        pictureBoxBGSub.Tag = extraData;

                        pictureBoxVideo.Image = frame.Bitmap;
                        pictureBoxBGSub.Image = fgMask.Bitmap;

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
                buttonStartTracking.Enabled = true;

                trackingStarted = false;
            }
        }

        private void buttonStopTracking_Click(object sender, EventArgs e)
        {
            trackingStarted = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Dispose();
            }
        }

        private void pictureBoxVideo_Paint(object sender, PaintEventArgs e)
        {
            var pictureBox = (PictureBox)sender;

            if (pictureBox.Tag != null)
            {
                var data = (object[])pictureBox.Tag;
                var objectInfos = (ObjectInfo[])data[0];

                foreach (var item in objectInfos)
                {
                    var itemColor = objectColors[item.Id];
                    var itemBrush = new SolidBrush(itemColor);
                    var itemPen = new Pen(itemBrush);

                    var pictureBoxRect = UtilityFunctions.FromImageToZoomPictureBoxCoordinates(pictureBox, item.Stats.Rectangle);
                    e.Graphics.DrawRectangle(itemPen, pictureBoxRect);
                    e.Graphics.DrawString(item.Id.ToString(), idStringFont, itemBrush, pictureBoxRect.Location);

                    if (item.Track.Count > 1)
                    {
                        var pictureBoxTrackPoints = new PointF[item.Track.Count];
                        for (int i = 0; i < item.Track.Count; i++)
                        {
                            pictureBoxTrackPoints[i] = UtilityFunctions.FromImageToZoomPictureBoxCoordinates(pictureBox, item.Track[i]);
                        }

                        e.Graphics.DrawLines(itemPen, pictureBoxTrackPoints);
                    }
                }
            }
        }
    }
}
