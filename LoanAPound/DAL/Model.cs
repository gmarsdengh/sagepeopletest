using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.DAL
{
    public class CreditChecker
    {
        public int CheckerID { get; set; }
        public string CheckerServiceAddress { get; set; }

    }
    public class Loan
    {
        public int LoanID { get; set; }
        public int LoanTypeID { get; set; }
        public int UserID { get; set; }
        public int LoanAmount { get; set; }
        public int LoanStatus { get; set; }
        public DateTime LoanRequestDate { get; set; }
        public DateTime LoanInitialApprovalDate { get; set; }
        public DateTime LoanUnderwriterApprovalDate { get; set; }
        public DateTime LoanRejectedDate { get; set; }
        public DateTime LoanUnderwriterRejectedDate { get; set; }

    }
    public class LoanType
    {
        public int LoanTypeID { get; set; }
        public string LoanName { get; set; }
        public int ProviderID { get; set; }
        public int Term { get; set; }
        public double Rate { get; set; }

    }
}
