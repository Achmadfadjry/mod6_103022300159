using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modul6_103022300159
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(!string.IsNullOrEmpty(title), "Judul video tidak boleh null atau kosong.");
            Contract.Requires(title.Length <= 200, "Judul video maksimal 200 karakter.");

            this.id = new Random().Next(10000, 99999); // Generate ID random 5 digit
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count > 0, "Play count harus positif.");
            Contract.Requires(count <= 25000000, "Play count maksimal 25.000.000 per panggilan.");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Penambahan play count melebihi batas integer!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Jumlah Diputar: {playCount}");
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}

    

   




