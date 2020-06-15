using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            FlavorComparer comparer = new FlavorComparer();
            ConeComparer comparer2 = new ConeComparer();

            /*foreach (Flavor flav in availableFlavors)
            {
                Console.WriteLine(flav);
            }
            availableFlavors.Sort(comparer);
            foreach(Flavor flav in availableFlavors)
            {
                Console.WriteLine(flav);
            }*/
            /*foreach(Cone con in availableCones)
            {
                Console.WriteLine(con);
            }
            availableCones.Sort(comparer2);
            foreach(Cone con in availableCones)
            {
                Console.WriteLine(con);
            }*/
            foreach (Flavor flav in availableFlavors)
            {
                Console.WriteLine(flav);
            }
            availableFlavors.Sort(comparer);
            foreach (Flavor flav in availableFlavors)
            {
                Console.WriteLine(flav);
            }


            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
