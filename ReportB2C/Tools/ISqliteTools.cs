using EpuServices;
using ReportB2C.ModelsLocal.SqLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.Tools
{
    public interface ISqliteTools
    {
        void CreateConnect();
        DateTime LoadDate();
        Task<List<OrzeczenieOutputElement>> GetOrzeczenia();
        List<Orzeczenia> AllOrzeczenia();
        void ChangeStateData(Orzeczenia orzeczenia);
        void AddColumn();
        void UpdateComment(Orzeczenia orzeczenia);
    }
}
