using Banking.Data;
using Banking.Presentation;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace BankingTest
{
	public class Tests
	{

		[Test]
		public void CalculateInstallment()
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year+1, DateTime.Now.Month, DateTime.Now.Day);
			double installment = Banking.Logic.Calculate.Installment(100, dateTime, 2);
			Assert.AreEqual(8.67,installment);
		}
		[Test]
		public void CalculateGuarantee()
		{
			double guarantee = Banking.Logic.Calculate.Guarantee(100, 2);
			Assert.AreEqual(104.04, guarantee);
		}
		[Test]
		public void NewCreditor()
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
			Creditors creditor = new Creditors("1111-2222-3333", "Petur Petrov", 200, dateTime, 2, 123123);
			Assert.AreEqual(Math.Round(208.08,2), creditor.guarantee);
		}
		[Test]
		public void NewDebtor()
		{
			DateTime dateTime = new DateTime(2025, 10, 12);
			Debtors debtor = new Debtors("1111-2222-3333", "Petur Petrov", 200, dateTime, 2, 123123);
			Assert.AreEqual(Math.Round(3.46512,2), debtor.installment);
		}
	}
}