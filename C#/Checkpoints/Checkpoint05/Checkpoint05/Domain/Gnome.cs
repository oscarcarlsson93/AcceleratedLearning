using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint05.Domain
{
    class Gnome
    {
        public int GnomeId { get; set; }
        public string GnomeName { get; set; }
        public string Beard { get; set; }
        public string IsEvil { get; set; }
        public int Temperament { get; set; }
        public int RaceId { get; set; }

        public string Race { get; set; }

    }
}
