using ReportB2C.ModelsLocal;
using ReportB2C.Tools;
using ReportB2C.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReportB2C.ViewModels
{
    public class MainWindowVM : ViewModelBase
    {
        private readonly IBaseTool _baseTool;
        private readonly IMailTools _mailTools;
        DebtCollector[]? debtCollectors;

        public MainWindowVM(IBaseTool baseTool, IMailTools mailTools)
        {
            _baseTool = baseTool;
            _mailTools = mailTools;
            DebtCollectorVMs = new ObservableCollection<DebtCollector>();
            SelectedDebtCollectorVMs = new ObservableCollection<DebtCollector>();
            MonthPaymentsCompany = new MonthPaymentsCompany();
            DayPaymentsVM = new DayPayments();
            SearchCommand = new SearchCommand(this);
            ConfirCommand = new ConfirmCommand(this);
            LoadMailCommand = new LoadMailCommand(this);
            SendEmailCommand = new SendEmailCommand(this);
            FiltrCommand = new FiltrCommand(this);
            PaymentsForSelectedDayCommand = new PaymentsForSelectedDayCommand(this);
            PaymentsForSelectedCyberCommand = new PaymentsForSelectedCyberCommand(this);
            _mailTools.LoadFiles();
        }


        public ObservableCollection<DebtCollector>? DebtCollectorVMs { get; set; }
        public ObservableCollection<DebtCollector>? SelectedDebtCollectorVMs { get; set; }
        public SearchCommand SearchCommand { get; set; }
        public ConfirmCommand ConfirCommand { get; set; }
        public LoadMailCommand LoadMailCommand { get; set; }
        public SendEmailCommand SendEmailCommand { get; set; }
        public FiltrCommand FiltrCommand { get; set; }
        public PaymentsForSelectedDayCommand PaymentsForSelectedDayCommand { get; set; }
        public PaymentsForSelectedCyberCommand PaymentsForSelectedCyberCommand { get; set; }

        private MonthPaymentsCompany? monthPaymentsCompany;

        public MonthPaymentsCompany? MonthPaymentsCompany
        {
            get { return _baseTool.MonthPaymnets(); }
            set { monthPaymentsCompany = value; }
        }

        private string[]? cyberNames;

        public string[]? CyberNames
        {
            get { return _baseTool.LoadCyber(); }
            set { cyberNames = value; }
        }

        private string? cyberName;

        public string? CyberName
        {
            get { return cyberName; }
            set
            {
                cyberName = value;
                OnPropertyChange("CyberName");
            }
        }



        private DateTime? selectedDay;

        public DateTime? SelectedDay
        {
            get { return selectedDay; }
            set
            {
                selectedDay = value;
                OnPropertyChange("SelectedDay");
            }
        }

        private string stringFiltr;

        public string StringFiltr
        {
            get { return stringFiltr; }
            set 
            { 
                stringFiltr = value;
                OnPropertyChange("StringFiltr");
            }
        }


        private DateTime? today;

        public DateTime? Today
        {
            get { return DateTime.Now; }
            set { today = value; }
        }


        private DayPayments? dayPaymentsVM;

        public DayPayments? DayPaymentsVM
        {
            get { return dayPaymentsVM; }
            set
            {
                dayPaymentsVM = value;
                OnPropertyChange("DayPaymentsVM");
            }
        }

        private DayPayments? cyberDayPay;

        public DayPayments? CyberDayPay
        {
            get { return cyberDayPay; }
            set
            {
                cyberDayPay = value;
                OnPropertyChange("CyberDayPay");
            }
        }


        private bool check;

        public bool Check
        {
            get { return check; }
            set
            {
                Check = value;
                OnPropertyChange("Check");
            }
        }

        private string? messageBody;

        public string? MessageBody
        {
            get { return messageBody; }
            set
            {
                messageBody = value;
                OnPropertyChange("MessageBody");
            }
        }


        public void FindDebtCollectors()
        {
            debtCollectors = _baseTool.GetDebtCollectors();
            foreach (var debtCollector in debtCollectors)
                DebtCollectorVMs.Add(
                    new DebtCollector
                    {
                        Name = debtCollector.Name,
                    });
        }

        public void SelectCollectors()
        {
            SelectedDebtCollectorVMs.Clear();
            foreach (var debtCollector in DebtCollectorVMs)
                if (debtCollector.Check == true)
                    SelectedDebtCollectorVMs.Add(debtCollector);

            SelectedDebtCollectorVMs = _baseTool.SelectedCollecotrs(SelectedDebtCollectorVMs);
        }

        public void LoadPayemntForSelectedDay()
        {
            DayPaymentsVM = _baseTool.DayPayments(Convert.ToDateTime(SelectedDay));
        }

        public void LoadPaymentsForCyber()
        {
            CyberDayPay = _baseTool.cyberDayPaidLoad(cyberName, DayPaymentsVM);
        }

        public void LoadMessageBody()
        {
            MessageBody = _mailTools.SetMailReportDay(SelectedDebtCollectorVMs, MonthPaymentsCompany, DayPaymentsVM);
        }

        public void SendMail()
        {
            _mailTools.SendMailDay(MessageBody);
            MessageBox.Show("Wiadmość wysłana", "GOTOWE", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void Filtr()
        {
            foreach(var x in DebtCollectorVMs)
            {
                if (x.Name.Contains(StringFiltr))
                    x.Check = true;
            }
        }
    }
}

