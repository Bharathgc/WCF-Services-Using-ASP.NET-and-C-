using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static ChickenFarm.Program;

namespace ChickenFarm
{
    class Retailer
    {
        //create a event to create orders
        public static event PlaceOrderEvent placeorder;
        //calculating the number of chickens based on the difference between the prices
        public int GetNumberOfChickensRequired(int ChickenPrice, int ChangedPrice)
        {
            return 100 * Math.Abs(ChickenPrice - ChangedPrice);
        }
        public void retailerthread()
        {
            Random rand = new Random();
            Thread.Sleep(rand.Next(1000, 3000));
            Console.WriteLine("Retailer has been subscribed\n\n\n");
        }

        //function to place orders
        public void PlaceOrder(int NumberOfChickens, int RetailerID, int ChangedPrice)
        {
            lock (this)
            {
                Random rand = new Random();
                // Generate a credit card number.
                Int32 CreditCardNumber = rand.Next(5000, 7000);
                // Creating the pbject for order
                Orders ordersobject = new Orders();
                ordersobject.SetRetailerID(RetailerID);
                ordersobject.SetCreditCardNumber(CreditCardNumber);
                ordersobject.SetChickenPrice(ChangedPrice);
                ordersobject.SetTotalAmount(NumberOfChickens * ChangedPrice);

                // Sending the order object to Encoder
                String OrdersEncodedString = EncoderClass.Encode(ordersobject);
                //Write the order string into multibuffer cell
                Program.buffercells.setOneCell(OrdersEncodedString);
                Console.WriteLine("The order for RetailerID {0} has been placed.....", RetailerID);
                Console.WriteLine("Well will inform you once the order has been processed");
                //emit the place order event
                placeorder();
            }
        }

        // Defining the event handler to pricecut in chicken price
        public void priceCutEventHandler(int ChickenPrice, int ChangedPrice , int RetailerID)
        {
            int NumberOfChickens = GetNumberOfChickensRequired(ChickenPrice, ChangedPrice);
            PlaceOrder(NumberOfChickens, RetailerID, ChangedPrice);
        }
        



    }
}
