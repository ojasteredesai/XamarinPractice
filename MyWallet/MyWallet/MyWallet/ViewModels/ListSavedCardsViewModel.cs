using MyWallet.Model;
using MyWallet.WalletInterfaces;
using MyWallet.WalletServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.ViewModels
{
    public class ListSavedCardsViewModel
    {
        #region Private Members
        private long cardNo = 1111222233334444;
        private string cardType = "Debit";
        private string cardServiceProvider = "MasterCard";
        private string cardHolderName = "Galzaro Lazzaro";
        private bool isActive = true;
        private bool isPremium = false;
        private string cardValidity;
        private double cardSpendLimit = 45000;
        private bool isExecuting = false;
        private List<Card> cards;
        #endregion

        #region Constructor
        public ListSavedCardsViewModel()
        {
            ICardManager cardManager = new CardManager();
            Cards = cardManager.GetCards();
        }
        #endregion

        #region Public Properties
        public long CardNo
        {
            get
            {
                return cardNo;
            }
            set
            {
                cardNo = value;
            }
        }

        public string CardType
        {
            get
            {
                return cardType;
            }
            set
            {
                cardType = value;
            }
        }

        public string CardServiceProvider
        {
            get
            {
                return cardServiceProvider;
            }
            set
            {
                cardServiceProvider = value;
            }
        }

        public string CardHolderName
        {
            get
            {
                return cardHolderName;
            }
            set
            {
                cardHolderName = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }

        public bool IsPremium
        {
            get
            {
                return isPremium;
            }
            set
            {
                isPremium = value;
            }
        }

        public bool IsExecuting
        {
            get
            {
                return isExecuting;
            }
            set
            {
                isExecuting = value;
            }
        }
        public string CardValidity
        {
            get
            {
                return cardValidity;
            }
            set
            {
                cardValidity = value;
            }
        }

        public double CardSpendLimit
        {
            get
            {
                return cardSpendLimit;
            }
            set
            {
                cardSpendLimit = value;
            }
        }

        public List<Card> Cards
        {
            get
            {
                return cards;
            }
            set
            {
                cards = value;
            }
        }

        public string DisplayMessage
        {
            get
            {
                return string.Format("{0} - You have added a new {1} card. Card is {2} and having Spend Limit {3}.", CardHolderName, CardType, IsActive ? "Active" : "Not Active", CardSpendLimit);
            }
        }
        #endregion
    }
}
