using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public bool HaveEyes { get; set; }

        public string GreatHearing { get; set; }

        public string CanRunFast { get; set; }

        public string FightOrFlight { get; set; }

        public void PrintAnimalDetails ()
        {
            Console.WriteLine($"Do all animals have eyes? {HaveEyes}- Do they all have great hearing? {GreatHearing}" +
                $"- Are animals quick? {CanRunFast}- Hey do we have fight or flight like animals? {FightOrFlight} ");
        }
    }
}
