using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int songsNumber = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsNumber; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split("_")
                    .ToArray();
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song();

                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string filter = Console.ReadLine();

            if (filter != "all")
            {
                foreach (Song song in songs.Where(s => s.TypeList == filter))
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
