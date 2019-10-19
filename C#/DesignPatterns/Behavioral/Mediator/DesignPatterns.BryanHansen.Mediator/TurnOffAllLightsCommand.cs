namespace DesignPatterns.BryanHansen.Mediator
{
    // concrete command
    public class TurnOffAllLightsCommand : Command
    {
        private readonly Mediator _mediator;

        public TurnOffAllLightsCommand(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void Execute()
        {
            _mediator.TurnOffAllLights();
        }
    }
}