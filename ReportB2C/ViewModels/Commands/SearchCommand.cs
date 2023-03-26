using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReportB2C.ViewModels.Commands
{
    public class SearchCommand : ICommand
    {
        public MainWindowVM VM { get; set; }

        public SearchCommand(MainWindowVM VM)
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
            //string name = (string)parameter;
            //if(string.IsNullOrEmpty(name))
            //    return false;
            //else 
            //    return true;
            return true;

        }

        public void Execute(object parameter)
        {
            VM.FindDebtCollectors();
        }
    }
}
