using EpuServices;
using ReportB2C.Models.EpuModels;
using ReportB2C.ModelsLocal;
using ReportB2C.ModelsLocal.SqLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.Tools
{
    public interface IMailTools
    {
        string SetMailReportDay(ObservableCollection<DebtCollector> debtCollectors, MonthPaymentsCompany allPayments, DayPayments dayPaymentsToMail);
        void SendMailDay(string messageBody);
        string EmailDeliveryReport(ObservableCollection<DeliveryInfo> deliveryInfoVMs, string data);
        void SendDeliveryRaport(string messageBody, string data);
        string[] LoadFiles();
        string LoadBodyMessageEpu(string tempName, Orzeczenia selectedItem, DateTime selectedData);
        string[] SetSender(string selectedTemp, Orzeczenia selectedItem);
        string AddAttachment();
        void SendEpu(string messageBody, string subject, string copy, string path, string to);

    }
}
