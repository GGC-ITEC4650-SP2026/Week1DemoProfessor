using System;

public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello 4650!");
        //Fruit f = new Fruit("Pear", 1.05);
        //Console.WriteLine(f);

        Random rgen = new Random();
        int secret = rgen.Next(1, 11);
        int guess = -1;
        bool gameover = false;
        while(!gameover)
        {
            // Get user input
            Console.Write("Enter num 1-10: ");   
            guess = int.Parse(Console.ReadLine());

            //Update state
            if(guess == secret)
            {
                gameover = true;
            }
            else {
                //Render
                Console.WriteLine("Not today!");
            }
        }
        Console.WriteLine("Winner Winner Chicken Dinner!");
    }
}
