using MyWallet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Util
{
    public static class CardData
    {
        public static List<Card> Cards = new List<Card>
        {
            new Card {
                CardHolderName = "Luis Fregarrar",
                CardNo = 1212545487874747,
                CardServiceProvider = "Visa",
                CardSpendLimit = 50141,
                CardType = "Debit",
                IsActive = true,
                IsPremium = true
            },
            new Card {
                CardHolderName = "Samantha Tomlinsion",
                CardNo = 1217874785874747,
                CardServiceProvider = "RuPay",
                CardSpendLimit = 501414,
                CardType = "Credit",
                IsActive = true,
                IsPremium = true
            },
            new Card {
                CardHolderName = "Roger Fred",
                CardNo = 1217874987878747,
                CardServiceProvider = "MasterCard",
                CardSpendLimit = 78714,
                CardType = "Debit",
                IsActive = false,
                IsPremium = false
            }
        };
    }
}
