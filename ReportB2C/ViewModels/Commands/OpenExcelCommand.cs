﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReportB2C.ViewModels.Commands
{
    public class OpenExcelCommand : ICommand
    {
        public GeneratorAisocrVM VM { get; set; }

        public OpenExcelCommand(GeneratorAisocrVM VM)
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
            return true;
        }

        public void Execute(object parameter)
        {
            VM.LoadExcel();
        }
    }
}
