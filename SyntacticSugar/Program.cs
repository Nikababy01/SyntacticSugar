using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var predators = new List<string>();
            predators.Add("AntEater");
            predators.Add("Termites");

            var prey = new List<string>();
            prey.Add("Carrion");
            prey.Add("Sugar");

            //expression body function method
            var bug = new Bug("Monique", "ant", predators, prey);
            Console.WriteLine(bug.FormalName);

            Console.WriteLine("Hello");
        }
    }

    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code.
        */
        public string Name { get; } = "";
        public string Species { get; } = "";
        public List<string> Predators { get; } = new List<string>();
        public List<string> Prey { get; } = new List<string>();

        // Convert this readonly property to an expression member
        public string FormalName => $"{Name} the {Species}";
        //{
        //    get
        //    {
        //        return $"{Name} the {Species}";
        //    }
        //}

        //// Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            this.Name = name;
            this.Species = species;
            this.Predators = predators;
            this.Prey = prey;
        }

        // Convert this method to an expression member
        public string PreyList() => string.Join(",", this.Prey);
        //{
        //    var commaDelimitedPrey = string.Join(",", this.Prey);
        //    return commaDelimitedPrey;
        //}

        // Convert this method to an expression member
        //public string PredatorList()
        //{
        //    var commaDelimitedPredators = string.Join(",", this.Predators);
        //    return commaDelimitedPredators;
        //}

        //// Convert this to expression method
        //public string Eat(string food)
        //{
        //    if (this.Prey.Contains(food))
        //    {
        //        return $"{this.Name} ate the {food}.";
        //    }
        //    else
        //    {
        //        return $"{this.Name} is still hungry.";
        //    }
    }
    }
