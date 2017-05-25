using MyWallet.WalletInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWallet.Model;
using MyWallet.Util;

namespace MyWallet.WalletServices
{
    public class CardManager : ICardManager
    {
        public bool AddCard(Card card)
        {
            CardData.Cards.Add(card);
            return true;
        }

        public List<Card> GetCards()
        {
            return CardData.Cards;
        }
    }
}
