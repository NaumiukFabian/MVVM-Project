using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReportB2C.ViewModels.Commands
{
    public class SendEmailCommand : ICommand
    {
        public MainWindowVM VM { get; set; }

        public SendEmailCommand(MainWindowVM VM)
        {
            this.VM = VM;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }

        public bool CanExecute(object parameter)
        {
            if(String.IsNullOrEmpty(VM.MessageBody))
                return false;
            else 
                return true;
        }

        public void Execute(object parameter)
        {
            VM.SendMail();
        }
    }
}
