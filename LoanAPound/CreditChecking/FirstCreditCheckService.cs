using LoanAPound.Interfaces;

namespace LoanAPound
{
    class FirstCreditCheckService : ICreditCheckerService
    {
        public int GetCreditCheckScore(int UserID)
        {
            return 55;
        }
    }
}
