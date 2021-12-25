namespace Playlist2
{
    public sealed class Music : IEquatable<Music?>
    {
        public Music(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Music);
        }

        public bool Equals(Music? other)
        {
            return other != null &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public static bool operator ==(Music? left, Music? right)
        {
            return EqualityComparer<Music>.Default.Equals(left, right);
        }

        public static bool operator !=(Music? left, Music? right)
        {
            return !(left == right);
        }
    }
}