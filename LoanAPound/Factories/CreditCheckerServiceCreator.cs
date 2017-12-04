using LoanAPound.Interfaces;


namespace LoanAPound.Factories
{
    public class CreditCheckerServiceCreator
    {
        static public ICreditCheckerService Create(int serviceID)
        {
            ICreditCheckerService service = null;

            switch (serviceID)
            {
                case 1:
                    service = new FirstCreditCheckService();
                    break;
                default:
                    service = new SecondCreditCheckService();
                    break;
            }
            return service;
        }
    }
}
