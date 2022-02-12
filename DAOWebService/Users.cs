using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAOWebService
{
    public class Users
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Annee { get; set; }
        public string Resulat { get; set; }
        public string Machine { get; set; }
        public string Ip { get; set; }
        public DateTime Date { get; set; }


        public Users()
        {

        }

        public Users(string nom, int annee)
        {
            Nom = nom;
            Annee = annee;
        }

        public Users(string nom, int annee, string resulat) : this(nom, annee)
        {
            this.Resulat = resulat;
        }

        public Users(string nom, int annee, string resulat, string machine, string ip) : this(nom, annee, resulat)
        {
            this.Machine = machine;
            this.Ip = ip;
        }

        public Users(int id, string nom, int annee, string resulat, string machine, string ip, DateTime date)
        {
            Id = id;
            Nom = nom;
            Annee = annee;
            Resulat = resulat;
            Machine = machine;
            Ip = ip;
            Date = date;
        }
    }
}