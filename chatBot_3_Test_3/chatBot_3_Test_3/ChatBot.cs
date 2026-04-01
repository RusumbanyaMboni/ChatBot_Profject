using System;

class ChatBot
{
    public void StartChat()
    {
        DisplayLogo();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter your name: ");
        Console.ResetColor();

        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
            name = "User";

        Console.WriteLine($"\nHello {name}! I'm your Cybersecurity Awareness Bot.");
        Console.WriteLine("Ask me questions about online safety.");
        Console.WriteLine("Type 'exit' to quit.\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please type something.");
                continue;
            }

            if (input.ToLower() == "exit" || input.ToLower() == "goodbye" || input.ToLower() == "good bye")
            {
                Console.WriteLine("Bot: Goodbye! Stay safe online.");
                break;
            }

            string response = ResponseHandler.GetResponse(input,name);
            Console.WriteLine("Bot: " + response);
        }
    }

    public void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("===================================");
        Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
        Console.WriteLine("===================================");

        Console.WriteLine(@"
   _____      _                 ____        _   
  / ____|    | |               |  _ \      | |  
 | |     _ __| |__   ___ _ __  | |_) | ___ | |_ 
 | |    | '__| '_ \ / _ \ '__| |  _ < / _ \| __|
 | |____| |  | |_) |  __/ |    | |_) | (_) | |_ 
  \_____|_|  |_.__/ \___|_|    |____/ \___/ \__|

");

        Console.ResetColor();
    }
}