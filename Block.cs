using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Prog_122_W23_Lecture_15_TopicReview
{
    internal class Block
    {
       public enum Filter { regualer,grayskill};

        string header;
        string body;
          BitmapImage _photo;
        Filter filter;

        public string Header { get => header; set => header = value; }
        public string Body { get => body; set => body = value; }
        public BitmapImage Photo { get => _photo; set => _photo = value; }
        internal Filter Filter1 { get => filter; set => filter = value; }

        public Block(string header, string body, BitmapImage photo, Filter filter)
        {
            this.header = header;
            this.body = body;
            _photo = photo;
            this.filter = filter;
        }

        // Header - Body
        public override string ToString()
        {
            return $"{header}-{body}";
        }
    }
}
