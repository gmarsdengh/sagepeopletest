using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanAPound.Interfaces;
using LoanAPound.Factories;
using System.Linq;

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

        /// <summary>
        /// 3.	As a loan engine, I want to get a credit score from a third party system, 
        /// so that it can be used to inform whether or not the applicant will get his loan 
        /// accepted or rejected
        /// 4.	As a loan engine, I want to be able to implement multiple credit score 
        /// third party system, so that I can chose to use any of them based on various 
        /// creiteria
        /// 5.	As loan engine, I want to be able to approve the loan or not based 
        /// on the credit score&loan amount so that I can refer it to the underwriter 
        /// decision or not
        /// 
        /// Given a specific loan, process should result in status change, score being stored, date updated
        /// </summary>
        [TestMethod]
        public void LoanEngineCanProcessALoan()
        {
            //Arrange - Add a loan type
            IAdministrator administrator = null;
            administrator = AdministratorCreator.Create("test", bll);
            administrator.SetUpLoanType(1, "Type1", 1, 25, 4.5);

            bool applied = applicant.ApplyForALoan(1, 1, 20000);

            //Act
            bool processed = loanEngine.ProcessALoan(dal.loans.Count);

            var loanProcessed = dal.loans.Where(x => x.LoanID == dal.loans.Count).FirstOrDefault();

            //Assert
            Assert.AreEqual(processed, true);
            Assert.IsNotNull(loanProcessed.LoanApprovedRejectedByEngineDate);
            Assert.AreNotSame(loanProcessed.LoanStatus, 1);
            Assert.AreNotSame(loanProcessed.CreditChecker, 0);
        }
    }
}
