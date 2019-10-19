using System;

namespace DesignPatterns.GangOfFour.ChainOfResponsibility
{
    public class Program
    {
        // Client
        static void Main()
        {
            Application application = new Application(Topic.ApplicationTopic);

                                      // Add application as dialog's successor
            Dialog dialog = new Dialog(application, Topic.PrintTopic);

                                      // Add dialog as button's successor
            Button button = new Button(dialog, Topic.PaperOrientationTopic);

            button.HandleHelp();

            Console.Read();
        }
    }
}
