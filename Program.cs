using System;
using System.IO;
using Practical2_OPPPO.Collections;
using Practical2_OPPPO.Films;
using Practical2_OPPPO.Films.Factory;

namespace Practical2_OPPPO
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Too few input parameters");
                return;
            }

            string[] lines;
            string inFilePath = args[0];
            string outFilePath = args[1];
            string logFilePath = args.Length > 2 ? args[2] : "log.txt";

            try
            {
                lines = File.ReadAllLines(inFilePath);
            }
            catch (Exception e)
            {
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {e.Message}{Environment.NewLine}");
                return;
            }

            MyList<Film> films = new MyList<Film>();
            int i = 0;

            foreach (string data in lines)
            {
                try
                {
                    films.Add(FilmFactory.CreateFilm(++i, data));
                }
                catch (Exception e)
                {
                    File.AppendAllText(logFilePath, $"{DateTime.Now}: {e.Message}{Environment.NewLine}");
                }
            }

            i = 0;
            File.WriteAllText(outFilePath, "");

            foreach (Film film in films)
                File.AppendAllText(outFilePath, $"{++i} - {film}{Environment.NewLine}");

            File.AppendAllText(outFilePath, $"Count of elements: {films.Count}{Environment.NewLine}");
        }
    }
}
