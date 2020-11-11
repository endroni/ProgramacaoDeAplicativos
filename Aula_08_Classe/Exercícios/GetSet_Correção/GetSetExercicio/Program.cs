using System;

namespace GetSetExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Login a = new Login("rubem@gmail.com");

            a.SetLogin("rubao@gmail.com");

            Console.WriteLine(a.GetEmail());

        }
    }
}
