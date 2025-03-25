using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_103022300159
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username { get; private set; }

        public SayaTubeUser(string username)
        {
            Contract.Requires(!string.IsNullOrEmpty(username), "Username tidak boleh null kosong.");
            Contract.Requires(username.Length <= 100, "Username maksimal 100 karakter.");

            this.id = new Random().Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Contract.Requires(video != null, "Video tidak boleh kosong.");
            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");

            int count = 0;
            foreach (var video in uploadedVideos)
            {
                if (count >= 8) break; 
                Console.WriteLine($"Video {count + 1} judul: {video.GetTitle()}");
                count++;
            }

            Console.WriteLine($"Total Play Count: {GetTotalVideoPlayCount()}");
        }
    }
}