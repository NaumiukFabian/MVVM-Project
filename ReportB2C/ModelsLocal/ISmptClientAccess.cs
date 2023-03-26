using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ReportB2C.ModelsLocal
{
    public interface ISmptClientAccess
    {
        void SetClientRaport(string messageBody, string subject, string data);

        void SetClientEpu(string messageBody, string subjcet, string copy, string path, string to);

        void Attachment(string path, string fileName);
    }
}
