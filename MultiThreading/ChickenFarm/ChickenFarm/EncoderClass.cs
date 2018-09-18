using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenFarm
{
    class EncoderClass
    {
        public static String Encode(Orders order)
        {
            //joining the order details
            String OrdersStringToEncode = order.getRetailerID().ToString() + "," + order.getCreditCardNumber().ToString() +","+ order.getChickenPrice().ToString()+","+order.getAmount().ToString();
            //Encoding
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(OrdersStringToEncode);
            string OrdersEncodedString = System.Convert.ToBase64String(bytes);
            return OrdersEncodedString;
        }
        public static string decode(string text)
        {
            //decoding...
            byte[] bytes = System.Convert.FromBase64String(text);
            string OrdersDecodedString = System.Text.Encoding.UTF8.GetString(bytes);
            return OrdersDecodedString;
        }
    }
}
