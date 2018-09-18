using System;
using System.IO;
using System.Threading;
namespace ChickenFarm
{
    class Program
    {
        //Definig the delegates
        //PriceCut event will inform the retailer about the new decreased price of the chicken to place an order
        public delegate void PriceCut(int OriginalPrice, int ChangedPrice, int RetailerID);
        //Createorder event will create and places an order for chickens 
        public delegate void PlaceOrderEvent();
        //Inform the retailer once order has been processed and completed
        public delegate void OrderComplete(int RetailerID, int NumberOfChickens, int ChickenPrice, int TotalAmount, int Tax, int ShippingCharges);
        //Thread for Chicken Farm
        public static Thread ChickenFarmThread;
        //Thread for Retailers
        public static Thread[] Retailers;
        //Create Buffer Cells to read and write orders
        public static MultiCellBuffer buffercells = new MultiCellBuffer();
        static void Main(string[] args)
        {
            //Create a chicken farm object
            ChickenFarmClass chickenfarm = new ChickenFarmClass();
            //start the chicken farm
            ChickenFarmThread = new Thread(new ThreadStart(chickenfarm.StartChickenFarm));
            ChickenFarmThread.Start();

            //Create a Retailer Object
            Retailer retailer = new Retailer();

            //Attaching the event to its corresponding handlers
            ChickenFarmClass.pricecut += new PriceCut(retailer.priceCutEventHandler);
            Retailer.placeorder += new PlaceOrderEvent(chickenfarm.OrderProcessing);
            ChickenFarmClass.OrderCompleted += new OrderComplete(chickenfarm.OrderCompletedEvent);
            //start the retailers
            Retailers = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                Retailers[i] = new Thread(new ThreadStart(retailer.retailerthread));
                Retailers[i].Start();
            }

            // Hold the main thread until the Farm thread has completed execution.
            ChickenFarmThread.Join();

            Console.WriteLine("Orders Limit Have Been Reached. Chicken farm cannot take anymore orders now");
            Console.WriteLine("Press Y to exit");

            Console.ReadLine();

        }
    }
}