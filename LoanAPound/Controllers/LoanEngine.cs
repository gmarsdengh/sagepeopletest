using LoanAPound.Interfaces;

namespace LoanAPound
{
    public class LoanEngine : ILoanEngine
    {
        private IBLLLoanAPound _bll = null;

        public LoanEngine(IBLLLoanAPound bll)
        {
            _bll = bll;
        }

        public bool ProcessALoan(int loanID)
        {
            return _bll.ProcessALoan(loanID);
        }
    }
}
