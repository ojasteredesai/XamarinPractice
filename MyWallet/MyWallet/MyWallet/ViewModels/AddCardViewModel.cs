using MyWallet.Model;
using MyWallet.View;
using MyWallet.WalletInterfaces;
using MyWallet.WalletServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWallet.ViewModels
{
    public class AddCardViewModel : INotifyPropertyChanged
    {
        #region Constructors
        public AddCardViewModel()
        {
            //CardNo = 1111222233334444;
            //CardType = "Debit";
            //CardServiceProvider = "MasterCard";
            //CardHolderName = "Galzaro Lazzaro";
            //IsActive = true;
            //CardSpendLimit = 45000;

            SaveCardCommand = new Command(async () => await SaveCardDetails(), () => !IsExecuting);
            ListCardsCommand = new Command(async () => await ListSavedCards(), () => !IsExecuting);
        }
        #endregion

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
        #endregion

        #region Public Events
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigation Navigation { get; set; }
        #endregion

        #region Public Commands
        public Command SaveCardCommand { get; }
        public Command ListCardsCommand { get; }
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsScrollEnabled));
                SaveCardCommand.ChangeCanExecute();
                ListCardsCommand.ChangeCanExecute();
            }
        }

        public bool IsScrollEnabled
        {
            get
            {
                return !IsExecuting;
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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
                IsPremium = cardSpendLimit > 50000 ? true : false;

                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
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

        #region Public Methods
        async Task SaveCardDetails()
        {
            ICardManager cardManager = new CardManager();
            IsExecuting = true;
            cardManager.AddCard(new Card { CardHolderName = this.CardHolderName, CardNo = this.CardNo, CardServiceProvider = this.CardServiceProvider, CardSpendLimit = this.CardSpendLimit, CardType = this.CardType, CardValidity = this.CardValidity, IsActive = this.IsActive, IsPremium = this.IsPremium });
            await Task.Delay(10000);
            //   await Application.Current.MainPage.DisplayAlert("Save","Card has been added successfully!!","Ok");
            IsExecuting = false;
        }

        async Task ListSavedCards()
        {
            IsExecuting = true;
            await Task.Delay(2000);
            // await Application.Current.MainPage.DisplayAlert("My Cards", "Show the cards!!", "Ok");
            IsExecuting = false;
            await Navigation.PushAsync(new CardListPage());
        }
        #endregion

        #region Private Methods
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
