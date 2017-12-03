using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanAPound.Interfaces;
using LoanAPound.Factories;
using LoanAPound;
using LoanAPound.DAL;

namespace UnitTestLoanAPound
{
    [TestClass]
    public class ApplicantTest
    {
        IDALLoanAPound dal = null;
        IBLLLoanAPound bll = null;
        IApplicant applicant = null;

        [TestInitialize]
        public void Setup()
        {
            //Inject classes for tests
            dal = DALLoanAPoundCreator.Create("test");
            bll = BLLLoanAPoundCreator.Create("test", dal);
            applicant = ApplicantCreator.Create("test", bll);

        }
        /// <summary>
        /// 2.	As a loan applicant, I want to be able to apply for a loan online so 
        /// that I get a decision on money being lent to me or not
        /// 
        /// Given, there are 2 loans in the repository, calling the method should result in 3
        /// and true should be returned
        /// </summary>
        [TestMethod]
        public void ApplicantCanApplyForALoan()
        {
            //Act
            bool applied = applicant.ApplyForALoan(1, 1, 20000);

            //Assert
            Assert.AreEqual(dal.loans.Count, 3);
            Assert.AreEqual(applied, true);
        }

        /// <summary>
        /// 6.	As an applicant, I want to be able to view online the progress 
        /// of my application
        /// 
        /// Given I've applied for a loan, when I call the method, the loan details are returned
        /// Loan details are as in the application. Status is 1 (Applied)
        /// </summary>
        [TestMethod]
        public void ApplicantCanApplyForALoanThenViewIt()
        {
            //Arrange
            bool applied = applicant.ApplyForALoan(1, 1, 20000);

            //Act
            Loan loanToView = applicant.ViewProgress(dal.loans.Count);

            //Assert
            Assert.IsNotNull(loanToView);
            Assert.AreEqual(loanToView.LoanTypeID, 1);
            Assert.AreEqual(loanToView.UserID, 1);
            Assert.AreEqual(loanToView.LoanAmount, 20000);
            Assert.AreEqual(loanToView.LoanStatus, 1);
        }

    }
}
