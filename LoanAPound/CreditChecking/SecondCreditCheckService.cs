using LoanAPound.Interfaces;

namespace LoanAPound
{
    class SecondCreditCheckService : ICreditCheckerService
    {
        public int GetCreditCheckScore(int UserID)
        {
            return 77;
        }
    }
}
