namespace DemoMenu
{

    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("");
            //Console.ReadLine();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my app!");
            Console.WriteLine("");
            Console.WriteLine("Option 1: Introduction");
            Console.WriteLine("Option 2: Calculations");
            Console.WriteLine("Option 3: Exit");
            Console.WriteLine("Please type 1, 2 or n 3 to naviagte");
            string MyOptions;
            MyOptions = Console.ReadLine();
                switch (MyOptions)
               
                {
                case "1":
                    Intro();
                    break;

                 case "2":
                    Calc();
                    break;

                case "3":
                    Exit();
                    break;
                }
;
            
 

            MainMenu();
        }
        static void Intro()
        {
            Console.WriteLine("Please be patient, God isn't finished with me yet. I am a work in progress.");
            Console.ReadLine();
        }
        static void Calc()
        {
            Console.WriteLine("PLease type in your age: ");
            int val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Did you say that your age is:  {0} ", val1);
            Console.WriteLine("Congrats! You are {0} years away from retirement (65)!!!", 65 - val1);


            
            Console.ReadLine();
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
