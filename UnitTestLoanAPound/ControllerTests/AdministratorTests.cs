using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanAPound.Interfaces;
using LoanAPound.Factories;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestLoanAPound
{
    [TestClass]
    public class AdministratorTests
    {
        //1.	As a LoanAPound administrator, I want to be able to setup 
        //different types of loans with criteria such as (but not limited to) 
        //term/years, borrowing rate, provider
        [TestMethod]
        public void AdminCanCreateALoanType()
        {
            IDALLoanAPound dal = null;
            dal = DALLoanAPoundCreator.Create("test");         
            IBLLLoanAPound bll = null;
            bll = BLLLoanAPoundCreator.Create("test", dal);

            IAdministrator administrator = null;
            administrator = AdministratorCreator.Create("test", bll);
            administrator.SetUpLoanType(1, "Type1", 1, 25, 4.5);

            Assert.AreEqual(dal.loantypes.Count, 1);


        }
    }
}
