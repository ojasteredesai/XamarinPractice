using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Model
{
    public class Card
    {
        #region Private Members
        public long CardNo { get; set; }
        public string CardType { get; set; }
        public string CardServiceProvider { get; set; }
        public string CardHolderName { get; set; }
        public bool IsActive { get; set; }
        public bool IsPremium { get; set; }
        public string CardValidity { get; set; }
        public double CardSpendLimit { get; set; }
        #endregion
    }
}
