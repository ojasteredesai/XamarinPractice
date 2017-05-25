using MyWallet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.WalletInterfaces
{
    interface ICardManager
    {
        List<Card> GetCards();
        bool AddCard(Card card);
    }
}
