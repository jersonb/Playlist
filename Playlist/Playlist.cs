namespace PlaylistApp
{
    public class Playlist
    {
        private Music? Music { get; set; }
        public string Name { get; }

        public Playlist(string name)
        {
            Name = name;
        }

        public void SetPlayList(params Music[] musics)
        {
            Music = musics[0];
            for (int i = 0; i < musics.Length - 1; i++)
            {
                musics[i].Next = musics[i + 1];
                musics[i].Next.Previous = musics[i];
            }
        }

        public Music PlayAtual()
        {
            if (Music == null)
                throw new InvalidOperationException();
            return Music;
        }

        public Music PlayNext()
        {
            if (Music == null)
                throw new InvalidOperationException();

            if (Music.Next != null)
                Music = Music.Next;

            return Music;
        }

        public Music PlayPrevious()
        {
            if (Music == null)
                throw new InvalidOperationException();

            if (Music.Previous != null)
                Music = Music.Previous;

            return Music;
        }

        public Music Find(string name)
        {
            var music = new Music(name);

            return Find(music);
        }

        public Music Find(Music music)
        {
            if (Music == null)
                throw new InvalidOperationException();

            while (Music != null && !Music.Equals(music))
            {
                Music = Music.Next;
            }

            if (Music == null)
                throw new InvalidOperationException();

            return Music;
        }

        public IEnumerable<Music> PlayAll()
        {
            var refMusic = Music;

            while (refMusic != null)
            {
                yield return refMusic;
                refMusic = refMusic.Next;
            }
        }

        public void AddAfter(Music after, Music music)
        {
            var musics = new Music[1];
            var refMusic = Music;
            var i = 0;

            while (refMusic != null)
            {
                Array.Resize(ref musics, i + 1);
                musics.SetValue(refMusic, i++);

                if (refMusic.Equals(after))
                {
                    Array.Resize(ref musics, i + 1);
                    musics.SetValue(music, i++);
                }
                refMusic = refMusic.Next;
            }

            SetPlayList(musics);
        }

        public void AddBefore(Music before, Music music)
        {
            var musics = new Music[1];
            var refMusic = Music;
            var i = 0;

            while (refMusic?.Next != null)
            {
                Array.Resize(ref musics, i + 1);
                musics.SetValue(refMusic, i++);

                if (refMusic.Next.Equals(before))
                {
                    Array.Resize(ref musics, i + 1);
                    musics.SetValue(music, i++);
                }
                refMusic = refMusic.Next;
            }

            SetPlayList(musics);
        }
    }
}