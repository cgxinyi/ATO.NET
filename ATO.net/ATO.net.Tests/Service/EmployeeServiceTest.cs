using ATO.net.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace ATO.net.Tests.Service
{
    [TestClass]
    public class EmployeeServiceTest
    {
		private EmployeeService employeeService;
		[TestInitialize]
		public void TestInitialize()
		{
			employeeService = new EmployeeService();
		}
		[TestMethod]
		public void TestCalculateIncomeTax1()
		{
			Double calc = employeeService.CalculateIncomeTax(0);
			Assert.AreEqual(calc, 0);
		}

		[TestMethod]
		public void TestCalculateIncomeTax2()
		{
			Double calc = employeeService.CalculateIncomeTax(20000);
			Assert.AreEqual(calc, 342);
		}

		[TestMethod]
		public void TestCalculateIncomeTax3()
		{
			Double calc = employeeService.CalculateIncomeTax(40000);
			Assert.AreEqual(calc, 4547);
		}

		[TestMethod]
		public void TestCalculateIncomeTax4()
		{
			Double calc = employeeService.CalculateIncomeTax(90000);
			Assert.AreEqual(calc, 20932);
		}

		[TestMethod]
		public void TestCalculateIncomeTax5()
		{
			Double calc = employeeService.CalculateIncomeTax(200000);
			Assert.AreEqual(calc, 63232);
		}
	}
}
