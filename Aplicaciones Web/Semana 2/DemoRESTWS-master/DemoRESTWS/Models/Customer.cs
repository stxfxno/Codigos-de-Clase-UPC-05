namespace DemoRESTWS.Models
{
    public class Customer
    {
        public int CustomerId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string DNI { get; }
        public DateOnly BirthDate { get; }

        public Customer(int _CustomerId, string _FirstName, string _LastName, string _DNI, DateOnly BirthDay)
        {
            CustomerId = _CustomerId;
            FirstName = _FirstName;
            LastName = _LastName;
            DNI = _DNI;
            BirthDate = BirthDay;
        }

        public bool IsBirthDate(DateOnly today) {
            return today == BirthDate;
        }
    }
}
