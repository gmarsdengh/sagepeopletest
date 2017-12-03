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
        /// <summary>
        /// 1.	As a LoanAPound administrator, I want to be able to setup 
        ///different types of loans with criteria such as (but not limited to) 
        ///term/years, borrowing rate, provider
        ///
        /// Given, there are no loan types set up, the number of loan types  
        /// is 1 after the method call
        /// </summary>
        [TestMethod]
        public void AdminCanCreateALoanType()
        {
            //Inject DAL and BLL classes for testing
            IDALLoanAPound dal = null;
            dal = DALLoanAPoundCreator.Create("test");         
            IBLLLoanAPound bll = null;
            bll = BLLLoanAPoundCreator.Create("test", dal);


            IAdministrator administrator = null;
            administrator = AdministratorCreator.Create("test", bll);

            //Act
            administrator.SetUpLoanType(1, "Type1", 1, 25, 4.5);

            //Assert
            Assert.AreEqual(dal.loantypes.Count, 1);

        }
    }
}
