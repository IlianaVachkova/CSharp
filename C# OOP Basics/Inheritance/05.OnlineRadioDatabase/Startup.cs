using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        int numberOfSongs = int.Parse(Console.ReadLine());
        List<Song> playlist = new List<Song>();
        long totalSecunds = 0;

        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] songInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (songInfo.Length < 3)
            {
                Console.WriteLine("Invalid song.");
            }

            try
            {
                var currentSong = new Song(songInfo[0], songInfo[1], songInfo[2]);
                Console.WriteLine(currentSong);
                playlist.Add(currentSong);
                totalSecunds += currentSong.GetSongSeconds();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine("Songs added: {0}", playlist.Count);
        long finalSec = totalSecunds % 60;
        long finalMin = (totalSecunds / 60) % 60;
        long finalHour = (totalSecunds / 60) / 60;
        Console.WriteLine("Playlist length: {0}h {1}m {2}s", finalHour, finalMin, finalSec);
    }
}
