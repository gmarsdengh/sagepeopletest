using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanAPound.DAL;

namespace LoanAPound
{
    public class Applicant : IApplicant
    {
        private IBLLLoanAPound _bll = null;

        public Applicant(IBLLLoanAPound bll)
        {
            _bll = bll;
        }
        public bool ApplyForALoan(int loanTypeID, int userID, int loanAmount)
        {
            return _bll.ApplicantApplyForLoan(loanTypeID, userID, loanAmount);
        }

        public Loan ViewProgress(int loanID)
        {
            return _bll.ViewProgress(loanID);
        }
    }
}
