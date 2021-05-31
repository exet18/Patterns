using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Video : Goods
    {
        private string _author;
        private string _videoName;
        private int _duration;
        public Video(string author, string videoName, int amout, int durationM)
        {
            _author = author;
            _videoName = videoName;
            _duration = durationM;
            _amout = amout;
        }

        public override void Output()
        {
            Console.WriteLine("Author: " + _author);
            Console.WriteLine("VideoName: " + _videoName);
            Console.WriteLine("Duration in m: " + _duration);
            Console.WriteLine("Amout: " + _amout);

        }
    }
}
