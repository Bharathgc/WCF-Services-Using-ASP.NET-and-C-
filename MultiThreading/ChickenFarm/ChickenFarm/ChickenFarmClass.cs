using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static ChickenFarm.Program;

namespace ChickenFarm
{
    class ChickenFarmClass
    {
        //create a new event for PriceCut
        public static event PriceCut pricecut;
        //create an event to inform the reatiler when the order has been completed
        public static event OrderComplete OrderCompleted;
        //variable to limit the number of orders to 10 as mentioned in assignment
        public static int MaxOrders = 10;
        //variable to set the price of the chicken
        public static int ChickenPrice = 200;
        //to keep the count of number of counters
        public static int PriceCounter = 0;
        //getter method for chicken price
        public int GetChickenPrice()
        {
            return ChickenPrice;
        }
        //funtion create retailer id's
        public static int[] GetRetailerIDs()
        {
            int[] RetailerIDS = new int[5]; //5 retailers
            Random rand = new Random();
            for (int i = 0; i < 5; i ++)
            {
                RetailerIDS[i] = rand.Next(5000);
            }
            return RetailerIDS;
        }
        //sending the new prices to retailers
        public static void SendoutNewPrice(int ChangedPrice, int RetailerID )
        {
            if(ChangedPrice < ChickenPrice)
            {
                if(pricecut != null)
                {
                    Console.WriteLine("The Chicken farm has reduced the price of chicken from ${0} to ${1} per chicken!!!!...BUY NOW", ChickenPrice, ChangedPrice);
                    //Emitting the pricecut event
                    pricecut(ChickenPrice, ChangedPrice, RetailerID);
                }
                PriceCounter += 1;
            }
            //Changing the price of the chicken
            ChickenPrice = ChangedPrice;
        }
        //This will initate the functioning of chicken farm
        public void StartChickenFarm()
        {
            Random rand = new Random();
            
            //to keep the count of number of retailer
            int RetailerCounter = 0;
            //Get retailers
            int[] RetailerID = GetRetailerIDs();
            while(PriceCounter < MaxOrders)
            {
                Thread.Sleep(1000);
                //any number between 150 to 249 as original price is set to 200
                int ChangedPrice = rand.Next(150, 250);
                ChickenFarmClass.SendoutNewPrice(ChangedPrice, RetailerID[RetailerCounter]);
                RetailerCounter += 1;
                //as number of order is greater than number of retailers so we rand
                if(RetailerCounter == 5)
                {
                    RetailerCounter = rand.Next(0,5);
                }
            }
           
        }
        public Orders GetOrderObject(String DecodedText)
        {
            String[] OrderDetails = DecodedText.Split(',');
            Orders OrderObject = new Orders();
            OrderObject.SetRetailerID(Int32.Parse(OrderDetails[0]));
            OrderObject.SetCreditCardNumber(Int32.Parse(OrderDetails[1]));
            OrderObject.SetChickenPrice(Int32.Parse(OrderDetails[2]));
            OrderObject.SetTotalAmount(Int32.Parse(OrderDetails[3]));
            return OrderObject;
        }
        public void OrderProcessing()
        {
            Console.WriteLine("Dear Retailer Processing of your order has been started");

            //Get the order from cell buffer
            String OrderString = Program.buffercells.getOneCell();
            //Sending the string to decode
            Orders DecodedOrder = GetOrderObject(EncoderClass.decode(OrderString));
            Console.WriteLine("Hello Retailer {0}! Your order of {2} chickens has been placed, at the rate of ${1} per chicken.", DecodedOrder.getRetailerID(), DecodedOrder.getChickenPrice(), (int)(DecodedOrder.getAmount() / DecodedOrder.getChickenPrice()));
            if (DecodedOrder.getCreditCardNumber() > 5000 && DecodedOrder.getCreditCardNumber() < 7000)
            {
                float Tax = 1.8F * DecodedOrder.getAmount();
                float ShippingCharges = 0.5F * DecodedOrder.getAmount();
                float TotalAmount = DecodedOrder.getAmount() + (int)Tax + (int)ShippingCharges;
                //emit the order complete event
                if (OrderCompleted != null)
                {
                    // OrderComplete(int RetailerID, int NumberOfChickens, int ChickenPrice, int TotalAmount, int Tax, int ShippingCharges);
                    OrderCompleted(DecodedOrder.getRetailerID(), (int)(DecodedOrder.getAmount()/DecodedOrder.getChickenPrice()), DecodedOrder.getChickenPrice(),(int) TotalAmount, (int)Tax, (int)ShippingCharges);
                }
            }
            else
                Console.WriteLine("Dear Retailer, Order Processing failed Due to Invalid card  Details");


        }
        // Event Handler which is to be called once the farm completes the processing of this dealer's order.
        public void OrderCompletedEvent(int RetailerID, int NumberOfChickens, int ChickenPrice, int TotalAmount, int Tax, int ShippingCharges)
        {
            Console.WriteLine("Hello Retailer {0}! Your order of {1} chickens for ${2} inclusive of ${3} Tax and ${4} shipping Charges, at the rate of ${5} per chicken, has been processed", RetailerID, NumberOfChickens, TotalAmount, Tax, ShippingCharges, ChickenPrice);
            Console.WriteLine("Your order has been Shipped\n\n");
        }




    }
}
