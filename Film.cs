using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2_OPPPO.Films
{
    class Film
    {
        public string Title { get; private set; }

        public Film(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"Title: {Title}";
        }
    }
}
