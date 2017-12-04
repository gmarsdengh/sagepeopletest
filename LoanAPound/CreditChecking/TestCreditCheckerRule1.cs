using LoanAPound.Interfaces;
using System.Linq;

using LoanAPound.DAL;

namespace LoanAPound
{
    public class TestCreditCheckerRule1 : ICreditCheckerRule
    {
        IDALLoanAPound _dal = null;
        public TestCreditCheckerRule1(IDALLoanAPound dal)
        {
            _dal = dal;
        }
        public CreditChecker SelectAppropriateCheckingAgency(Loan loan)
        {
            LoanType type = _dal.loantypes.Where(x => x.LoanTypeID == loan.LoanTypeID).FirstOrDefault();
            if (type.Term > 20)
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
