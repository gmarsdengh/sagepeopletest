using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanAPound.DAL;

namespace LoanAPound
{
    public class TestCreditCheckerRule2 : ICreditCheckerRule
    {
        IDALLoanAPound _dal = null;
        public TestCreditCheckerRule2(IDALLoanAPound dal)
        {
            _dal = dal;
        }
        public CreditChecker SelectAppropriateCheckingAgency(Loan loan)
        {
            LoanType type = _dal.loantypes.Where(x => x.LoanTypeID == loan.LoanTypeID).FirstOrDefault();
            if (type.Rate > 5)
            {
                return _dal.creditcheckers.Where(x => x.CheckerID == 1).FirstOrDefault();
            }
            else
            {
                return _dal.creditcheckers.Where(x => x.CheckerID == 2).FirstOrDefault();
            }
        }
    }
}
