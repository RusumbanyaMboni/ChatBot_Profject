class Program
{
    static void Main()
    {


        VoiceGreeting.PlayGreeting();


        ChatBot bot = new ChatBot();
        bot.StartChat();
    }
}