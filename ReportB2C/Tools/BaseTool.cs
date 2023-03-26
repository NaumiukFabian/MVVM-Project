using ReportB2C.Models;
using ReportB2C.ModelsLocal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.Tools
{
    public class BaseTool : IBaseTool
    {
        NewB2cContext db;
        IQueryable<Payment>? allDayPayDay;

        public BaseTool(NewB2cContext db)
        {
            this.db = db;
        }

        public DebtCollector[] GetDebtCollectors()
        {

            DebtCollector[] debtCollectorsArray = db.Users.Select(x => new DebtCollector
            {
                Name = x.Name
            }).ToArray();

            return debtCollectorsArray;
        }

        public ObservableCollection<DebtCollector> SelectedCollecotrs(ObservableCollection<DebtCollector> SelectedCollectors)
        {
            var allPayments = db.Payments
                .Distinct()
                .Where(x => x.Date.Value.Month == DateTime.Now.Month && x.Date.Value.Year == DateTime.Now.Year);

            foreach (var x in SelectedCollectors)
            {
                var user = db.Users.FirstOrDefault(y => y.Name == x.Name);
                x.Id = user.Id;

                decimal? cejsaPay = allPayments
                .Where(c => c.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima")
                && !c.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima (PKP InterCity - C"))
                .Where(y => y.Event.Case.LeadingUser.Id == x.Id)
                .Sum(d => d.Amount);

                decimal? zlecPay = allPayments
                .Where(c => !c.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima") && !c.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Cyberwindykacja"))
                .Where(y => y.Event.Case.LeadingUser.Id == x.Id)
                .Sum(d => d.Amount);

                decimal? cyberPay = allPayments
                .Where(c => c.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Cyberwindykacja")
                || c.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima (PKP InterCity - C"))
                .Where(y => y.Event.Case.LeadingUser.Id == x.Id)
                .Sum(d => d.Amount);

                decimal? totalPay = allPayments
                .Where(y => y.Event.Case.LeadingUser.Id == x.Id)
                .Sum(d => d.Amount);

                x.CesjaPayments = cejsaPay;
                x.ZleceniaPayments = zlecPay;
                x.CyberPayments = cyberPay;
                x.TotalPayments = totalPay;
            }

            return SelectedCollectors;
        }

        public MonthPaymentsCompany MonthPaymnets()
        {

            string data = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            var allPayments = db.Payments
                .Distinct()
                .Where(x => x.Date.Value.Month == DateTime.Now.Month && x.Date.Value.Year == DateTime.Now.Year);

            var cesjaPay = allPayments
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima")
                && !x.Event.Case.ContractFiles.Contract.Client.Name.Contains("Statima (PKP InterCity - C"))
                .Distinct();

            var cyberPay = allPayments
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Cyberwindykacja")
                || x.Event.Case.ContractFiles.Contract.Client.Name.Contains("Statima (PKP InterCity - C"))
                .Distinct();

            var zlecPay = allPayments
                .Where(x => !x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Cyberwindykacja") && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima") && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Equals("STANDER CZ") && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Equals("STANDER SK"))
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            var actuallyDeliveryPay = allPayments
                .Where(x => x.Event.Case.Signatures
                .Contains(data))
                .Where(y => y.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima")
                && !y.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima (PKP InterCity - C"))
                .Distinct();

            var przelewy24Pay = allPayments
                .Where(x => x.Event.Text
                .Contains("P24") || x.Event.Text
                .Contains("P 24"))
                .Distinct();

            var selfPay = allPayments
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima")
                && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima (PKP InterCity - C"))
                .Where(y => (y.Event.Case.LeadingUser.Id != 2146
                && y.Event.Case.LeadingUser.Id != 2139
                && y.Event.Case.LeadingUser.Id != 2138
                && y.Event.Case.LeadingUser.Id != 2131
                && y.Event.Case.LeadingUser.Id != 2129
                && y.Event.Case.LeadingUser.Id != 2113
                && y.Event.Case.LeadingUser.Id != 2151
                && y.Event.Case.LeadingUser.Id != 2068)
                || y.Event.Case.LeadingUser.Id == null)
                .Distinct();

            var standerCzPay = allPayments
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                .Equals("STANDER CZ"))
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            var standerSkPay = allPayments
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Id == 2594)
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            var totalPay = allPayments
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Id != 2592 &&
                 x.Event.Case.ContractFiles.Contract.Client.Id != 2594)
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            MonthPaymentsCompany monthPaymentsCompany = new MonthPaymentsCompany()
            {
                TotalPayments = totalPay + (standerCzPay * (decimal)0.19) + (standerSkPay * (decimal)4.68),
                CesjaPayments = cesjaPay.Sum(x => x.Amount) ?? 0,
                CyberPayments = cyberPay.Sum(x => x.Amount) ?? 0,
                ZlecPayments = zlecPay + (standerCzPay * (decimal)0.19) + (standerSkPay * (decimal)4.68),
                ActuallyDeliveryPayments = actuallyDeliveryPay.Sum(x => x.Amount) ?? 0,
                Przelewy24Payments = przelewy24Pay.Sum(x => x.Amount) ?? 0,
                SelfPayments = selfPay.Sum(x => x.Amount) ?? 0
            };

            return monthPaymentsCompany;
        }

        public DayPayments DayPayments(DateTime dayPaid)
        {

            allDayPayDay = db.Payments
                .Distinct()
                .Where(x => x.Date.Value.Day == dayPaid.Day && x.Date.Value.Month == dayPaid.Month && x.Date.Value.Year == dayPaid.Year);

            var cesjaDayPay = allDayPayDay
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima")
                && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima (PKP InterCity - C"))
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            var zlecDayPay = allDayPayDay
                .Where(x => !x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Cyberwindykacja") && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima") && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Equals("STANDER CZ") && !x.Event.Case.ContractFiles.Contract.Client.Name
                .Equals("STANDER SK"))
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            var standerSkDayPay = allDayPayDay
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Id == 2594)
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            var standerCzDayPay = allDayPayDay
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                .Equals("STANDER CZ"))
                .Distinct()
                .Sum(c => c.Amount) ?? 0;

            var cyberDayPay = allDayPayDay
                .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Cyberwindykacja")
                || x.Event.Case.ContractFiles.Contract.Client.Name
                .Contains("Statima (PKP InterCity - C"))
                .Distinct()
                .Sum(c => c.Amount) ?? 0;


            DayPayments dayPayments = new DayPayments()
            {
                CesjaPay = cesjaDayPay,
                ZlecPay = zlecDayPay,
                StanderSkPay = standerSkDayPay,
                StanderCzPay = standerCzDayPay,
                CyberTotalPay = cyberDayPay,
                DayPaid = dayPaid
            };

            return dayPayments;

        }

        public string[] LoadCyber()
        {
            string[] cyberName = db.Clients
                .Where(x => x.Name.Contains("Cyberwindykacja")
                || x.Name.Contains("Statima (PKP InterCity - C"))
                .Select(y => y.Name).ToArray();

            return cyberName;
        }

        public DayPayments cyberDayPaidLoad(string cyberName, DayPayments dayPayments)
        {
            var cyberDayPay = allDayPayDay
                            .Where(x => x.Event.Case.ContractFiles.Contract.Client.Name
                            .Equals(cyberName))
                            .Distinct()
                            .Sum(c => c.Amount) ?? 0;

            dayPayments.CyberPay = cyberDayPay;
            return dayPayments;

        }

        public ObservableCollection<DeliveryInfo> LoadDateFromDelivery(string data)
        {
            string[] arrayOfClients = new string[] { "Statima", "Cyberwindykacja Sp. z o.o.", "Cyberwindykacja I Sp. z o.o.", "Cyberwindykacja II Sp. z o.o.", "Cyberwindykacja III Sp. z o.o." };

            ObservableCollection<DeliveryInfo> deliveryInfoVMs = new ObservableCollection<DeliveryInfo>();
            int InfoDelivery = 0;
            decimal? InterestDelivery = 0;
            decimal? DueDelivery = 0;
            decimal? CostDelivery = 0;
            decimal? AllCostDelivey = 0;


            foreach (string x in arrayOfClients)
            {
                if (x == "Statima")
                {
                    InfoDelivery = db.Cases
                .Where(c => c.ContractFiles.Contract.Client.Name.Contains(x)
                && !c.ContractFiles.Contract.Client.Name.Contains("Statima (PKP InterCity - C"))
                .Where(s => s.Signatures.Contains(data))
                .Count();

                    InterestDelivery = db.Fines
                        .Where(c => c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        && !c.Case.ContractFiles.Contract.Client.Name.Contains("Statima (PKP InterCity - C")
                        && c.Case.Signatures.Contains(data))
                        .Sum(i => i.Interst) ?? 0;

                    DueDelivery = db.Fines
                        .Where(c => c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        && !c.Case.ContractFiles.Contract.Client.Name.Contains("Statima (PKP InterCity - C")
                        && c.Case.Signatures.Contains(data))
                        .Sum(d => d.Ammount) ?? 0;

                    CostDelivery = db.Fines
                        .Where(c => c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        && !c.Case.ContractFiles.Contract.Client.Name.Contains("Statima (PKP InterCity - C")
                        && c.Case.Signatures.Contains(data))
                        .Sum(cs => cs.Koszty) ?? 0;

                    AllCostDelivey = (InterestDelivery + DueDelivery + CostDelivery) ?? 0;
                }
                else if (x == "Cyberwindykacja Sp. z o.o.")
                {
                    InfoDelivery = db.Cases
                .Where(c => (c.ContractFiles.Contract.Client.Name.Contains(x)
                || c.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C)")))
                .Where(s => s.Signatures.Contains(data))
                .Count();

                    InterestDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(i => i.Interst) ?? 0;

                    DueDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(d => d.Ammount) ?? 0;

                    CostDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(cs => cs.Koszty) ?? 0;

                    AllCostDelivey = (InterestDelivery + DueDelivery + CostDelivery) ?? 0;
                }
                else if (x == "Cyberwindykacja I Sp. z o.o.")
                {
                    InfoDelivery = db.Cases
                .Where(c => c.ContractFiles.Contract.Client.Name.Contains(x)
                || c.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C1)"))
                .Where(s => s.Signatures.Contains(data))
                .Count();

                    InterestDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C1)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(i => i.Interst) ?? 0;

                    DueDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C1)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(d => d.Ammount) ?? 0;

                    CostDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C1)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(cs => cs.Koszty) ?? 0;

                    AllCostDelivey = (InterestDelivery + DueDelivery + CostDelivery) ?? 0;
                }
                else if (x == "Cyberwindykacja II Sp. z o.o.")
                {
                    InfoDelivery = db.Cases
                .Where(c => c.ContractFiles.Contract.Client.Name.Contains(x)
                || c.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C2)"))
                .Where(s => s.Signatures.Contains(data))
                .Count();

                    InterestDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C2)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(i => i.Interst) ?? 0;

                    DueDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C2)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(d => d.Ammount) ?? 0;

                    CostDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C2)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(cs => cs.Koszty) ?? 0;

                    AllCostDelivey = (InterestDelivery + DueDelivery + CostDelivery) ?? 0;
                }
                else if (x == "Cyberwindykacja III Sp. z o.o.")
                {
                    InfoDelivery = db.Cases
                .Where(c => c.ContractFiles.Contract.Client.Name.Contains(x)
                || c.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C3)"))
                .Where(s => s.Signatures.Contains(data))
                .Count();

                    InterestDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C3)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(i => i.Interst) ?? 0;

                    DueDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C3)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(d => d.Ammount) ?? 0;

                    CostDelivery = db.Fines
                        .Where(c => (c.Case.ContractFiles.Contract.Client.Name.Contains(x)
                        || c.Case.ContractFiles.Contract.Client.Name.Equals("Statima (PKP InterCity - C3)"))
                        && c.Case.Signatures.Contains(data))
                        .Sum(cs => cs.Koszty) ?? 0;

                    AllCostDelivey = (InterestDelivery + DueDelivery + CostDelivery) ?? 0;
                }

                DeliveryInfo deliveryInfoVM = new DeliveryInfo()
                {
                    Interest = InterestDelivery,
                    Due = DueDelivery,
                    Cost = CostDelivery,
                    AllCost = AllCostDelivey,
                    Quantity = InfoDelivery,
                    Client = x
                };



                deliveryInfoVMs.Add(deliveryInfoVM);

            }

            int zlecInfoDelivery = db.Cases
                .Where(c => !c.ContractFiles.Contract.Client.Name.Contains("Statima") &&
                !c.ContractFiles.Contract.Client.Name.Contains("Cyberwindykacja"))
                .Where(s => s.Signatures.Contains(data))
                .Count();

            decimal? zlecInterestDelivery = db.Fines
                .Where(c => !c.Case.ContractFiles.Contract.Client.Name.Contains("Statima") &&
                !c.Case.ContractFiles.Contract.Client.Name.Contains("Cyberwindykacja") &&
                c.Case.Signatures.Contains(data))
                .Sum(i => i.Interst) ?? 0;

            decimal? zlecDueDelivery = db.Fines
                .Where(c => !c.Case.ContractFiles.Contract.Client.Name.Contains("Statima") &&
                !c.Case.ContractFiles.Contract.Client.Name.Contains("Cyberwindykacja") &&
                c.Case.Signatures.Contains(data))
                .Sum(d => d.Ammount) ?? 0;

            decimal? zlecCostDelivery = db.Fines
                .Where(c => !c.Case.ContractFiles.Contract.Client.Name.Contains("Statima") &&
                !c.Case.ContractFiles.Contract.Client.Name.Contains("Cyberwindykacja") &&
                c.Case.Signatures.Contains(data))
                .Sum(cs => cs.Koszty) ?? 0;

            decimal? zlecAllCostDelivey = (zlecInterestDelivery + zlecDueDelivery + zlecCostDelivery) ?? 0;

            DeliveryInfo zlecDeliveryInfo = new DeliveryInfo()
            {
                Interest = zlecInterestDelivery,
                Due = zlecDueDelivery,
                Cost = zlecCostDelivery,
                AllCost = zlecAllCostDelivey,
                Quantity = zlecInfoDelivery,
                Client = "Zlecenia"
            };

            deliveryInfoVMs.Add(zlecDeliveryInfo);

            return deliveryInfoVMs;

        }

        public string[] SetComboBoxTemplate()
        {
            string[] templates = { "ztm rzeszów - wezwanie o adres", "ztm rzeszów - umorzenie postępowania (sprzeciw)", "mzk opole - wezwanie o adres" };
            return templates;
        }

        public string[] SetComboJudgments()
        {
            string[] typeOfJudgments = { "Zrobione", "Niezrobione", "Zrobione Automatycznie" };
            return typeOfJudgments;
        }
    }
}
