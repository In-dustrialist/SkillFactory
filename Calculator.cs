using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    public static class Calculator
    {
        public static void CalculateInterest(Account account, IInterestCalculation strategy)
        {
            strategy.CalculateInterest(account);
        }
    }

}
