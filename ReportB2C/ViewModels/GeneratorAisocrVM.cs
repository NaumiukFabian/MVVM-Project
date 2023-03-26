using ReportB2C.ModelsLocal;
using ReportB2C.Tools;
using ReportB2C.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.ViewModels
{
    public class GeneratorAisocrVM : ViewModelBase
    {
        private readonly IGeneratorAiscTools _generatorAiscTools;
        public GeneratorAisocrVM(IGeneratorAiscTools generatorAiscTools)
        {
            _generatorAiscTools = generatorAiscTools;
            OpenExcelCommand = new OpenExcelCommand(this);
            GenerateDocumentsCommand= new GenerateDocumentsCommand(this);
        }

        public GenerateDocumentsCommand GenerateDocumentsCommand { get; set; }
        public OpenExcelCommand OpenExcelCommand { get; set; }

        private ObservableCollection<AisExcel> dateExcelAis;

        public ObservableCollection<AisExcel> DateExcelAis
        {
            get { return dateExcelAis; }
            set 
            { 
                dateExcelAis = value;
                OnPropertyChange("DateExcelAis");
            }
        }

        private DateTime? protocolDate;

        public DateTime? ProtocolDate
        {
            get { return protocolDate; }
            set 
            { 
                protocolDate = value;
                OnPropertyChange("ProtocolDate");
            }
        }

        private DateTime? jobDate;

        public DateTime? JobDate
        {
            get { return jobDate; }
            set 
            { 
                jobDate = value;
                OnPropertyChange("JobDate");
            }
        }


        public async void LoadExcel()
        {
            DateExcelAis = _generatorAiscTools.CreateExcel(_generatorAiscTools.GetPath());
        }

        public async void CreateDocumnet()
        {
            _generatorAiscTools.CreateWordDocument(DateExcelAis, Convert.ToDateTime(ProtocolDate), Convert.ToDateTime(JobDate));
        }
    }
}
