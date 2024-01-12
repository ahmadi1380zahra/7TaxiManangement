using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManangeent
{
   static class TaxiManangement
    {
        private static int _id = 0;
        private static List<Taxi> _taxis = new();
        private static List<User> _users = new();
        private static List<TaxiService> _services = new();
        public static void AddTaxi(int type,string name,int price)
        {
            if (type == 1)
            {
                var normalTaxi = new NormalTaxi(name,price);
                _taxis.Add(normalTaxi);
            }
            if (type == 2)
            {
                var vipTaxi = new VipTaxi(name, price);
                _taxis.Add(vipTaxi);
            }
        }
        public static void AddUser(string name)
        {
            var user = new User(name);
            if (_users.Any(item => item.Name == name))
            {
                throw new Exception("name should be unique");
            }
            _users.Add(user);
        }
        public static void AddUserService(string userName,string startPlace,string destination,int distanceKM)
        {
            var user = _users.Find(item => item.Name == userName);
            if (user==null)
            {
                throw new Exception("user not find");
            }
            var service = new TaxiService(++_id,user.Name,startPlace,destination,distanceKM);
            _services.Add(service);
        }
      public static void SetTaxiToUserService(int serviceId,string taxiName)
        {
            var taxi = _taxis.Find(item=>item.Name==taxiName);
            if(taxi is null)
            {
                throw new Exception("taxi not found");
            }
            var service = _services.Find(item=>item.Id==serviceId);
            if (service is null)
            {
                throw new Exception("service not found");
            }
            taxi.SetUserServiceToTaxi(service);

        }
    }
}
