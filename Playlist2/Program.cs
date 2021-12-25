using Playlist2;

var playlist = new Playlist("p1");

var musics = new Music[]
{
    new Music("M1"),
    new Music("M2"),
    new Music("M3"),
    new Music("M4"),
    new Music("M5")
};

playlist.SetPlayList(musics);

foreach (var music in playlist.PlayAll())
{
    Console.WriteLine(music);
}

playlist.AddAfter(new Music("M3"), new Music("M10"));

Console.WriteLine("\nadd M10 after M3\n");

foreach (var music in playlist.PlayAll())
{
    Console.WriteLine(music);
}

playlist.AddBefore(new Music("M2"), new Music("M11"));

Console.WriteLine("\nAdd M11 before M2\n");

foreach (var music in playlist.PlayAll())
{
    Console.WriteLine(music);
}

Console.WriteLine($"\nAtual music {playlist.PlayAtual()}\n");
Console.WriteLine($"\nNext music {playlist.PlayNext()}\n");
Console.WriteLine($"\nPrevious music {playlist.PlayPrevious()}\n");
Console.WriteLine($"\nFind music M4 {playlist.Find("M4")}\n");
