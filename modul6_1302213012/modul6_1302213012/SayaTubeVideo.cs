using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title.Length <= 200);
            Contract.Requires(title != null);

            try
            {
                checked
                {
                    this.title = title;
                    this.playCount = 0;
                    this.id = new Random().Next(10000, 99999);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void IncreasePlayCount(int playCount)
        {
            Contract.Requires(playCount <= 2500000);
            Contract.Requires(playCount > 0);

            try
            {
                checked
                {
                    this.playCount = playCount;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
