using LoanAPound.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.Interfaces
{
    public interface  IDALLoanAPound
    {
        List<Loan> loans { get; set; }
        List<LoanType> loantypes { get; set; }
        List<CreditChecker> creditcheckers { get; set; }

    }
}
