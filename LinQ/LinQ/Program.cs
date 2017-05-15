using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueryStringArray();
            //QueryIntArray();

            //QuerryArrayList();

            //QueryCollectionList();

            QueryAnimalData();

            Console.ReadKey();
        }

        private static void QueryStringArray()
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B.Barkin", "Lassie", "Snoopy" };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach(var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 60 };

            var gt20 = from num in nums
                       where num > 20
                       select num;

            foreach(var i in gt20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();


            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }

            return gt20.ToArray();
        }
        
        static void QuerryArrayList()
        {
            ArrayList famAnimals = new ArrayList() 
            { 
                new Animal("Heidi", .8, 18),
                new Animal("Shrek", 4, 130),
                new Animal("COngo", 3.8, 90)
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach (var sn in smAnimals)
            {
                Console.WriteLine("{0}   {1}   {2}", sn.Name, sn.Weight, sn.Height);
            }
        }

        static void QueryCollectionList()
        {
           var famAnimals = new List<Animal>() 
            { 
                new Animal("Heidi", .8, 18),
                new Animal("Shrek", 4, 130),
                new Animal("COngo", 3.8, 90)
            };

            
            var smAnimals = from animal in famAnimals
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach (var sn in smAnimals)
            {
                Console.WriteLine("{0}   {1}   {2}", sn.Name, sn.Weight, sn.Height);
            }
        }

        static void QueryAnimalData()
        {
            Animal[] animals = new [] 
            { 
                new Animal("German", 25, 77, 1),
                new Animal("Seru", 7, 4.4, 2),
                new Animal("Tommy", 30, 200, 3),
                new Animal("Pug", 12, 16, 1),
                new Animal("Beagle", 15, 23, 2)
            };

            Owner[] owners = new[] 
            {
                new Owner("Rahul Nishant", 1),
                new Owner("Sally Smith", 2),
                new Owner("Paul Brooks", 3)
            };

            Owner ow = new Owner("sasas", 2);

            var nameHeight = from a in animals
                                select new
                                {
                                    a.Name,
                                    a.Height
                                };

            Array arrNameHeight = nameHeight.ToArray();

            foreach (var i in arrNameHeight)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine();

            var innerJoin = from animal in animals
                            join owner in owners on animal.AnimalId
                            equals owner.OwnerID
                            select new
                            {
                                OwnerName = owner.Name,
                                AnimalName = animal.Name
                            };

            foreach (var i in innerJoin)
            {
                Console.WriteLine("{0} owns {1}", i.OwnerName , i.AnimalName);
            }

            Console.WriteLine("\n");

            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals on owner.OwnerID
                            equals animal.AnimalId into OwnerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animals = from ownr in OwnerGroup
                                          orderby ownr.Name
                                          select ownr
                            };

            foreach (var i in groupJoin)
            {
                Console.WriteLine(i.Owner);
                foreach(var x in i.Animals)
                    Console.WriteLine("* " + x.Name);
            }

        }
    }
}
