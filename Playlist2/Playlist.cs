namespace Playlist2
{
    public class Playlist
    {
        private LinkedListNode<Music> Music { get; set; }
        private LinkedList<Music> Musics { get; set; }
        public string Name { get; }

        public Playlist(string name)
        {
            Name = name;
            Musics = new LinkedList<Music>();
            Music = new LinkedListNode<Music>(null!);
        }

        public void SetPlayList(params Music[] musics)
        {
            Musics = new LinkedList<Music>(musics);
            Music = Musics.First!;
        }

        public Music PlayAtual()
        {
            return Music.Value;
        }

        public Music PlayNext()
        {
            Music = Music.Next!;
            return Music.Value;
        }

        public Music PlayPrevious()
        {
            Music = Music.Previous!;
            return Music.Value;
        }

        public Music Find(string name)
        {
            return Find(new Music(name));
        }

        public Music Find(Music music)
        {
            return Musics.Find(music)!.Value;
        }

        public IEnumerable<Music> PlayAll()
        {
            return Musics.AsEnumerable();
        }

        public void AddAfter(Music after, Music music)
        {
            var node = Musics.Find(after);
            Musics.AddAfter(node!, music);
        }

        public void AddBefore(Music before, Music music)
        {
            var node = Musics.Find(before);
            Musics.AddBefore(node!, music);
        }
    }
}