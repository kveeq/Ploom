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
            lst.Add(new Furniture("Furniture1", "Furniture Description 1", "5000 P"));
            lst.Add(new Furniture("Furniture2", "Furniture Description 2", "5000 P"));
            lst.Add(new Furniture("Furniture3", "Furniture Description 3", "5000 P"));
            lst.Add(new Furniture("Furniture4", "Furniture Description 4", "5000 P"));
        }
    }
}
