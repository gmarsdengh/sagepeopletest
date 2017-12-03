using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound
{
    public class Administrator : IAdministrator
    {
        private IBLLLoanAPound _bll = null;

        public Administrator(IBLLLoanAPound bll)
        {
            _bll = bll;
        }
        public void SetUpLoanType(int loanTypeID, string loanName, int providerID, int term, double rate)
        {
            _bll.SetUpLoanType(loanTypeID, loanName, providerID, term, rate);
        }
    }
}
