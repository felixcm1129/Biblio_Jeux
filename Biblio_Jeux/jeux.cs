using System;
using System.Collections.Generic;
using System.ComponentModel; //INotifyPropertyChange
using System.Text;

namespace Biblio_Jeux
{
    public class Jeux
    {
        public string titre { get; set; }
        public string éditeur { get; set; }
        public int année { get; set; }
        public string console { get; set; }
        public string description { get; set; }
        public string pochette { get; set; }
        public int côte { get; set; }

    }
}
