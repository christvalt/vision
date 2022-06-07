using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Drawing;

namespace ObjectTracking_MeanShift
{
    public static class ObjectTrackingFunctions
    {
        //Parametri
        private static readonly int[] channelForHistComputation = new int[] { 0 };
        private static readonly int[] channelHistBinCounts = new int[] { 180 };
        private static readonly float[] channelHistBinRanges = new float[] { 0, 180 };
        private static readonly MCvTermCriteria meanShiftTermCriteria = new MCvTermCriteria() { Epsilon = 1, MaxIter = 10 };

        /// <summary>
        /// Calcolo delle feature colore della regione di interesse.
        /// </summary>
        /// <param name="image">Immagine di input.</param>
        /// <param name="roiRectangle">Rettangolo della regione di interesse.</param>
        /// <param name="roiImage">Immagine corrispondente alla regione di interesse.</param>
        /// <param name="maskedRoi">Immagine corrispondente alla regione di interesse con solamente le tonalità di colore selezionate.</param>
        /// <returns>Istogramma delle feature colore.</returns>
        public static Mat ComputeRoIColorHist(Image<Bgr, byte> image, Rectangle roiRectangle, byte minValidH, byte maxValidH, byte minValidS, byte maxValidS, byte minValidV, byte maxValidV,
                                                out Image<Bgr, byte> roiImage, out Image<Hsv, byte> maskedRoi)
        {
            //Ritaglio della regione di interesse
            roiImage = null;
            
            //TODO: Utilizzare il metodo "GetSubRect" della classe "Image" per estrarre la RoI dall’immagine di input assegnandola a "roiImage"

            //Conversione della RoI nello spazio HSV
            var hsvRoi = new Image<Hsv, byte>(roiImage.Width, roiImage.Height);
            
            //TODO: Utilizzare il metodo "Convert<TOtherColor,TOtherDepth>()" della classe "Image" per convertire la RoI nello spazio colore HSV
            
            //Creazione di una maschera per selezionare solo alcune tonalità di colore della RoI
            var mask = new Mat();
            CvInvoke.InRange(hsvRoi, new ScalarArray(new MCvScalar(minValidH, minValidS, minValidV)), new ScalarArray(new MCvScalar(maxValidH, maxValidS, maxValidV)), mask);

            //Applicazione della maschera alla RoI
            maskedRoi = new Image<Hsv, byte>(roiImage.Width, roiImage.Height);
            hsvRoi.Copy(maskedRoi, mask.ToImage<Gray, byte>());

            //Calcolo dell'istogramma colore della RoI
            var roiHist = new Mat();

            //TODO: Utilizzare la funzione "CvInvoke.CalcHist" per calcolare l’istogramma colore della RoI

            //Normalizzazione dell'istogramma con valori nell'intervallo [0,255]
            
            //TODO: Utilizzare la funzione "CvInvoke.Normalize" per normalizzare l’istogramma colore nel range 0..255

            return roiHist;
        }

        /// <summary>
        /// Esecuzione del mean-shift sul un singolo frame.
        /// </summary>
        /// <param name="frame">frame corrente.</param>
        /// <param name="roiHist">Istogramma delle feature colore dell'oggetto target.</param>
        /// <param name="previousRoiRect">Rettangolo della regione di interesse del frame precedente.</param>
        /// <param name="probabilityMask">Probabilità che un pixel del frame corrente appartenga all'oggetto di interesse,
        ///                               misurata sulla base delle feature colore. Per maggiori dettagli: https://docs.opencv.org/3.4/da/d7f/tutorial_back_projection.html</param>
        /// <returns></returns>
        public static Rectangle ExecuteMeanShift(Mat frame, Mat roiHist, Rectangle previousRoiRect, out Mat probabilityMask)
        {
            //Conversione del frame nello spazio colore HSV
            var hsvFrame = new Image<Hsv, byte>(frame.Width, frame.Height);

            //TODO: Utilizzare la funzione "CvInvoke.CvtColor" per convertire il frame corrente nello spazio colore HSV

            //Back Projection e calcolo della probability mask
            probabilityMask = new Mat();

            //TODO: Utilizzare la funzione "CvInvoke.CalcBackProject" per calcolare la probabilità che un pixel del frame corrente appartenga
            //      all'oggetto di interesse misurata sulla base delle feature colore

            //Mean shift

            //TODO: Utilizzare la funzione "CvInvoke.MeanShift" per eseguire l’algoritmo mean-shift sulla probability mask e ottenere la RoI sul frame corrente

            return previousRoiRect;
        }

    }
}
