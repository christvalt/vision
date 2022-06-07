using System;
using System.Drawing;
using System.Windows.Forms;

namespace Utilities
{
    public static class UtilityFunctions
    {
        public static Point FromZoomPictureBoxToImageCoordinates(PictureBox pictureBox, Point pictureBoxPoint)
        {
            var image = pictureBox.Image;

            // test to make sure our image is not null
            if (image == null)
            {
                return pictureBoxPoint;
            }

            // Make sure our control width and height are not 0 and our 
            // image width and height are not 0
            if (pictureBox.Width == 0 || pictureBox.Height == 0 || image.Width == 0 || image.Height == 0)
            {
                return pictureBoxPoint;
            }

            // This is the one that gets a little tricky. Essentially, need to check 
            // the aspect ratio of the image to the aspect ratio of the control
            // to determine how it is being rendered
            float imageAspect = (float)image.Width / image.Height;
            float controlAspect = (float)pictureBox.Width / pictureBox.Height;
            float newX = pictureBoxPoint.X;
            float newY = pictureBoxPoint.Y;
            if (imageAspect > controlAspect)
            {
                // This means that we are limited by width, 
                // meaning the image fills up the entire control from left to right
                float ratioWidth = (float)image.Width / pictureBox.Width;
                newX *= ratioWidth;
                float scale = (float)pictureBox.Width / image.Width;
                float displayHeight = scale * image.Height;
                float diffHeight = pictureBox.Height - displayHeight;
                diffHeight /= 2;
                newY -= diffHeight;
                newY /= scale;
            }
            else
            {
                // This means that we are limited by height, 
                // meaning the image fills up the entire control from top to bottom
                float ratioHeight = (float)image.Height / pictureBox.Height;
                newY *= ratioHeight;
                float scale = (float)pictureBox.Height / image.Height;
                float displayWidth = scale * image.Width;
                float diffWidth = pictureBox.Width - displayWidth;
                diffWidth /= 2;
                newX -= diffWidth;
                newX /= scale;
            }
            return new Point((int)Math.Round(newX, MidpointRounding.AwayFromZero),
                            (int)Math.Round(newY, MidpointRounding.AwayFromZero));
        }

        public static Point FromImageToZoomPictureBoxCoordinates(PictureBox pictureBox, Point imagePoint)
        {
            var image = pictureBox.Image;

            // test to make sure our image is not null
            if (image == null)
            {
                return imagePoint;
            }

            // Make sure our control width and height are not 0 and our 
            // image width and height are not 0
            if (pictureBox.Width == 0 || pictureBox.Height == 0 || image.Width == 0 || image.Height == 0)
            {
                return imagePoint;
            }

            // This is the one that gets a little tricky. Essentially, need to check 
            // the aspect ratio of the image to the aspect ratio of the control
            // to determine how it is being rendered
            float imageAspect = (float)image.Width / image.Height;
            float controlAspect = (float)pictureBox.Width / pictureBox.Height;
            float newX = imagePoint.X;
            float newY = imagePoint.Y;
            if (imageAspect > controlAspect)
            {
                // This means that we are limited by width, 
                // meaning the image fills up the entire control from left to right
                float ratioWidth = (float)pictureBox.Width / image.Width;
                newX *= ratioWidth;
                float scale = (float)pictureBox.Width / image.Width;
                float displayHeight = scale * image.Height;
                float diffHeight = pictureBox.Height - displayHeight;
                diffHeight /= 2;
                newY *= scale;
                newY += diffHeight;
            }
            else
            {
                // This means that we are limited by height, 
                // meaning the image fills up the entire control from top to bottom
                float ratioHeight = (float)pictureBox.Height / image.Height;
                newY *= ratioHeight;
                float scale = (float)pictureBox.Height / image.Height;
                float displayWidth = scale * image.Width;
                float diffWidth = pictureBox.Width - displayWidth;
                diffWidth /= 2;
                newX *= scale;
                newX += diffWidth;
            }
            return new Point((int)Math.Round(newX, MidpointRounding.AwayFromZero),
                            (int)Math.Round(newY, MidpointRounding.AwayFromZero));
        }

        public static Rectangle FromImageToZoomPictureBoxCoordinates(PictureBox pictureBox, Rectangle imageRectangle)
        {
            var topLeftCorner = FromImageToZoomPictureBoxCoordinates(pictureBox, imageRectangle.Location);
            var bottomRightCorner = FromImageToZoomPictureBoxCoordinates(pictureBox, new Point(imageRectangle.Right, imageRectangle.Bottom));

            return new Rectangle(topLeftCorner,
                                new Size(bottomRightCorner.X - topLeftCorner.X, bottomRightCorner.Y - topLeftCorner.Y));
        }

        public static Rectangle FromZoomPictureBoxToImageCoordinates(PictureBox pictureBox, Rectangle pictureBoxRectangle)
        {
            var topLeftCorner = FromZoomPictureBoxToImageCoordinates(pictureBox, pictureBoxRectangle.Location);
            var bottomRightCorner = FromZoomPictureBoxToImageCoordinates(pictureBox, new Point(pictureBoxRectangle.Right, pictureBoxRectangle.Bottom));

            return  new Rectangle(topLeftCorner,
                                new Size(bottomRightCorner.X - topLeftCorner.X, bottomRightCorner.Y - topLeftCorner.Y));
        }
    }
}
