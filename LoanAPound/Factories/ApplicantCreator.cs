using LoanAPound.Interfaces;


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
