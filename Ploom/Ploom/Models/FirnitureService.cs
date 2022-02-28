using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    public class FirnitureService
    {
        public static List<Furniture> lst = new List<Furniture>();

        public static void All()
        {
            lst.Add(new Furniture("Furniture 1", "Furniture Description 1", "5000 P", "Белый", "", "", ""));
            lst.Add(new Furniture("Furniture 2", "Furniture Description 2", "5000 P", "Белый", "", "", ""));
            lst.Add(new Furniture("Furniture 3", "Furniture Description 3", "5000 P", "Белый", "", "", ""));
            lst.Add(new Furniture("Furniture 4", "Furniture Description 4", "5000 P", "Белый", "", "", ""));
        }
    }
}
