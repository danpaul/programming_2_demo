
namespace serialization
{
    internal class User
    {
        public User(string name, List<Album> favoriteAlbums)
        {
            Name = name;
            FavoriteAlbums = favoriteAlbums;
        }

        public string Name { get; set; }
        public List<Album> FavoriteAlbums { get; set; }

        public override string ToString()
        {
            string userString = $"{Name}\n\nFavorite albums:\n";
            foreach (Album album in FavoriteAlbums)
            {
                userString += $"- {album}\n";
            }
            return userString;
        }
    }
}
