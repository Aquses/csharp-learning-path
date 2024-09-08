using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        // Displays Album information.
        public void DisplayAlbumInfo()
        {
            Console.WriteLine($"\nAlbum name: {albumName}");
            Console.WriteLine($"Artist/Band: {artistName}");
            Console.WriteLine($"Number of tracks: {numOfTracks}\nEnjoy listening!");

        }
        // Reads Album name.
        public void ReadAlbumName()
        {
            Console.WriteLine("What is the name of the of your favorite music album?");
            albumName = Console.ReadLine();
        }
        // Reads Artist/Band name.

        public void ReadArtistName()
        {
            Console.WriteLine($"What is the name of the Artist or Band for {albumName}");
            artistName = Console.ReadLine();
        }
        // Reads Tracks number.

        public void ReadTracks()
        {
            Console.WriteLine($"How many tracks does {albumName} have?");
            numOfTracks = int.Parse(Console.ReadLine());
        }

        public void Start()
        {
            Console.WriteLine("\nStarting the Album Program!\n");

            ReadAlbumName();
            ReadArtistName();
            ReadTracks();
            DisplayAlbumInfo();
        }
    }
}
