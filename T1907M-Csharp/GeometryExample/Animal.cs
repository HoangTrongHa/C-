using System;

namespace buoi2.GeometryExample
{
    public class Animal
    {
        protected int weight;
        protected string name;

        public Animal()
        {
        }

        public Animal(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name : " + name + " Weight : " + weight);
        }

        public virtual void SetMe(string name, int weight)
        {
            
        }
    }
}