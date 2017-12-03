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
            dal = DALLoanAPoundCreator.Create("test");
            bll = BLLLoanAPoundCreator.Create("test", dal);
            applicant = ApplicantCreator.Create("test", bll);

        }

        [TestMethod]
        public void ApplicantCanApplyForALoan()
        {
            bool applied = applicant.ApplyForALoan(1, 1, 20000);

            Assert.AreEqual(dal.loans.Count, 3);
            Assert.AreEqual(applied, true);
        }

        [TestMethod]
        public void ApplicantCanApplyForALoanThenViewIt()
        {
            bool applied = applicant.ApplyForALoan(1, 1, 20000);
            Loan loanToView = applicant.ViewProgress(dal.loans.Count);
            Assert.IsNotNull(loanToView);
            Assert.AreEqual(loanToView.LoanTypeID, 1);
            Assert.AreEqual(loanToView.UserID, 1);
            Assert.AreEqual(loanToView.LoanAmount, 20000);
            Assert.AreEqual(loanToView.LoanStatus, 1);
        }

    }
}
