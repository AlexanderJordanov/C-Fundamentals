using System.ComponentModel;

class Programm
{
    static void Main()
    {
        int numberOfSongs = int.Parse(Console.ReadLine());
        List<Song> playlist = new List<Song>();
        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] songTokens = Console.ReadLine().Split("_");

            string typeList = songTokens[0];
            string songName = songTokens[1];
            string songTime = songTokens[2];

            Song song = new Song(typeList, songName, songTime);

            playlist.Add(song);
        }

        string filter = Console.ReadLine();
        if (filter != "all")
        {
            for (int i = 0; i < playlist.Count; i++)
            {
                Song currentSong = playlist[i];

                if (currentSong.TypeList != filter)
                {
                    playlist.RemoveAt(i);
                    i--;
                }
            }
        }

        foreach (Song song in playlist)
        {
            Console.WriteLine(song.Name);
        }
    }


    public class Song
    {
        public Song()
        {

        }
        public Song(string typeList, string songName, string songTime)
        {
            TypeList = typeList;
            Name = songName;
            Time = songTime;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }



}
