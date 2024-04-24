using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    public class SalaryInterestCalculation : IInterestCalculation
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }

}
