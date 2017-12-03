using LoanAPound.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.Interfaces
{
    public interface IApplicant
    {
        bool ApplyForALoan(int loanTypeID, int userID, int loanAmount);
        Loan ViewProgress(int loanID);
    }
}
