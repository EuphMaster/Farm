using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate the Urban Farm animals
            HoneyBee Cheerios = new HoneyBee();
            Cat Felix = new Cat();
            Rabbit Peter = new Rabbit();
            Lizard Larry = new Lizard();

            //The program begins

            Console.WriteLine("Hello and Welcome to my Urban Farm \nCan you guess what animals I have? \nPress Enter to continue...");          
            Console.ReadLine();

            Cheerios.Talk();
            Cheerios.Move();
            Cheerios.Sting();
            Cheerios.Clothes();
            Console.ReadLine();
            Console.Clear();

            Felix.Talk();
            Felix.Move();
            Felix.Sting();
            Felix.Clothes();
            Console.ReadLine();
            Console.Clear();

            Peter.Talk();
            Peter.Move();
            Peter.Sting();
            Peter.Clothes();
            Console.ReadLine();
            Console.Clear();

            Larry.Talk();
            Larry.Move();
            Larry.Sting();
            Larry.Clothes();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Good Job! \nPress Enter to exit the program");
            Console.ReadLine();
        }



    }
}

