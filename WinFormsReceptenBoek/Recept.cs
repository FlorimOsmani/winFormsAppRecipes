using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsReceptenBoek
{
    public class Recept
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Ingrediënten { get; set; }
        public string Instructies { get; set; }
        public string ImageLink { get; set; }
    }
}
