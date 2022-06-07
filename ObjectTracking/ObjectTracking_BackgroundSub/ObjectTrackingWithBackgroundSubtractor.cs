using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectTracking_BackgroundSub
{
    public class ObjectTrackingWithBackgroundSubtractor
    {
        //Parametri
        private const int minimumValidArea = 300;
        private const int maximumValidArea = 25000;
        private const double bgSubTrainFramePerc = 0.01;
        private const int bgSubTrainFrameMaxCount = 500;
        private const double minIoU = 0.3;
        private const int morphKernelSize = 3;

        private BackgroundSubtractorMOG2 bgSubtractorModel=null;
        private Mat morphKernel=null;

        public ObjectTrackingWithBackgroundSubtractor(VideoCapture videoCapture)
        {
            //Creazione del BackgroundSubtractor
            //TODO: Istanziare un oggetto della classe "BackgroundSubtractorMOG2" assegnandolo all'attributo "bgSubtractorModel"
                        
            //Creazione del kernel per gli operatori morfologici
            if (morphKernelSize > 0)
            {
                morphKernel = CvInvoke.GetStructuringElement(ElementShape.Ellipse,
                                                            new Size(morphKernelSize, morphKernelSize),
                                                            new Point(-1, -1));
            }

            //Stima iniziare del background
            if (bgSubTrainFramePerc > 0 &&
                bgSubTrainFrameMaxCount > 0)
            {
                var frameCount = videoCapture.GetCaptureProperty(CapProp.FrameCount);
                var trainFrameCount = Math.Min((int)Math.Round(frameCount * bgSubTrainFramePerc, MidpointRounding.AwayFromZero), bgSubTrainFrameMaxCount);
                TrainBackgroundSubtractorMOG2(videoCapture, trainFrameCount,(int) frameCount);
            }
        }

        private void TrainBackgroundSubtractorMOG2(VideoCapture videoCapture, int trainFrameCount, int totalFrameCount)
        {
            try
            {
                //Per ogni frame di training
                var k = 0;
                while (k < trainFrameCount)
                {
                    var posFrame = videoCapture.GetCaptureProperty(CapProp.PosFrames);
                    if (posFrame >= totalFrameCount)
                    {
                        break;
                    }

                    var frame = new Mat();
                    videoCapture.Read(frame);
                    if (!frame.IsEmpty)
                    {
                        //Addestramento del BackgroundSubtractor
                        var fgMask = new Mat();

                        //TODO: Stimare il background iniziale richiamando il metodo Apply della classe "BackgroundSubtractorMOG2"
                    }
                    else
                    {
                        break;
                    }

                    k++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ObjectInfo[] Track(Mat frame,ObjectInfo[] previousFrameRackedObjects,int maxObjectToTrack,out Mat fgMask)
        {
            //Sottrazione del background dal frame corrente
            fgMask = new Mat();

            //TODO: Sottrarre il background dal frame corrente utilizzando il metodo Apply della classe "BackgroundSubtractorMOG2"

            //Rimozione delle ombre
            fgMask = fgMask.ToImage<Gray, byte>().ThresholdBinary(new Gray(240), new Gray(255)).Mat;

            //Pulizia della maschera utilizzando gli operatori morfologici
            if (morphKernel!=null)
            {
                CvInvoke.MorphologyEx(fgMask, fgMask, MorphOp.Close, morphKernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());
                CvInvoke.MorphologyEx(fgMask, fgMask, MorphOp.Open, morphKernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());
                CvInvoke.MorphologyEx(fgMask, fgMask, MorphOp.Dilate, morphKernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());
            }

            //Etichettatura delle componenti connesse
            var labels = new Mat();
            var stats = new Mat();
            var centroids = new Mat();
            var labelCount=-1;

            //TODO: effettuare l’etichettatura delle componenti connesse utilizzando la funzione "CvInvoke.ConnectedComponentsWithStats" e assegnando il numero di etichette
            //      alla variabile "labelCount"

            var ccStats = new CCStats[stats.Rows];
            stats.CopyTo(ccStats);

            var centroidPoints = new MCvPoint2D64f[labelCount];
            centroids.CopyTo(centroidPoints);

            if (ccStats.Length != centroidPoints.Length)
            {
                throw new Exception();
            }

            //Selezione delle sole componenti connesse con un'area dentro il range [minimumValidArea,maximumValidArea]
            var currentFrameTrackedObjects = new List<ObjectInfo>(ccStats.Length);
            var idCount = 0;
            for (int i = 0; i < ccStats.Length; i++)
            {
                if (ccStats[i].Area >= minimumValidArea &&
                    ccStats[i].Area <= maximumValidArea)
                {
                    var track = new List<Point>();
                    track.Add(new Point((int)centroidPoints[i].X, (int)centroidPoints[i].Y));

                    currentFrameTrackedObjects.Add(new ObjectInfo()
                    {
                        Stats = ccStats[i],
                        Centroid = centroidPoints[i],
                        Id = idCount++,
                        Track = track,
                    });
                }
            }

            //Accoppiamento degli oggetti individuati con quelli del frame precedente
            if (currentFrameTrackedObjects.Count > 0)
            {
                currentFrameTrackedObjects = Pairing(previousFrameRackedObjects, currentFrameTrackedObjects, maxObjectToTrack);
            }

            return currentFrameTrackedObjects.ToArray();
        }

        private static List<ObjectInfo> Pairing(ObjectInfo[] previousSelectedObjects, List<ObjectInfo> currentSelectedObjects, int maxObjectCount)
        {
            var pairedObjects = new List<ObjectInfo>(maxObjectCount);
            var usedIds = new HashSet<int>();

            if (previousSelectedObjects != null &&
                previousSelectedObjects.Length > 0)
            {
                for (int i = 0; i < previousSelectedObjects.Length; i++)
                {
                    var maxIou = 0.0;
                    var maxIouIdx = -1;
                    for (int j = 0; j < currentSelectedObjects.Count; j++)
                    {
                        var iou = ComputeIoU(previousSelectedObjects[i].Stats.Rectangle, currentSelectedObjects[j].Stats.Rectangle);
                        if (iou > maxIou)
                        {
                            maxIou = iou;
                            maxIouIdx = j;
                        }
                    }

                    if (maxIou > minIoU &&
                        maxIouIdx != -1)
                    {
                        var track = previousSelectedObjects[i].Track;
                        track.Add(new Point((int)currentSelectedObjects[maxIouIdx].Centroid.X, (int)currentSelectedObjects[maxIouIdx].Centroid.Y));

                        pairedObjects.Add(new ObjectInfo()
                        {
                            Stats = currentSelectedObjects[maxIouIdx].Stats,
                            Centroid = currentSelectedObjects[maxIouIdx].Centroid,
                            Id = previousSelectedObjects[i].Id,
                            Track = track,
                        });

                        if (usedIds.Contains(previousSelectedObjects[i].Id))
                        {
                            throw new Exception("Id già presente");
                        }

                        usedIds.Add(previousSelectedObjects[i].Id);

                        currentSelectedObjects.RemoveAt(maxIouIdx);
                    }
                }
            }

            for (int i = 0; i < currentSelectedObjects.Count; i++)
            {
                if (pairedObjects.Count == maxObjectCount)
                {
                    break;
                }

                var newId = SelectFreeId(usedIds, maxObjectCount);
                if (newId == -1)
                {
                    throw new Exception("Errore nella selezione di un nuovo ID");
                }

                pairedObjects.Add(new ObjectInfo()
                {
                    Stats = currentSelectedObjects[i].Stats,
                    Centroid = currentSelectedObjects[i].Centroid,
                    Id = newId,
                    Track = currentSelectedObjects[i].Track,
                });

                usedIds.Add(newId);
            }

            return pairedObjects;
        }

        private static int SelectFreeId(HashSet<int> usedIds, int maxObjectCount)
        {
            for (int i = 0; i < maxObjectCount; i++)
            {
                if (!usedIds.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }

        private static double ComputeIoU(Rectangle r1, Rectangle r2)
        {
            var iou = -1.0;

            //TODO: Calcola l’Intersection over Union tra due "Rectangle". Utilizzare il metodo statico "Intersect" della classe "Rectangle" per calcolare l’intersezione.

            return iou;
        }
    }

    public struct CCStats
    {
        public Rectangle Rectangle;
        public int Area;
    }

    public struct ObjectInfo
    {
        public CCStats Stats;
        public MCvPoint2D64f Centroid;
        public int Id;
        public List<Point> Track;
    }
}
