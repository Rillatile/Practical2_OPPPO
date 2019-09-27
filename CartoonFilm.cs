namespace Practical2_OPPPO.Films
{
    public class CartoonFilm : Film
    {
        public string Type { get; private set; }
        public CartoonFilm(string title, string type, float rating) : base(title, rating)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Title: {Title}, type: {Type}, rating: {Rating}";
        }
    }
}
