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
    public class DeliveryRaportVM : ViewModelBase
    {
        private readonly IBaseTool _baseTools;
        private readonly IMailTools _mailTools;
        public DeliveryRaportCommand DeliveryRaportCommand { get; set; }

        public LoadDeliveryRaportCommand LoadDeliveryRaportCommand { get; set; }
        public SendDeliveryRaportCommand SendDeliveryRaportCommand { get; set; }


        private ObservableCollection<DeliveryInfo> deliveryInfo;

        public ObservableCollection<DeliveryInfo> DeliveryInfo
        {
            get { return deliveryInfo; }
            set
            {
                deliveryInfo = value;
                OnPropertyChange("DeliveryInfo");
            }
        }

        private string messageBody;

        public string MessageBody
        {
            get { return messageBody; }
            set
            {
                messageBody = value;
                OnPropertyChange("MessageBody");
            }
        }


        private string deliveryName;

        public string DeliveryName
        {
            get { return deliveryName; }
            set
            {
                deliveryName = value;
                OnPropertyChange("DeliveryName");
            }
        }

        public DeliveryRaportVM(IBaseTool baseTool, IMailTools mailTools)
        {
            _baseTools = baseTool;
            _mailTools = mailTools;
            DeliveryInfo = new ObservableCollection<DeliveryInfo>();
            DeliveryRaportCommand = new DeliveryRaportCommand(this);
            LoadDeliveryRaportCommand = new LoadDeliveryRaportCommand(this);
            SendDeliveryRaportCommand = new SendDeliveryRaportCommand(this);

        }

        public void LoadDeliveryInfo()
        {
            DeliveryInfo = _baseTools.LoadDateFromDelivery(DeliveryName);
        }

        public void LoadMessageBody()
        {
            MessageBody = _mailTools.EmailDeliveryReport(DeliveryInfo, DeliveryName);
        }

        public void SendMail()
        {
            _mailTools.SendDeliveryRaport(MessageBody, DeliveryName);
            MessageBox.Show("Mail został wysłany", "GOTOWE", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
