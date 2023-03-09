using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Prog_122_W23_Lecture_15_TopicReview
{
    internal class Block
    {
       public enum Filter { regualer,grayskill};

        string header;
        string body;
        BitmapSource _photo;
        Filter filter;

        public Block(string header, string body, string filePath, Filter filter)
        {
            this.header = header;
            this.body = body;
            this.filter = filter;

            if (filter == Filter.grayskill)
            {
                _photo = GenerateGreyScale(GenerateImage(filePath));

            }
            else
            {
                _photo = GenerateImage(filePath);
            }
    
        }

        public string Header { get => header; set => header = value; }
        public string Body { get => body; set => body = value; }
        public BitmapSource Photo { get => _photo; set => _photo = value; }
        internal Filter Filter1 { get => filter; set => filter = value; }

        private BitmapImage GenerateImage(string filePath)
        {
            // New URI
            // New BitmapImage
            //Uri uri = new Uri(filePath);
            //BitmapImage bitmap = new BitmapImage(uri);
            //return bitmap;
            return new BitmapImage(new Uri(filePath));
        }

       

        private FormatConvertedBitmap GenerateGreyScale(BitmapImage bitmap)
        {
            // Createa a new FormatCOnvertedBitmap
            FormatConvertedBitmap format = new FormatConvertedBitmap();

            // Begin Init
            format.BeginInit();
            // Attach Source
            format.Source = bitmap;
            // Change to greyscale
            format.DestinationFormat = PixelFormats.Gray32Float;

            // End Init
            format.EndInit();
            return format;
        }

        // Header - Body
        public override string ToString()
        {
            return $"{header}-{body}";
        }
    }
}
