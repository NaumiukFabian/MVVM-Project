using Accessibility;
using EpuServices;
using Microsoft.Identity.Client;
using Microsoft.Win32;
using ReportB2C.Models.EpuModels;
using ReportB2C.ModelsLocal;
using ReportB2C.ModelsLocal.SqLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace ReportB2C.Tools
{
    public class MailTools : IMailTools
    {
        private ISmptClientAccess _smptClientRaport;
        public MailTools(ISmptClientAccess smptClientRaport)
        {
            _smptClientRaport = smptClientRaport;
        }

        public string SetMailReportDay(ObservableCollection<DebtCollector> debtCollectors, MonthPaymentsCompany allPayments, DayPayments dayPaymentsToMail)
        {

            string messageBody = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'><br>";
            foreach (var dc in debtCollectors)
            {
                string cesjaPayUs = String.Format("{0:C}", dc.CesjaPayments);
                string zlecPayUs = String.Format("{0:C}", dc.ZleceniaPayments);
                string cyberPayUs = String.Format("{0:C}", dc.CyberPayments);
                string totPayUs = String.Format("{0:C}", dc.TotalPayments);

                messageBody = messageBody + dc.Name
                + ":<br> Wpłaty-cesja: "
                + cesjaPayUs
                + "<br> Wpłaty-zlecenie: "
                + zlecPayUs
                + "<br> Wpłaty-cyber: "
                + cyberPayUs
                + "<br> Wpłaty-Suma: "
                + totPayUs
                + "<br><br>";
            }

            string cesjaPay = String.Format("{0:C}", allPayments.CesjaPayments);
            string zlecPay = String.Format("{0:C}", allPayments.ZlecPayments);
            string cyberPay = String.Format("{0:C}", allPayments.CyberPayments);
            string przelewyPay = String.Format("{0:C}", allPayments.Przelewy24Payments);
            string selfPay = String.Format("{0:C}", allPayments.SelfPayments);
            string actualltyPay = String.Format("{0:C}", allPayments.ActuallyDeliveryPayments);
            string totalPay = String.Format("{0:C}", allPayments.TotalPayments);
            string dayPayCesja = String.Format("{0:C}", dayPaymentsToMail.CesjaPay);
            string dayPayZlec = String.Format("{0:C}", dayPaymentsToMail.ZlecPay);
            string dayPayCyber = String.Format("{0:C}", dayPaymentsToMail.CyberTotalPay);

            messageBody = messageBody
                + "Wpłaty suma - CESJA: "
                + cesjaPay
                + "<br>Wpłaty suma - ZLECENIA: "
                + zlecPay
                + "<br>Wpłaty suma - CYBERWINDYKACJE: "
                + cyberPay
                + "<br>Wpłaty suma - PRZELEWY24: "
                + przelewyPay
                + "<br>Wpłaty suma - SAMOSPŁACALNOŚĆ: "
                + selfPay
                + "<br>Wpłaty suma - AKTUALNA WYSYŁKA: "
                + actualltyPay
                + "<br>Wpłaty suma - CAŁOŚĆ: "
                + totalPay
                + "<br><br>"
                + "Wpłaty za dzień - " + dayPaymentsToMail.DayPaid.ToString()
                + "<br>CESJA: "
                + dayPayCesja
                + "<br>ZLECENIA: "
                + dayPayZlec
                + "<br>CYBERWINDYKACJE: "
                + dayPayCyber
                + "<br>"
                + "<br>";



            return messageBody;
        }

        public void SendMailDay(string messageBody)
        {
            _smptClientRaport.SetClientRaport(messageBody, "RAPORT SPŁYWÓW ", DateTime.Now.ToString());
        }

        public string EmailDeliveryReport(ObservableCollection<DeliveryInfo> deliveryInfoVMs, string data)
        {
            string messageBody = "";

            foreach (var x in deliveryInfoVMs)
            {
                string interest = String.Format("{0:C}", x.Interest);
                string cost = String.Format("{0:C}", x.Cost);
                string due = String.Format("{0:C}", x.Due);
                string allCost = String.Format("{0:C}", x.AllCost);
                string quantity = x.Quantity.ToString();

                messageBody = messageBody + "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'><br>"
                    + x.Client.ToUpper()
                    + "<br>Ilość wezwań: " + quantity
                    + "<br>Odsetki: " + interest
                    + "<br>Koszty: " + cost
                    + "<br>Należność główna: " + due
                    + "<br>WPS + Odsetki + Koszta: " + allCost
                    + "<br><br>";
            }

            return messageBody;
        }

        public void SendDeliveryRaport(string messageBody, string data)
        {
            _smptClientRaport.SetClientRaport(messageBody, "RAPORT SPŁYWÓW ", data);
        }

        public string[] LoadFiles()
        {
            string[] filesNamePath = Directory.GetFiles(@"Templates\EpuMails");
            List<string> filesName = new List<string>();

            foreach (var x in filesNamePath)
            {
                filesName.Add(Path.GetFileName(x).Replace(".html", ""));
            }

            return filesName.ToArray();
        }

        public string LoadBodyMessageEpu(string tempName, Orzeczenia selectedItem, DateTime selectedData)
        {

            using (var reader = new StringReader(selectedItem.XmlDocument))
            {
                OrzeczenieEPU orzeczenie;
                XmlSerializer serializer = new XmlSerializer(typeof(OrzeczenieEPU));
                orzeczenie = (OrzeczenieEPU)serializer.Deserialize(reader);

                var part = orzeczenie.ListaPozwanych.Pozwany.Nazwa.Split(' ');
                var firstLetter = part[0].Substring(0, 1);
                string pozwany = part[1].ToUpper() + " " + firstLetter.ToUpper() + ".";

                var placeholders = new List<(string placeholder, string value)>()
                {
                    ("pozwany", pozwany),
                    ("oplata", selectedItem.SygnaturaWgPowoda),
                    ("dataOdpowiedzi", selectedData.ToString().Replace("00:00:00","")),
                };

                if (tempName == "ZTM Rzeszów - Wezwanie o adres" || tempName == "MZK Opole - Wezwanie o adres")
                {
                    var orzeczenieParts = orzeczenie.Tresc.Split(new string[] { "bowiem" }, StringSplitOptions.None);
                    var orzeczenieParts0 = orzeczenieParts[1].Split(new string[] { "\n\n" }, StringSplitOptions.None);

                    placeholders = new List<(string placeholder, string value)>()
                {
                    ("pozwany", pozwany),
                    ("oplata", selectedItem.SygnaturaWgPowoda),
                    ("orzeczenieParts0[0]", orzeczenieParts0[0]),
                    ("dataOdpowiedzi", selectedData.ToString().Replace("00:00:00","")),
                };
                }

                if (String.IsNullOrEmpty(tempName))
                {
                    MessageBox.Show("Nie wybrano szablonu!", "Brak szablonu", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return null;
                }

                string html = File.ReadAllText(@$"Templates\EpuMails\{tempName}.html");

                foreach (var placeholder in placeholders)
                    html = html.Replace($"{{{placeholder.placeholder}}}", placeholder.value);

                return html;

            }


        }

        public string[] SetSender(string selectedItem, Orzeczenia selected)
        {
            using (var reader = new StringReader(selected.XmlDocument))
            {
                OrzeczenieEPU orzeczenie;
                XmlSerializer serializer = new XmlSerializer(typeof(OrzeczenieEPU));
                orzeczenie = (OrzeczenieEPU)serializer.Deserialize(reader);
                string[] name = orzeczenie.ListaPozwanych.Pozwany.Nazwa.Split(" ");

                string[] recipient = new string[4];

                if (selectedItem == "ZTM Rzeszów - Wezwanie o adres" || selectedItem == "ZTM Rzeszów - Umorzenie postępowania (sprzeciw)" || selectedItem == "ZTM Rzeszów - Umorzenie postępowania")
                {
                    recipient[0] = "";
                    recipient[1] = "";
                    recipient[2] = "";
                    recipient[3] = $"EPU " + name[1].ToUpper() + ' ' + name[0].Substring(0, 1).ToUpper() + '.';
                }
                else if (selectedItem == "MZK Opole - Wezwanie o adres" || selectedItem == "MZK Opole - Umorzenie postępowania (sprzeciw)" || selectedItem == "MZK Opole - Umorzenie postępowania")
                {
                    recipient[0] = "";
                    recipient[1] = "";
                    recipient[2] = "";
                    recipient[3] = $"EPU " + name[1].ToUpper() + ' ' + name[0].Substring(0, 1).ToUpper() + '.';
                }
                else if(selectedItem == "MZK Ostrów - Umorzenie postępowania (sprzeciw)" || selectedItem == "MZK Ostrów - Umorzenie postępowania" || selectedItem == "MZK Ostrów - Wezwanie o adres")
                {
                    recipient[0] = "";
                    recipient[1] = "";
                    recipient[2] = "";
                    recipient[3] = $"EPU " + name[1].ToUpper() + ' ' + name[0].Substring(0, 1).ToUpper() + '.';
                }

                return recipient;

            }
        }

        public string AddAttachment()
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                _smptClientRaport.Attachment(openFileDialog.FileName, System.IO.Path.GetFileName(openFileDialog.FileName));
            }

            return openFileDialog.FileName;
        }

        public void SendEpu(string messageBody, string subject, string copy, string path, string to)
        {
            _smptClientRaport.SetClientEpu(messageBody, subject, copy, path, to);
        }
    }
}
