using System;
using System.Linq;

public class Song
{
    private string artistName;
    private string songName;
    private string songLength;

    public Song(string artistName, string songName, string songLength)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongLength = songLength;
    }

    public string ArtistName
    {
        get
        {
            return this.artistName;
        }

        private set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }

            this.artistName = value;
        }
    }

    public string SongName
    {
        get
        {
            return this.songName;
        }

        private set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }

            this.songName = value;
        }
    }

    public string SongLength
    {
        get
        {
            return this.songLength;
        }

        private set
        {
            string tempValue = value;
            int[] minsAndSecs = tempValue.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int seconds = minsAndSecs[0] * 60 + minsAndSecs[1];

            if (seconds < 0 || seconds > 899)
            {
                throw new ArgumentException("Invalid song length.");
            }

            if (minsAndSecs[0] < 0 || minsAndSecs[0] > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }

            if (minsAndSecs[1] < 0 || minsAndSecs[1] > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }

            this.songLength = value;
        }
    }

    public int GetSongSeconds()
    {
        int[] timeInfo = this.SongLength.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int seconds = timeInfo[0] * 60 + timeInfo[1];

        return seconds;
    }

    public override string ToString()
    {
        return "Song added.";
    }
}