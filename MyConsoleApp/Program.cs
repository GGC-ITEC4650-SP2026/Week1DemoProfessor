using System;

public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello 4650!");
        //Fruit f = new Fruit("Pear", 1.05);
        //Console.WriteLine(f);
        /* GUESSING GAME
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
        */
        //INIT MAP
        string[,] a = new string[4,4];
        for(int y = 0; y < 4; y++) {
            for(int x = 0; x < 4; x++) {
                a[x, y] = ".";
            }
        }
        a[3, 0] = "L";
        a[1, 2] = "L";
        a[2, 2] = "L";

        printMap(a);
    }

    public static void printMap(string[,] map)
    {
        //DISPLAY MAP
        for(int y = 0; y < 4; y++) {
            for(int x = 0; x < 4; x++) {
                Console.Write(map[x, y] + " ");
            }
            Console.WriteLine();
        }        
    }

}
