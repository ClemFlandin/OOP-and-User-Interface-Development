﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_15_Heritage_TP4
{
    public class SalaireSalarieException : SalarieException
    {
        public SalaireSalarieException(Salarie sal) : base(sal.ToString())
        {

        }
        /// <summary>
        /// Retourne un message d'errreur si le salaire du salarié est négatif
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Le salaire du salarié n'est pas valide";
        }
    }
}
