using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
