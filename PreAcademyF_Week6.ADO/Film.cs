﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.ADO
{
    internal class Film : Object
    {
        public int FilmId { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public int Durata { get; set; }


        public override string ToString()
        {
            return $"{FilmId} - {Titolo} - Genere: {Genere} - Durata: {Durata}";
        }
    }
}
