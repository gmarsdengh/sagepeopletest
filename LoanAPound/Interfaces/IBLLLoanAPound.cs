using LoanAPound.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.Interfaces
{
    public interface IBLLLoanAPound
    {
        bool ApplicantApplyForLoan(int loanTypeID, int userID, int loanAmount);
        void SetUpLoanType(int loanTypeID, string loanName, int providerID, int term, double rate);
        Loan ViewProgress(int loanID);
        bool ProcessALoan(int loanID);
    }
}
