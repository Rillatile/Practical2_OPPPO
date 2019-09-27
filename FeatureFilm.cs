namespace Practical2_OPPPO.Films
{
    public class FeatureFilm : Film
    {
        public string Producer { get; private set; }

        public FeatureFilm(string title, string producer, float rating) : base(title, rating)
        {
            Producer = producer;
        }

        public override string ToString()
        {
            return $"Title: {Title}, producer: {Producer}, rating: {Rating}";
        }
    }
}
