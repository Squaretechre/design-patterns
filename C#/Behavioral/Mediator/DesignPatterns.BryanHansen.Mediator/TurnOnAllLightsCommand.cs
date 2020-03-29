namespace DesignPatterns.BryanHansen.Mediator
{
    // concrete command
    public class TurnOnAllLightsCommand : Command
    {
        private readonly Mediator _mediator;

        public TurnOnAllLightsCommand(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void Execute()
        {
            _mediator.TurnOnAllLights();
        }
    }
}