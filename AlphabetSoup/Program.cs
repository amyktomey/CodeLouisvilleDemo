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
                                        string alpahabet = CreateAlphabet();
                                        Console.WriteLine(alpahabet);
                                        break;
                                case "2":                                       
                                         Console.WriteLine(CreateAlphabetBackwards());
                                        break;
                                case "3":
                                        Console.WriteLine(CreateAlphabetSkip());
                                        break;
                                case "4":
                                        Exit();
                                        break;
                                default:
                                        Console.WriteLine("Invalid menu Selection!");
                                        break;
                        }
                Console.ReadKey();
                    MainMenu();
                }

                static int Prompt4Integer(string prompt)
                {
                        int value;
                        bool wasANumber;
                        do
                        {
                                Console.Write(prompt);

                                string menuInput = Console.ReadLine();
                                wasANumber = int.TryParse(menuInput, out value);

                        } while (wasANumber);

                         return value;
                 }

                static string CreateAlphabet()
                {
                        string alphabet = "";
                        for (char alpha = 'A'; alpha <= 'Z'; alpha++)
                        {
                                alphabet += alpha;
                        }
                        return alphabet;
                }
                static string CreateAlphabetBackwards()
                {
                        string backwards = "";
                        for (char alpha = 'Z'; alpha >= 'A'; alpha--)
                        {
                                backwards += alpha;
                        }
                return backwards;
                }
                static string CreateAlphabetSkip()
                {
                        Console.Write("How many letters would you like to skip:  ");
                        var userInput = Console.ReadLine();

                        string alphabetSkip = "";
                        for (char alpha = 'A'; alpha <= 'Z';)
                        {
                                alphabetSkip += alpha;
                                for (int i = 0; i < int.Parse(userInput); i++)
                                {
                                    alpha++;
                                }
                        }
                        return alphabetSkip;
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