using System;
using System.Globalization;

namespace Practical2_OPPPO.Films.Factory
{
    static class FilmFactory
    {
        public static Film CreateFilm(int lineNumber, string data)
        {
            string[] parameters = data.Split(';');
            const int parametersCount = 4;

            if (parameters.Length != parametersCount)
                throw new ArgumentException($"Incorrect input data in line {lineNumber}: {data}");

            switch (parameters[1].ToLower())
            {
                case FilmType.Feature:
                    return new FeatureFilm(parameters[0], parameters[2], float.Parse(parameters[3], CultureInfo.InvariantCulture));
                case FilmType.Cartoon:
                    return new CartoonFilm(parameters[0], GetCartoonType(lineNumber, parameters[2]),
                        float.Parse(parameters[3], CultureInfo.InvariantCulture));
                case FilmType.Horror:
                    return new HorrorFilm(parameters[0], parameters[2], float.Parse(parameters[3], CultureInfo.InvariantCulture));
                default:
                    throw new ArgumentException($"Incorrect type of film in line {lineNumber}: {parameters[1]}");
            }
        }

        private static string GetCartoonType(int lineNumber, string type)
        {
            switch (type.ToLower())
            {
                case CartoonType.Drawn:
                    return CartoonType.Drawn;
                case CartoonType.Plasticine:
                    return CartoonType.Plasticine;
                case CartoonType.Dollish:
                    return CartoonType.Dollish;
                default:
                    throw new ArgumentException($"Incorrect type of cartoon in line {lineNumber}: {type}");
            }
        }
    }
}
