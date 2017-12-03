using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.Factories
{
    public class ApplicantCreator
    {
        static public IApplicant Create(string type, IBLLLoanAPound bll)
        {
            IApplicant applicant = null;

            switch (type)
            {
                case "test":
                    applicant = new Applicant(bll);
                    break;
                default:
                    applicant = null;
                    break;
            }
            return applicant;

        }
    }
}
