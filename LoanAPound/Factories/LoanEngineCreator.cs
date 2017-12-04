using LoanAPound.Interfaces;

namespace LoanAPound.Factories
{
  public class LoanEngineCreator
    {
        static public ILoanEngine Create(string type, IBLLLoanAPound bll)
        {
            ILoanEngine loanEngine = null;

            switch (type)
            {
                case "test":
                    loanEngine = new LoanEngine(bll);
                    break;
                default:
                    loanEngine = null;
                    break;
            }
            return loanEngine;

        }
    }
}
