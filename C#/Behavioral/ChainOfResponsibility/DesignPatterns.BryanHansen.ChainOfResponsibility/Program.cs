using System;

namespace DesignPatterns.BryanHansen.ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            Director bryan = new Director();
            VP crystal = new VP();
            CEO jeff = new CEO();

            bryan.SetSuccessor(crystal);
            crystal.SetSuccessor(jeff);

            Request conferenceRequest = Request.ForConferenceCosting(500);
            bryan.HandleRequest(conferenceRequest);
            PrintSpacer();

            Request smallPurchaseRequest = Request.ForPurchaseCosting(1000);
            bryan.HandleRequest(smallPurchaseRequest);
            PrintSpacer();

            Request largePurchaseRequest = Request.ForPurchaseCosting(2000);
            bryan.HandleRequest(largePurchaseRequest);
            PrintSpacer();

            Console.Read();
        }

        private static void PrintSpacer()
        {
            Console.WriteLine("\n------------------------------------------------\n");
        }
    }
}
