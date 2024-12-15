
namespace serialization
{
    internal class Album
    {
        public Album(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public string Title { get; set; }
        public string Artist { get; set; }

        public override string ToString()
        {
            return $"Artist: {Artist}, Album: {Title}";
        }
    }
}
