﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTest
{
    public class Oeuvre
    {
        /// <summary>
        /// Variables privées titre et nom auteur
        /// </summary>
        private string _strTitre;
        private string _strAuteur;
        /// <summary>
        /// Accesseurs
        /// </summary>
        public string StrTitre
        {
            get
            {
                return this._strTitre;
            }
            set
            {
                this._strTitre = value;
            }
        }
        public string StrAuteur
        {
            get
            {
                return this._strAuteur;
            }
            set
            {
                this._strAuteur = value;
            }
        }
        /// <summary>
        /// Constructeur pour nouvelle oeuvre à partir du titre et du nom d'auteur
        /// </summary>
        /// <param name="strTitre"></param>
        /// <param name="strAuteur"></param>
        public Oeuvre(string strTitre, string strAuteur)
        {
            Console.Write("Nouvelle oeuvre créée par {0} : ", strAuteur);
            Console.WriteLine(strTitre);
        }

        public Oeuvre()
        {

        }
    }
}
