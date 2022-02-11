namespace CodeLouisvilleLibrary
{
    public class CodeLouisvilleProjectBase
        {
            public static int Prompt4Integer(string prompt)
            {
                int value;

                do
                {
                    Console.Write(prompt);
                }
                while (!int.TryParse(Console.ReadLine(), out value));

                return value;
            }
            public static bool Prompt4YesNo(string prompt)
            {
                string? userInput = "";

                do
                {
                    Console.Write(prompt);
                    userInput = Console.ReadLine();
                } while (userInput.ToUpper() != "Y" && userInput.ToUpper() != "N");

                return userInput.ToUpper() == "Y";
            }
            public static string Prompt4MenuItem(string prompt, List<KeyValuePair<string, string>> menu)
            {
                Console.WriteLine(prompt);
                // this is the menu
                foreach (KeyValuePair<string, string> menuItem in menu)
                {
                    Console.WriteLine($"\t{menuItem.Key.ToString()}: {menuItem.Value}");
                }
                Console.Write("Selection: ");
                string userSelection = Console.ReadLine();

                foreach (KeyValuePair<string, string> menuitem in menu)
                {
                    if (menuitem.Key.ToUpper() == userSelection.ToUpper())
                        return menuitem.Key;
                }

                return "";
            }
        }
}