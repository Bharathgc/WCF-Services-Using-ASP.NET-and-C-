using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenFarm
{
    class Orders
    {
        private int RetailerID;
        private long CreditCardNumber;
        private int TotalAmount;
        private int ChickenPrice;

        // Getter Method for RetailerID
        public int getRetailerID()
        {
            return RetailerID;
        }
        //Getter Method for CreditCardNumber
        public long getCreditCardNumber()
        {
            return CreditCardNumber;
        }
        //Getter Method for GetAmount
        public int getAmount()
        {
            return TotalAmount;
        }
        //Getter Amount for GetChickenPrice
        public int getChickenPrice()
        {
            return ChickenPrice;
        }

        //Setter Amount for RetailerID
        public void SetRetailerID(int RetailerID1)
        {
            RetailerID = RetailerID1;
        }
        //Setter Method for CreditCardNumber
        public void SetCreditCardNumber(Int32 CreditCardNumber1)
        {
            CreditCardNumber = CreditCardNumber1;
        }
        //Setter Method for TotalAmount
        public void SetTotalAmount(int Amount)
        {
            TotalAmount = Amount;
        }
        //Setter Method for ChickenPrice
        public void SetChickenPrice(int Price)
        {
            ChickenPrice = Price;
        }
    }
}
