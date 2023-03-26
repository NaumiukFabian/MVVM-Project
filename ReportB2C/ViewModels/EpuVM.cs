using EpuServices;
using ReportB2C.ModelsLocal.SqLite;
using ReportB2C.Tools;
using ReportB2C.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReportB2C.ViewModels
{
    public class EpuVM : ViewModelBase
    {
        private readonly IApiTools _tool;
        private readonly IBaseTool _baseTool;
        private readonly IMailTools _mailTools;
        private readonly ISqliteTools _createTable;
        List<OrzeczenieOutputElement> outputs;
        List<Orzeczenia> outputsO;
        public EpuVM(IApiTools tool, IBaseTool baseTool, IMailTools mailTools, ISqliteTools createTable)
        {
            _tool = tool;
            _baseTool = baseTool;
            _mailTools = mailTools;
            _createTable = createTable;
            JudgmentsOutputElemets = new ObservableCollection<OrzeczenieOutputElement>();
            JudgmentsOutputElements = new ObservableCollection<Orzeczenia>();
            LoadUpdateDate();
            outputs = new List<OrzeczenieOutputElement>();
            _createTable = createTable;
            LoadApiCommand = new LoadApiCommand(this);
            LoadSelectedJudgmentsCommand = new LoadSelectedJudgmentsCommand(this);
            ChangeStateCommand = new ChangeStateCommand(this);
            AddCommentCommand = new AddCommentCommand(this);
            ChangeIndexTabCommand = new ChangeIndexTabCommand(this);
            SetCombo();
        }

        public ChangeIndexTabCommand ChangeIndexTabCommand { get; set; }

        public AddCommentCommand AddCommentCommand { get; set; }

        public ChangeStateCommand ChangeStateCommand { get; set; }

        public LoadSelectedJudgmentsCommand LoadSelectedJudgmentsCommand { get; set; }

        public ObservableCollection<Orzeczenia> JudgmentsOutputElements { get; set; }


        public ObservableCollection<OrzeczenieOutputElement> JudgmentsOutputElemets { get; set; }

        public LoadApiCommand LoadApiCommand { get; set; }

        private int selectedIndex;

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set 
            { 
                selectedIndex = value;
                OnPropertyChange("SelectedIndex");
            }
        }


        private DateTime updateDate;

        public DateTime UpdateDate
        {
            get { return updateDate; }
            set 
            { 
                updateDate = value;
                OnPropertyChange("UpdateDate");
            }
        }

        private Orzeczenia selectedItemO;

        public Orzeczenia SelectedItemO
        {
            get { return selectedItemO; }
            set 
            { 
                selectedItemO = _tool.ConvertXML(value);
                OnPropertyChange("SelectedItemO");
            }
        }

        private string[] typeOfJudgments;

        public string[] TypeOfJudgments
        {
            get { return typeOfJudgments; }
            set 
            { 
                typeOfJudgments = value;
                OnPropertyChange("TypeOfJudgments");
            }
        }

        private string selectedType;

        public string SelectedType
        {
            get { return selectedType; }
            set 
            { 
                selectedType = value;
                OnPropertyChange("SelectedType");
            }
        }

        public async void LoadApi()
        {
            if (await _createTable.GetOrzeczenia() == null)
            {
                MessageBox.Show("Brak nowych orzeczeń");
                return;
            }
                
            await _createTable.GetOrzeczenia();
            _createTable.CreateConnect();
            LoadUpdateDate();
            MessageBox.Show("Gotowe");
        }

        public async void LoadUpdateDate()
        {
            UpdateDate = _createTable.LoadDate();
        }

        public async void LoadOrzeczenia()
        {
            outputsO = _createTable.AllOrzeczenia();
            JudgmentsOutputElements.Clear();
            SplitJudgments();

        }

        private void SplitJudgments()
        {
            if (SelectedType == "Zrobione")
            {
                foreach (var output in outputsO)
                {
                    if (output.Done == true && output.NazwaDecyzji != "Postanowienie o nadaniu klauzuli wykonalności"
                        && output.NazwaDecyzji != "Zarządzenie o stwierdzeniu doręczenia"
                        && output.NazwaDecyzji != "Zarządzenie o reklamacji przesyłki")
                        JudgmentsOutputElements.Add(output);
                }
            }
            else if (SelectedType == "Zrobione Automatycznie")
            {
                foreach (var output in outputsO)
                {
                    if (output.NazwaDecyzji == "Postanowienie o nadaniu klauzuli wykonalności"
                        || output.NazwaDecyzji == "Zarządzenie o stwierdzeniu doręczenia"
                        || output.NazwaDecyzji == "Zarządzenie o reklamacji przesyłki")
                        JudgmentsOutputElements.Add(output);
                }
            }
            else if (SelectedType == "Niezrobione")
            {

                foreach (var output in outputsO)
                {
                    if (output.Done == false && output.NazwaDecyzji != "Postanowienie o nadaniu klauzuli wykonalności"
                        && output.NazwaDecyzji != "Zarządzenie o stwierdzeniu doręczenia"
                        && output.NazwaDecyzji != "Zarządzenie o reklamacji przesyłki")
                        JudgmentsOutputElements.Add(output);
                }
            }
        }

        public async void SetCombo()
        {
            TypeOfJudgments = _baseTool.SetComboJudgments();
        }

        public async void ChangeState()
        {
            _createTable.ChangeStateData(SelectedItemO);
        }

        public async void AddComment()
        {
            _createTable.UpdateComment(SelectedItemO);
        }

        public async void ChangeIndex()
        {
            SelectedIndex = 1;
        }
    }

}
