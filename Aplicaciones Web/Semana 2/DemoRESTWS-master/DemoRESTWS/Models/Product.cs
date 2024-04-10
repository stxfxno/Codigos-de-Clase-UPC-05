using Microsoft.AspNetCore.Routing.Constraints;

namespace DemoRESTWS.Models
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; } 
        public float RegularPrice { get; }
        public float? OfferPrice { get;  }
        public DateTime? OfferDueDate {  get; }
        public int Stock { get; }


        public Product(int _Id, string _Name, string _Description, float _RegularPrice, float? _OfferPrice, DateTime? _OfferDueDate, int _Stock)
        {
            Id = _Id;
            Name = _Name;
            Description = _Description;
            RegularPrice = _RegularPrice;
            OfferPrice = _OfferPrice;
            OfferDueDate = _OfferDueDate;
            Stock = _Stock;
        }

        public float GetPrice(DateTime? today)
        {
            today = (today == null ? DateTime.Now : today);
            float price = RegularPrice;

            if (OfferDueDate != null)
            {
                if (OfferDueDate >= today)
                {
                    price = OfferPrice.GetValueOrDefault(price);
                }
            }

            return price;
        }
    }
}
