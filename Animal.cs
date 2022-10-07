using System;
namespace Project
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
        }

        public void Running() {
            Console.WriteLine("Animal is running");
        }
        // lop triu tuong 
        public abstract void ShowSound();
    }
}
