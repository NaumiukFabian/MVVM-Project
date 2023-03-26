using ReportB2C.ModelsLocal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.Tools
{
    public interface IGeneratorAiscTools
    {
        string GetPath();
        ObservableCollection<AisExcel> CreateExcel(string path);
        void CreateWordDocument(ObservableCollection<AisExcel> aisExcels, DateTime protocolDate, DateTime jobDate);
    }
}
