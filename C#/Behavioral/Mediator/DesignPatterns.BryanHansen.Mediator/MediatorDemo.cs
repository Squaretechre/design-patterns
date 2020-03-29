using System;

namespace DesignPatterns.BryanHansen.Mediator
{
    public class MediatorDemo
    {
        public static void Main()
        {
            var mediator = new Mediator();

            var bedroomLight = new Light("Bedroom");
            var kitchenLight = new Light("Kitchen");

            mediator.RegisterLight(bedroomLight);
            mediator.RegisterLight(kitchenLight);

            var turnOnAllLightsCommand = new TurnOnAllLightsCommand(mediator);

            turnOnAllLightsCommand.Execute();

            var turnOffAllLightsCommand = new TurnOffAllLightsCommand(mediator);

            turnOffAllLightsCommand.Execute();

            Console.ReadLine();
        }
    }
}