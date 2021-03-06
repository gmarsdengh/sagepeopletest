﻿using LoanAPound.Interfaces;

namespace LoanAPound.Factories
{
    public class DALLoanAPoundCreator
    {
        static public IDALLoanAPound Create(string dalinstance)
        {
            IDALLoanAPound dal = null;

            switch (dalinstance)
            {
                case "test":
                    dal = new LoanAPound.DAL.TestRepository();
                    break;
                default:
                    dal = null;
                    break;
            }
            return dal;

        }
    }
}
