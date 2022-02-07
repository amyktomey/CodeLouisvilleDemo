using System;
namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("This is AlPhAbEt SoUp\n");

            Console.WriteLine("How would you like your alphabet?\n");
            Console.WriteLine("1: A-Z");
            Console.WriteLine("2: Z-A"); 
            Console.WriteLine("3: Skipping letters");
            Console.WriteLine("4: Exit");
            Console.WriteLine("Please type 1, 2, 3 or 4 to naviagte:\n");
            string MyOptions;
            MyOptions = Console.ReadLine();

            switch (MyOptions)

            {
                case "1":
                    CreateAlphabet();
                    break;
                case "2":
                    CreateAlphabetBackwards();
                    break;
                case "3":
                    CreateAlphabetSkip();
                    break;
                case "4":
                    Exit();
                    break;

            }

            MainMenu();
        }

        //{
        //    Console.WriteLine(CreateAlphabet());
 
        //    string backwards = CreateAlphabetBackwards();
        //    Console.WriteLine(backwards);

        //    Console.Write("How many letters would you like to skip:  ");
        //    var userInput = Console.ReadLine();

        //    int numberToSkip = int.Parse (userInput);
        //    string? skip = CreateAlphabetSkip(numberToSkip);
        //    Console.WriteLine(skip);
        //}
        static string CreateAlphabet()
        {
            string alphabet = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet += alpha;
            }
            Console.WriteLine (CreateAlphabet());
        }
        static string CreateAlphabetBackwards()
        {
            string backwards = "";
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                backwards += alpha;
            }
            Console.WriteLine(CreateAlphabetBackwards());
        }
        static string CreateAlphabetSkip()
            {
            Console.Write("How many letters would you like to skip:  ");
            var userInput = Console.ReadLine();

            int numberToSkip = int.Parse(userInput);
            // string? skip = CreateAlphabetSkip(numberToSkip);
            //Console.WriteLine(skip);
        
            string alphabetSkipped = "";
            for (char alpha = 'A'; alpha <= 'Z';)
            {   
                alphabetSkipped += alpha;
                for (int i = 0; i < numberToSkip; i++)
                {
                    alpha++;
                }
            }
            Console.WriteLine(CreateAlphabetSkip());
       }
        static void Exit()
        {
            Console.WriteLine("are you sure you would like to leave the program?");
            Console.WriteLine("Press ENTER to confirm!");
            Console.ReadLine();
            System.Environment.Exit(1);
        }
    }
}