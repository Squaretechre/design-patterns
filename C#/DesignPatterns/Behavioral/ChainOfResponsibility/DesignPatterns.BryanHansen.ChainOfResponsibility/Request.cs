namespace DesignPatterns.BryanHansen.ChainOfResponsibility
{
    public class Request
    {
        public readonly RequestType _type;
        private readonly double _amount;

        public Request(RequestType requestType, double amount)
        {
            _type = requestType;
            _amount = amount;
        }

        public static Request ForConferenceCosting(int amount)
        {
            return new Request(RequestType.Conference, amount);
        }

        internal static Request ForPurchaseCosting(int amount)
        {
            return new Request(RequestType.Purchase, amount);
        }

        public bool IsASmallPurchase()
        {
            return _type == RequestType.Purchase && _amount < 1500;
        }

        public bool IsForAConference()
        {
            return _type == RequestType.Conference;
        }

        public override string ToString()
        {
            return $"Request for: {_type}, costing: £{_amount}";
        }
    }
}
