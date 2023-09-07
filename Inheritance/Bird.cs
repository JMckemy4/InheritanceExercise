using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string HaveWings { get; set; }   

        public string Feathers { get; set; }

        public bool CanFly { get; set; }

        public bool AreFast { get; set; }

        public void PrintBirdDetails()
        {
            Console.WriteLine($"Does a bird have wings? {HaveWings}- What are birds covered in? {Feathers}- Can birds fly? {CanFly}" +
                $"- Birds are speed demons??{AreFast}");
        }
    }
}
