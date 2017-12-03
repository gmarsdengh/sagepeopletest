﻿using LoanAPound.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAPound.Interfaces
{
    public interface ICreditCheckerRule
    {
        CreditChecker SelectAppropriateCheckingAgency(Loan loan);
    }
}
