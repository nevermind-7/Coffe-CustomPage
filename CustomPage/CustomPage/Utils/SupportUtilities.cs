using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CustomPage.Utils
{
    static public class SupportUtilities
    {
        #region TimeStamp (Long Format)
        public static long GetTimeStamp()
        {
            return Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmssffff"));
        }
        #endregion

        // Get a MD5 hash string
        public static string GetMd5Hash(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.

            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        #region DeepClone
        // Deep clone
        public static T DeepClone<T>(this T a)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
        #endregion

        #region SHA256
        // Get a SHA256 hash string
        public static string getSHA256(string input)
        {
            // Initialize a SHA256 hash object.
            SHA256 mySHA256 = SHA256Managed.Create();

            byte[] hashValue;

            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes("Usr@" + input);

            //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
            MemoryStream stream = new MemoryStream(byteArray);

            // Compute the hash of the fileStream.
            hashValue = mySHA256.ComputeHash(stream);

            // Convert byteArray to string
            string result = PrintByteArray(hashValue);

            return result;
        }

        // Get a SHA256 hash string for B2B Password
        public static string getB2BSha256(string input)
        {
            // Initialize a SHA256 hash object.
            SHA256 mySHA256 = SHA256Managed.Create();

            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes("Usr#" + input + "B2b");

            //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
            MemoryStream stream = new MemoryStream(byteArray);

            // Compute the hash of the fileStream.
            var hashValue = mySHA256.ComputeHash(stream);

            // Convert byteArray to string
            string result = PrintByteArray(hashValue);

            return result;
        }

        // Print the byte array in a readable format.
        private static string PrintByteArray(byte[] array)
        {
            string result = string.Empty;
            int i;
            for (i = 0; i < array.Length; i++)
            {
                result = result + String.Format("{0:X2}", array[i]);
            }
            return result;
        }
        #endregion

        #region SkippFields Builder
        public static string skipFieldsBuilder(string _columnPrimaryKey, string[] _skipFields)
        {
            // Generate string with skip fields
            String SkipFields = _columnPrimaryKey;
            foreach (var item in _skipFields)
                SkipFields += " " + item;
            return SkipFields;
        }
        #endregion

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image)
        {
            int width = 200;
            int height = 285;

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.Low;
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}