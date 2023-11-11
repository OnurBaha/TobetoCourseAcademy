using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Card
    {
        public int Id;
        public string CardName;
        public string CardNumber;
        public string ExpireYear;
        public string ExpireMonth;
        public string Cvc;

        public Card(int id, string cardName, string cardNumber, string expireYear, string expireMonth, string cvc)
        {
            Id = id;
            CardName = cardName;
            CardNumber = cardNumber;
            ExpireYear = expireYear;
            ExpireMonth = expireMonth;
            Cvc = cvc;
        }

    }
}