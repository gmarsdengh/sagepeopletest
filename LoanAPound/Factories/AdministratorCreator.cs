using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.Factories
{
     
    public class AdministratorCreator
    {
        static public IAdministrator Create(string type, IBLLLoanAPound bll)
        {
            IAdministrator administrator = null;

            switch (type)
            {
                case "test":
                    administrator = new Administrator(bll);
                    break;
                default:
                    administrator = null;
                    break;
            }
            return administrator;

        }
    }
}
