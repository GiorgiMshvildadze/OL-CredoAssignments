using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringForSRP
{
    public interface IEmailSender
    {
        public void SendInvoiceEmail(Invoice invoice, string email);
    }
}
