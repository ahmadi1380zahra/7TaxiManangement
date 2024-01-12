using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManangeent
{
    
  abstract class Taxi:ITaxiManangement
    {
        protected Taxi(string name, int price)
        {
            Name = name;
          
            Price = price;
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public TaxiService TaxiService { get;private set; }

        public void SetUserServiceToTaxi(TaxiService taxiService)
        {
            TaxiService = taxiService;
            TaxiService.TotalCost = Price * taxiService.DistanceKM;
        }
    }
    class NormalTaxi : Taxi
    {
        public NormalTaxi(string name, int price) : base(name, price)
        {
        }
        
    }
    class VipTaxi : Taxi
    {
        public VipTaxi(string name, int price) : base(name, price)
        {
        }

    }
    class User
    {
        public User(string name)
        {
           
            Name = name;
        }
        
        public string Name { get; set; }

        public void AddTaxiServiceForUser(string taxiName, string taxiType, string startPlace, string destination, int distacne, int totalCost)
        {
           //TaxiService .
        }
    }
    public class TaxiService
    {
        public TaxiService(int id,string userName,string startPlace,
            string destination,int distacne )
        {
            Id = id;
            UserName = userName;
         
            StartPlace = startPlace;
            Destination = destination;
            DistanceKM = distacne;
           
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        
        public string StartPlace { get; set; }
        public string Destination { get; set; }
        public int DistanceKM { get; set; }
        public int TotalCost { get; set; }
    }

}
