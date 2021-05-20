using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.Models;

namespace Logica
{
    public interface IAdresBeheerder
    {
        //moet gelinkt worden aan CRUD?
        bool BestaatAdres(Adres adres);
        bool BestaatGemeente(Gemeente gemeente);
        bool BestaatStraatnaam(string straatnaam, Gemeente gemeente);
        Adres SelecteerAdres(int id);
        List<Adres> SelecteerAdressenInGemeente(int NIScode);
        List<Adres> SelecteerAdressenInStraat(int straatID);
        Gemeente SelecteerGemeente(int NIScode);
        IList<Gemeente> SelecteerGemeenten();
        Straat SelecteerStraat(int id);
        List<Straat> SelecteerStratenInGemeente(int NIScode);
        List<Straat> SelecteerStratenInGemeente(string gemeentenaam);
        void UpdateAdres(Adres adres);
        void UpdateGemeente(Gemeente gemeente);
        void UpdateStraat(Straat straat);
        void VerwijderAdres(int id);
        void VerwijderGemeente(int NIScode);
        void VerwijderStraat(int id);
        void VoegAdresToe(Adres adres);
        void VoegGemeenteToe(Gemeente gemeente);
        void VoegStraatToe(Straat straat);
    }
}
