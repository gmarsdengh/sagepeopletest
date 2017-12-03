using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.Interfaces
{
    public interface  IAdministrator
    {
        void SetUpLoanType(int loanTypeID, string loanName, int providerID, int term, double rate);
    }
}
