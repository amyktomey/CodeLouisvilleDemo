using System;
namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateAlphabet());
 
            string backwards = CreateAlphabetBackwards();
            Console.WriteLine(backwards);

            Console.Write("How many letters would you like to skip:  ");
            var userInput = Console.ReadLine();

            int numberToSkip = int.Parse (userInput);
            string? skip = CreateAlphabetSkip(numberToSkip);
            Console.WriteLine(skip);
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
        static string CreateAlphabetSkip(int skip)
        {
            string alphabetSkipped = "";
            for (char alpha = 'A'; alpha <= 'Z';)
            {   
                alphabetSkipped += alpha;
                for (int i = 0; i < skip; i++)
                {
                    alpha++;
                }
            }
            return alphabetSkipped;
        }
    }
}