namespace DesignPatterns.HeadFirst.Adapter
{
    public class TurkeyAdapter : Duck
    {
        private readonly Turkey _turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            _turkey.Fly();
        }

        public void Quack()
        {
            for (var i = 0; i < 5; i++)
            {
                _turkey.Gobble();
            }
        }
    }
}
