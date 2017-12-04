using LoanAPound.DAL;
using LoanAPound.Interfaces;

namespace LoanAPound.Factories
{
    public class CheckCreditRuleCreator
    {
        static public ICreditCheckerRule Create(Loan loan, IDALLoanAPound dal)
        {
            ICreditCheckerRule creditCheckerRule = null;

            if (loan.LoanAmount > 50000) {
                creditCheckerRule = new TestCreditCheckerRule1(dal);
            }
            else {
                creditCheckerRule = new TestCreditCheckerRule2(dal);
            }
            return creditCheckerRule;

        }
    }
}
