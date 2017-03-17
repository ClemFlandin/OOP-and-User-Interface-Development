using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public abstract class Commande
    {
        private int nNbreLivresCommandes;

        public int NNbreLivresCommandes
        {
            get
            {
                return this.nNbreLivresCommandes;
            }
            set
            {
                this.nNbreLivresCommandes = value;
            }
        }
        public Commande()
        {
             
        }

    }
}
