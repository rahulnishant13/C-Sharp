using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalId { get; set; }

        public Animal(string Name, double Height, double Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Height = Height;
        }

        public Animal(string Name, double Height, double Weight, int AnimalId)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Height = Height;
            this.AnimalId = AnimalId;
        }
    }

    class Owner
    {
        public string Name { get; set; }
        public int OwnerID { get; set; }

        public Owner(string Name, int OwnerId)
        {
            this.Name = Name;
            this.OwnerID = OwnerId;
        }
    }
    
}
