using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
