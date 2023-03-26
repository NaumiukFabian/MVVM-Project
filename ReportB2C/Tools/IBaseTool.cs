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
    public interface IBaseTool
    {
        DebtCollector[] GetDebtCollectors();
        ObservableCollection<DebtCollector> SelectedCollecotrs(ObservableCollection<DebtCollector> SelectedCollectors);
        MonthPaymentsCompany MonthPaymnets();
        DayPayments DayPayments(DateTime dayPaid);
        string[] LoadCyber();
        DayPayments cyberDayPaidLoad(string cyberName, DayPayments dayPayments);
        ObservableCollection<DeliveryInfo> LoadDateFromDelivery(string data);
        string[] SetComboBoxTemplate();
        string[] SetComboJudgments();
    }
}
