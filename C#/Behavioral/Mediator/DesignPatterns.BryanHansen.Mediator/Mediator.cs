using System.Collections.Generic;

namespace DesignPatterns.BryanHansen.Mediator
{
    public class Mediator
    {
        private readonly List<Light> _lights = new List<Light>();

        public void RegisterLight(Light light)
        {
            _lights.Add(light);
        }

        public void TurnOnAllLights()
        {
            foreach(var light in _lights)
            {
                light.On();
            }
        }

        public void TurnOffAllLights()
        {
            foreach (var light in _lights)
            {
                light.Off();
            }
        }
    }
}