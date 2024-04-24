using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    class Program
    {
        /// <summary>
        /// Task 17.6.6. (HW-03)
        /// Strategy 
        /// </summary>

        static void Main(string[] args)
        {
            // Создаем объекты учетных записей
            Account regularAccount = new Account { Type = "Обычный", Balance = 1500 };
            Account salaryAccount = new Account { Type = "Зарплатный", Balance = 2000 };

            // Создаем объекты стратегий
            IInterestCalculation regularStrategy = new RegularInterestCalculation();
            IInterestCalculation salaryStrategy = new SalaryInterestCalculation();

            // Вызываем метод CalculateInterest для каждой учетной записи
            Calculator.CalculateInterest(regularAccount, regularStrategy);
            Calculator.CalculateInterest(salaryAccount, salaryStrategy);

            // Выводим информацию о процентной ставке для каждой учетной записи
            Console.WriteLine($"Процентная ставка для обычного аккаунта: {regularAccount.Interest}");
            Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {salaryAccount.Interest}");

            Console.ReadLine(); 

        }

    }
}