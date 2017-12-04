using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;

namespace LoanAPound.DAL
{

    public class TestRepository : IDALLoanAPound
    {
        public List<Loan> loans { get; set; }
        public List<LoanType> loantypes { get; set; }
        public List<CreditChecker> creditcheckers { get; set; }

        public TestRepository() 
        {
            loans = new List<Loan>()
                {
                    new Loan {LoanID = 1, UserID = 1},
                    new Loan {LoanID = 2,  UserID = 2}

                };

            loantypes = new List<LoanType>();

            creditcheckers = new List<CreditChecker>()
                {
                    new CreditChecker { CheckerID =1, CheckerServiceAddress= "http://1..." },
                    new CreditChecker { CheckerID =2, CheckerServiceAddress= "http://2..." },

                };


        }
    }
   
}
