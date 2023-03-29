using System;
using System.Collections.Generic;
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
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
            this.id = new Random().Next(10000, 99999);
        }

        public int GetTotalVideoPlayCount()
        {
            int jum = 0;
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                jum += uploadedVideos[i].playCount;
            }
            return jum;
        }

        public void AddVideo(SayaTubeVideo video)
        {
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
