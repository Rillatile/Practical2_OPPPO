using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2_OPPPO.Films
{
    class CartoonFilm : Film
    {
        public string Type { get; private set; }
        public CartoonFilm(string title, string type) : base(title)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Title: {Title}, type: {Type}";
        }
    }
}
