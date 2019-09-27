namespace Practical2_OPPPO.Films
{
    public class Film
    {
        public string Title { get; private set; }
        public float Rating { get; private set; }

        public int TitleLength
        {
            get
            {
                return Title.Length;
            }
        }

        public Film(string title, float rating)
        {
            Title = title;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"Title: {Title}, rating: {Rating}";
        }
    }
}
