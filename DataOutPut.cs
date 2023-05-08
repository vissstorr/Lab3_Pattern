using Lab3_Pattern.CreatorRequest;
using Lab3_Pattern.Enums;
using Lab3_Pattern.Interface;
using System;

namespace Lab3_Pattern
{
    class DataOutPut:IDataOutPut
    {
        private ServerBalancer _serverBalancer;
        private CreatorRequests _requestCreator;
        private GetServer _getServer;
        
        public DataOutPut(ServerBalancer serverBalancer)
        {
            _serverBalancer = serverBalancer;
        }
        public void RequestProcessed()
        {
            Console.WriteLine("Який тип запиту ви бажаєте відправити?");
            Console.WriteLine("\t 1)File ");
            Console.WriteLine("\t 2)Sql ");
            Console.WriteLine("\t 3)Web ");
            int choice;
            string value = Console.ReadLine();
            while (true)
            {
                choice = Cheaking.ChekingValue(value);
                if (choice > 3 || choice < 1)
                {
                    Console.WriteLine("Уведіть число в межах від 1 до 3");
                    continue;
                }
                break;
            }
            Console.WriteLine("Введіть сам запит?");
            string text = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    _requestCreator = new CreatorFileRequest();
                    _serverBalancer.AssignRequestToServerType(_requestCreator.CreateProduct(text), ServerType.FileServer);
                    break;
                case 2:
                    _requestCreator = new CreatorSqlRequest();
                    _serverBalancer.AssignRequestToServerType(_requestCreator.CreateProduct(text), ServerType.SqlServer);
                    break;
                case 3:
                    _requestCreator = new CreatorWebRequest();
                    _serverBalancer.AssignRequestToServerType(_requestCreator.CreateProduct(text), ServerType.WebServer);
                    break;
            }  
        }
       
        public void Exit()
        {
            Environment.Exit(0);
        }
        public void ShowServer()
        {
            Console.WriteLine("Який тип серверу бажаєте переглянути?");
            Console.WriteLine("\t 1)File ");
            Console.WriteLine("\t 2)Sql ");
            Console.WriteLine("\t 3)Web ");
            int choice;
            string value = Console.ReadLine();
            while (true)
            {
                choice = Cheaking.ChekingValue(value);
                if (choice > 3 || choice < 1)
                {
                    Console.WriteLine("Уведіть число в межах від 1 до 3");
                    continue;
                }
                break;
            }
            switch (choice)
            {
                case 1:
                    _getServer.GetServerStatus(ServerType.FileServer);
                    break;
                case 2:
                    _getServer.GetServerStatus(ServerType.SqlServer);
                    break;
                case 3:
                    _getServer.GetServerStatus(ServerType.WebServer);
                    break;
                
            }
        }

    }
}
