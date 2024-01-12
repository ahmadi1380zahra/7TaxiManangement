using System;

namespace TaxiManangeent
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    run();

                }
                catch (Exception excepton)
                {
                    Console.WriteLine(excepton.Message);
                }
            }
            static void run()
            {
                Console.WriteLine("1:add taxi \n" +
                    "2:add user \n" +
                    "3:add userService \n" +
                    "4:add userService to taxi");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            var type = GetInt("type 1:normal 2.vip");
                            if (type != 1 && type != 2)
                            {
                                throw new Exception("not valid type");
                            }
                            var taxiName = GetString("taxi name?");
                            var taxiPrice = GetInt("taxi price?");
                            TaxiManangement.AddTaxi(type,taxiName,taxiPrice);
                            break;
                        }
                    case 2:
                        {
                            var userName = GetString("user name?");
                            TaxiManangement.AddUser(userName);
                            break;
                        }
                    case 3:
                        {
                            var userName = GetString("user name?");
                            var userFirstPlace = GetString("user current location?");
                            var userDestination= GetString("user destination?");
                            var distanceKM = GetInt("how many km is from user place to destination");
                            TaxiManangement.AddUserService(userName, userFirstPlace, userDestination,distanceKM);
                            break;
                        }
                    case 4:
                        {
                            var serviceId = GetInt("user service id");
                            var taxiName = GetString("taxi name?");
                            TaxiManangement.SetTaxiToUserService(serviceId,taxiName);
                            break;
                        }

                }
            }
        }
        static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine()!;
            return value;
        }

        static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine()!);
            return value;
        }
    }

}
