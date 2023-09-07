using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string HasScale { get; set; }

        public string AreDinosaurs { get; set; }

        public bool AreColdBlooded { get; set; }

        public string EatsMeat { get; set; }

        public void PrintReptileDetails()
        {
            Console.WriteLine($"Do all reptiles have scales? {HasScale}- Are reptiles dinosaurs? {AreDinosaurs}" +
                $"- They seem aggitated, are they cold blooded? {AreColdBlooded}- Do they enjoy eating meat? {EatsMeat}");
        }
    }
}
