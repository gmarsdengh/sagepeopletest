using LoanAPound.BLL;
using LoanAPound.Interfaces;

namespace LoanAPound.Factories
{

    public class BLLLoanAPoundCreator
    {

        static public IBLLLoanAPound Create(string bllInstance, IDALLoanAPound dal)
        {
            IBLLLoanAPound bllLoan = null;

            switch (bllInstance)
            {
                case "test":
                    bllLoan = new BLLLoanAPound(dal);
                    break;
                default:
                    bllLoan = null;
                    break;
            }
            return bllLoan;

        }
    }
}
