using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213012
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(String username)
        {
            Debug.Assert(username != null);
            Debug.Assert(username.Length <= 100);
            
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
            this.id = new Random().Next(10000, 99999);
        }

        public int GetTotalVideoPlayCount()
        {
            int jum = 0;

            try
            {
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    checked
                    {
                        jum += uploadedVideos[i].playCount;
                    }
                }
                return jum;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return jum;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null);
            Debug.Assert(video.getPlayCount() <= int.MaxValue);

            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoCount()
        {
            Console.WriteLine("User: " + username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].title + " Count " + uploadedVideos[i].getPlayCount());
            }
        }
    }
}
