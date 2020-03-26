using Castle.MicroKernel.Registration;

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Castle.Windsor;

namespace SalaryCalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
         IService _service;
       

        [TestInitialize]
        public void SetUp()
        {

            var container = new WindsorContainer();

            container.Register(Component.For<ISalaryCalculator>().ImplementedBy<SalaryCalculatorA>());
            container.Register(Component.For<ISalaryCalculator>().ImplementedBy<SalaryCalculatorB>());

            container.Register(Component.For<IService>().ImplementedBy<Service>());

            _service = container.Resolve<IService>();
        }
        [TestMethod]
        public void AnnualSalaryTest()
        {
        //    SalaryCalculator _salarycalculator = new SalaryCalculator();
            decimal annaulSalary = _service.GetAnnualSalary(50);
            Assert.AreEqual(104000, annaulSalary);
        }


        [TestMethod]
        public void HourlyWageTest()
        {
         //   SalaryCalculator _salarycalculator = new SalaryCalculator();
            decimal hourlyWage = _service.GetHourlySalary(52000);
            Assert.AreEqual(25, hourlyWage);
        }
    }
}
