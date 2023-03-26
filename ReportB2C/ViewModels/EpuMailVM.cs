using ReportB2C.Tools;
using ReportB2C.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReportB2C.ViewModels
{
    public class EpuMailVM : ViewModelBase
    {
        private readonly EpuVM _epuVM;
        private readonly IMailTools _mailTools;

        public LoadEpuBodyCommand LoadEpuBodyCommand { get; set; }
        public AddAttachmentCommand AddAttachmentCommand { get; set; }
        public SendEmailEPUCommand SendEmailEPUCommand { get; set; }

        public EpuMailVM(EpuVM epuVM, IMailTools mailTools)
        {
            _epuVM = epuVM;
            _mailTools = mailTools;
            LoadEpuBodyCommand = new LoadEpuBodyCommand(this);
            AddAttachmentCommand= new AddAttachmentCommand(this);
            SendEmailEPUCommand= new SendEmailEPUCommand(this);
        }

        private DateTime? todayEpu;

        public DateTime? TodayEpu
        {
            get { return DateTime.Today; }
            set { todayEpu = value; }
        }

        private DateTime? selectedDate;

        public DateTime? SelectedDate
        {
            get { return selectedDate; }
            set 
            { 
                selectedDate = value;
                OnPropertyChange("SelectedDate");
            }
        }


        private string path;

        public string Path
        {
            get { return path; }
            set 
            { 
                path = value;
                OnPropertyChange("Path");
            }
        }


        private string[] sender;

        public string[] Sender
        {
            get { return sender; }
            set 
            { 
                sender = value;
                OnPropertyChange("Sender");
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

        private string[] templates;

        public string[] Templates
        {
            get { return _mailTools.LoadFiles(); }
            set { templates = value; }
        }

        private string selectedTemp;

        public string SelectedTemp
        {
            get { return selectedTemp; }
            set
            {
                selectedTemp = value;
                OnPropertyChange("SelectedTemp");
            }
        }

        public async void SetPage()
        {
            Sender = _mailTools.SetSender(SelectedTemp, _epuVM.SelectedItemO);
        }

        public async void LoadMessageBody()
        {
            MessageBody = _mailTools.LoadBodyMessageEpu(SelectedTemp, _epuVM.SelectedItemO, Convert.ToDateTime(SelectedDate));
        }

        public async void AddAttachment()
        {
            Path = _mailTools.AddAttachment();
        }

        public async void SendMail()
        {
            _mailTools.SendEpu(MessageBody, Sender[3], Sender[2], Path, Sender[1]);
            MessageBox.Show("Mail wysłany poprawnie", "Mail wysłany", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
