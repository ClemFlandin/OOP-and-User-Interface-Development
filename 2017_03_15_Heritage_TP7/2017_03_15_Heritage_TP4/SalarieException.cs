using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_15_Heritage_TP4
{
    public class SalarieException : Exception
    {
        private string v;

        public SalarieException(string v)
        {
            this.v = v;
        }

        public SalarieException (Salarie sal) : base(sal.ToString())
        {

        }
        /// <summary>
        /// Retourne un message d'erreur si les paramètres du salarié sont incorrects
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Le salarie rentré ne comprend pas des paramètres corrects! ";
        }
    }
}
