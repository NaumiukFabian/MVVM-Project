using EpuServices;
using ReportB2C.ModelsLocal.SqLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.Tools
{
    public interface IApiTools
    {
        Task<List<OrzeczenieOutputElement>> GetJudgments(DateTime data);
        Orzeczenia ConvertXML(Orzeczenia orzeczenieOutputElement);
    }
}
