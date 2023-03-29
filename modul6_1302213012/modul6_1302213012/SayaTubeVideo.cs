using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213012
{
    internal class SayaTubeVideo
    {
        public int id, playCount;
        public string title;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = 0;
            this.id = new Random().Next(10000, 99999);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
