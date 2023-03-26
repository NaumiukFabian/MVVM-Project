using EpuServices;
using ReportB2C.Models.EpuModels;
using ReportB2C.ModelsLocal.SqLite;
using ReportB2C.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace ReportB2C.Tools
{
    public class ApiTools : IApiTools
    {
        public async Task<List<OrzeczenieOutputElement>> GetJudgments(DateTime date)
        {
            
            EpuServiceClient client = new EpuServiceClient();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            if (DateTime.Now.Month == 1)
            {
                year = DateTime.Now.Year - 1;
                month = 10;
            }
            else if (DateTime.Now.Month == 2)
            {
                year = DateTime.Now.Year - 1;
                month = 11;
            }
            else if (DateTime.Now.Month == 3)
            {
                year = DateTime.Now.Year - 1;
                month = 12;
            }
            DateTime data = new DateTime(year, month, DateTime.Now.Day);


            try
            {
                int? iloscStronMarcin = await Task.Run(() => client.MojeOrzeczeniaAsync("70011185", "komandyt", "bf33ca82-381a-4972-940d-d152dbd0bb18",
                                null, 100, date, DateTime.Now, 0, null).Result.iloscStron);
                int? iloscStronLukasz = await Task.Run(() => client.MojeOrzeczeniaAsync("61412583", "komandyt", "83956678-254b-4687-939c-3c3b405f3ba2",
                    null, 100, date, DateTime.Now, 0, null).Result.iloscStron);

                MojeOrzeczeniaOutputData mojeOrzeczeniaVer2OutputData;
                List<OrzeczenieOutputElement> listOfJudgments = new List<OrzeczenieOutputElement>();


                for (int i = 1; i <= iloscStronMarcin; i++)
                {
                    mojeOrzeczeniaVer2OutputData = await Task.Run(() => client.MojeOrzeczeniaAsync("70011185", "komandyt", "bf33ca82-381a-4972-940d-d152dbd0bb18",
                            i, 100, date, DateTime.Now, 0, null));
                    foreach (var x in mojeOrzeczeniaVer2OutputData.listaOrzeczen)
                    {
                        if (x.nazwaDecyzji == "Postanowienie o umorzeniu" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia adresu" ||
                            x.nazwaDecyzji == "Postanowienie o braku podstaw do wydania nakazu i przekazaniu wg własciwości" ||
                            x.nazwaDecyzji == "Zarządzenie o zwrocie pozwu" ||
                            x.nazwaDecyzji == "Zarządzenie inne" ||
                            x.nazwaDecyzji == "Zarządzenie o zwrocie opłaty" ||
                            x.nazwaDecyzji == "Postanowienie o skutecznym wniesieniu sprzeciwu i przekazaniu wg. właściwości" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia adresu" ||
                            x.nazwaDecyzji == "Postanowienie o odrzuceniu pozwu" ||
                            x.nazwaDecyzji == "Postanowienie o nadaniu klauzuli wykonalności" ||
                            x.nazwaDecyzji == "Postanowienie o uchyleniu nakazu" ||
                            x.nazwaDecyzji == "Postanowienie o odrzuceniu sprzeciwu" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia adresu" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia braków" ||
                            x.nazwaDecyzji == "Postanowienie o oddaleniu zażalenia" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia braków środka odwoławczego")
                        {
                            x.idPowoda = 70011185;
                            listOfJudgments.Add(x);
                        }

                    }

                }

                for (int i = 1; i <= iloscStronLukasz; i++)
                {
                    mojeOrzeczeniaVer2OutputData = await Task.Run(() => client.MojeOrzeczeniaAsync("61412583", "komandyt", "83956678-254b-4687-939c-3c3b405f3ba2",
                            i, 100, date, DateTime.Now, 0, null));
                    foreach (var x in mojeOrzeczeniaVer2OutputData.listaOrzeczen)
                    {
                        if (x.nazwaDecyzji == "Postanowienie o umorzeniu" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia adresu" ||
                            x.nazwaDecyzji == "Postanowienie o braku podstaw do wydania nakazu i przekazaniu wg własciwości" ||
                            x.nazwaDecyzji == "Zarządzenie o zwrocie pozwu" ||
                            x.nazwaDecyzji == "Zarządzenie inne" ||
                            x.nazwaDecyzji == "Zarządzenie o zwrocie opłaty" ||
                            x.nazwaDecyzji == "Postanowienie o skutecznym wniesieniu sprzeciwu i przekazaniu wg. właściwości" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia adresu" ||
                            x.nazwaDecyzji == "Postanowienie o odrzuceniu pozwu" ||
                            x.nazwaDecyzji == "Postanowienie o nadaniu klauzuli wykonalności" ||
                            x.nazwaDecyzji == "Postanowienie o uchyleniu nakazu" ||
                            x.nazwaDecyzji == "Postanowienie o odrzuceniu sprzeciwu" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia adresu" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia braków" ||
                            x.nazwaDecyzji == "Postanowienie o oddaleniu zażalenia" ||
                            x.nazwaDecyzji == "Zarządzenie o wezwaniu do uzupełnienia braków środka odwoławczego")
                        {
                            x.idPowoda = 61412583;
                            listOfJudgments.Add(x);
                        }

                    }

                }


                return listOfJudgments.OrderBy(x => x.dataOrzeczenia).ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public Orzeczenia ConvertXML(Orzeczenia orzeczenieOutputElement)
        {
            using (var reader = new StringReader(orzeczenieOutputElement.XmlDocument))
            {
                OrzeczenieEPU orzeczenie;
                XmlSerializer serializer = new XmlSerializer(typeof(OrzeczenieEPU));
                orzeczenie = (OrzeczenieEPU)serializer.Deserialize(reader);
                string connectrOrzeczenie = orzeczenie.NazwaOrzeczenia
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.SadEPU.Nazwa
                    + orzeczenie.SadEPU.Wydzial
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.Sedzia
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.NaPosiedzeniu
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.Przez
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.ListaPowodow.Powod.Nazwa
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.NakazujeAby
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.ListaPozwanych.Pozwany.Nazwa
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.Postanawia
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.Tresc
                    + Environment.NewLine
                    + Environment.NewLine
                    + orzeczenie.Uzasadnienie;

                orzeczenieOutputElement.XmlDocumnetCon = connectrOrzeczenie;

                return orzeczenieOutputElement;
            }

        }
    }
}
