using System;

namespace DesignPatterns.BryanHansen.Mediator
{
    public class Light
    {
        private bool _isOn;
        private readonly string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            _isOn = true;
            Console.WriteLine($"{_location} light switched on.");
        }

        public void Off()
        {
            _isOn = false;
            Console.WriteLine($"{_location} light switched off.");
        }

        public void Toggle()
        {
            if (_isOn)
            {
                Off();
            }
            else
            {
                On();
            }
        }
    }
}