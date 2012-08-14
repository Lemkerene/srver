using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace srv
{
    public enum Blatt
    {
        E_EINER,
        E_ZWEIER,
        E_DREIER,
        E_VIERER,
        E_FUENFER,
        E_SECHSER,
        E_DREIERPASCH,
        E_VIERERPASCH,
        E_FULLHOUSE,
        E_GROSTRASSE,
        E_KLEINESTRASSE,
        E_KNIFFEL,
        E_CHANCE
    }
    public class Eintrag
    {
        private bool eingetragen = false;
        private int wert = -1;
        public Eintrag(){}
        public void setZahl(int zahl)
        {
            wert = zahl;
            eingetragen = true;
        }
        public int GetWert()
        {
            return wert;
        }
        public bool ein()
        {
            return eingetragen;
        }
    }
    class spieler
    {
        private String m_name;
        private int Spielernummer;
        //Oben
        private Eintrag einer = new Eintrag();
        private Eintrag zweier = new Eintrag();
        private Eintrag dreier = new Eintrag();
        private Eintrag vierer = new Eintrag();
        private Eintrag fuenfer = new Eintrag();
        private Eintrag sechser = new Eintrag();
        //unten
        private Eintrag Dreierpasch = new Eintrag();
        private Eintrag ViererPasch = new Eintrag();
        private Eintrag fullhouse = new Eintrag();
        private Eintrag kleinestrasse = new Eintrag();
        private Eintrag Grossestrasse = new Eintrag();
        private Eintrag Kniffel = new Eintrag();
        private Eintrag Chance = new Eintrag();
        //gesamt
        
        

        public spieler(String name,int spnummer)
        {
            m_name = name;
            Spielernummer = spnummer;
        }
        public int GetGesamtOben()
        {
            int ret = 0;
            try
            {
                ret += einer.GetWert();
                ret += zweier.GetWert();
                ret += dreier.GetWert();
                ret += vierer.GetWert();
                ret += fuenfer.GetWert();
                ret += sechser.GetWert();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return ret;
        }
        public int GetGesamtUnten()
        {
            int ret = 0;
            try
            {
                ret += Dreierpasch.GetWert();
                ret += ViererPasch.GetWert();
                ret += fullhouse.GetWert();
                ret += kleinestrasse.GetWert();
                ret += Grossestrasse.GetWert();
                ret += Kniffel.GetWert();
                ret += Chance.GetWert();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return ret;
        }
        public int GetGesamt()
        {
            int ret = 0;
            ret += GetGesamtOben();
            if (ret >= 63)
            {
                ret += 35;
            }
            ret += GetGesamtUnten();
            return ret;

        }

        public bool Getblatt(Blatt welcher)
        {

            switch (welcher)
            {
                case srv.Blatt.E_EINER:
                    return einer.ein();
                case srv.Blatt.E_ZWEIER:
                    return zweier.ein();
                case srv.Blatt.E_DREIER:
                    return dreier.ein();
                case srv.Blatt.E_VIERER:
                    return vierer.ein();
                case srv.Blatt.E_FUENFER:
                    return fuenfer.ein();
                case srv.Blatt.E_SECHSER:
                    return sechser.ein();
                case srv.Blatt.E_DREIERPASCH:
                    return Dreierpasch.ein();
                case srv.Blatt.E_VIERERPASCH:
                    return ViererPasch.ein();
                case srv.Blatt.E_FULLHOUSE:
                    return fullhouse.ein();
                case srv.Blatt.E_GROSTRASSE:
                    return Grossestrasse.ein();
                case srv.Blatt.E_KLEINESTRASSE:
                    return kleinestrasse.ein();
                case srv.Blatt.E_KNIFFEL:
                    return Kniffel.ein();
                case srv.Blatt.E_CHANCE:
                    return Chance.ein();
            }
            return false;
        }
        public int GetblattWerte(Blatt welcher)
        {

            switch (welcher)
            {
                case srv.Blatt.E_EINER:
                    return einer.GetWert();
                case srv.Blatt.E_ZWEIER:
                    return zweier.GetWert();
                case srv.Blatt.E_DREIER:
                    return dreier.GetWert();
                case srv.Blatt.E_VIERER:
                    return vierer.GetWert();
                case srv.Blatt.E_FUENFER:
                    return fuenfer.GetWert();
                case srv.Blatt.E_SECHSER:
                    return sechser.GetWert();
                case srv.Blatt.E_DREIERPASCH:
                    return Dreierpasch.GetWert();
                case srv.Blatt.E_VIERERPASCH:
                    return ViererPasch.GetWert();
                case srv.Blatt.E_FULLHOUSE:
                    return fullhouse.GetWert();
                case srv.Blatt.E_GROSTRASSE:
                    return Grossestrasse.GetWert();
                case srv.Blatt.E_KLEINESTRASSE:
                    return kleinestrasse.GetWert();
                case srv.Blatt.E_KNIFFEL:
                    return Kniffel.GetWert();
                case srv.Blatt.E_CHANCE:
                    return Chance.GetWert();
            }
            return 0;
        }
        public void SetNummeric(int Zahl, Blatt welcher)
        {
            switch (welcher)
            {
                case srv.Blatt.E_EINER:
                    einer.setZahl(Zahl);
                    break;
                case srv.Blatt.E_ZWEIER:
                    zweier.setZahl(Zahl);
                    break;
                case srv.Blatt.E_DREIER:
                    dreier.setZahl(Zahl);
                    break;
                case srv.Blatt.E_VIERER:
                    vierer.setZahl(Zahl);
                    break;
                case srv.Blatt.E_FUENFER:
                    fuenfer.setZahl(Zahl);
                    break;
                case srv.Blatt.E_SECHSER:
                    sechser.setZahl(Zahl);
                    break;
                case srv.Blatt.E_DREIERPASCH:
                    Dreierpasch.setZahl(Zahl);
                    break;
                case srv.Blatt.E_VIERERPASCH:
                    ViererPasch.setZahl(Zahl);
                    break;
                case srv.Blatt.E_FULLHOUSE:
                    fullhouse.setZahl(25);
                    break;
                case srv.Blatt.E_GROSTRASSE:
                    Grossestrasse.setZahl(40);
                    break;
                case srv.Blatt.E_KLEINESTRASSE:
                    kleinestrasse.setZahl(30);
                    break;
                case srv.Blatt.E_KNIFFEL:
                    Kniffel.setZahl(50);
                    break;
                case srv.Blatt.E_CHANCE:
                    Chance.setZahl(Zahl);
                    break;
            }
        }
    }
}
