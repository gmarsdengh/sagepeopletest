using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanAPound.Interfaces;
using LoanAPound.Factories;

namespace UnitTestLoanAPound
{
    [TestClass]
    public class LoanEngineTests
    {
        IDALLoanAPound dal = null;
        IBLLLoanAPound bll = null;
        ILoanEngine loanEngine = null;
        IApplicant applicant = null;

        [TestInitialize]
        public void Setup()
        {
            dal = DALLoanAPoundCreator.Create("test");
            bll = BLLLoanAPoundCreator.Create("test", dal);
            loanEngine = LoanEngineCreator.Create("test", bll);
            applicant = ApplicantCreator.Create("test", bll);

        }

        [TestMethod]
        public void LoanEngineCanProcessALoan()
        {
            IAdministrator administrator = null;
            administrator = AdministratorCreator.Create("test", bll);
            administrator.SetUpLoanType(1, "Type1", 1, 25, 4.5);

            bool applied = applicant.ApplyForALoan(1, 1, 20000);

            bool processed = loanEngine.ProcessALoan(dal.loans.Count);

            Assert.AreEqual(processed, true);
        }
    }
}
