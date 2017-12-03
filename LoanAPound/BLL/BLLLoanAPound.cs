using LoanAPound.DAL;
using LoanAPound.Factories;
using LoanAPound.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.BLL
{
    public class BLLLoanAPound : IBLLLoanAPound
    {
        IDALLoanAPound _dal = null;
        public BLLLoanAPound(IDALLoanAPound dal)
        {
            _dal = dal;
        }

        public bool ApplicantApplyForLoan(int loanTypeID, int userID, int loanAmount)
        {
            Loan loan = new Loan()
            {
                LoanID = _dal.loans.Count + 1,
                UserID = userID,
                LoanTypeID = loanTypeID,
                LoanAmount = loanAmount,
                LoanStatus = 1,
                LoanRequestDate = DateTime.Now

            };
            _dal.loans.Add(loan);
            return true;
        }

        public bool ProcessALoan(int loanID)
        {
            var loanToCheck = _dal.loans.Where(x => x.LoanID == loanID).FirstOrDefault();
            ICreditCheckerRule rule = null;
            rule = CheckCreditRuleCreator.Create(loanToCheck, _dal);
            CreditChecker checker = rule.SelectAppropriateCheckingAgency(loanToCheck);

            ICreditCheckerService service = null;
            service = CreditCheckerServiceCreator.Create(checker.CheckerID);
            var creditScore =  service.GetCreditCheckScore(loanToCheck.UserID);

            if (creditScore > 50)
            {
                //Accept
                loanToCheck.LoanStatus = 2;
                loanToCheck.LoanInitialApprovalDate = DateTime.Now;
            }
            else
            {
                //Reject
                loanToCheck.LoanStatus = -1;
                loanToCheck.LoanRejectedDate = DateTime.Now;

            }
            //Need to score creditcheck
            //Need to sendalert
            return true;
        }

        public void SetUpLoanType(int loanTypeID, string loanName, int providerID, int term, double rate)
        {
            LoanType loanType = new LoanType()
            {
                LoanTypeID = loanTypeID,
                LoanName = loanName,
                ProviderID = providerID,
                Term = term,
                Rate = rate
            };
            
          _dal.loantypes.Add(loanType);
        }

        public Loan ViewProgress(int loanID)
        {
            return _dal.loans.Where(x=>x.LoanID == loanID).FirstOrDefault();
        }
    }
}
