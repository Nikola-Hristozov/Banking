using Banking.Data;
using Banking.Presentation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Moq;
using NUnit.Framework;
using System;
using System.Data.Entity;

namespace BankingTest
{
	public class Tests
	{
		//Testing the Logic.Calculate.Installment Method
		[Test]
		public void CalculateInstallment()
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year+1, DateTime.Now.Month, DateTime.Now.Day);
			double installment = Banking.Logic.Calculate.Installment(100, dateTime, 2);
			Assert.AreEqual(8.67,installment);
		}
		//Testing the Logic.Calculate.Guarantee Method
		[Test]
		public void CalculateGuarantee()
		{
			double guarantee = Banking.Logic.Calculate.Guarantee(100, 2);
			Assert.AreEqual(104.04, guarantee);
		}
		//Testing the Data.Creditor Constructor
		[Test]
		public void NewCreditor()
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
			Creditors creditor = new Creditors("1111-2222-3333", "Petur Petrov", 200, dateTime, 2, 123123);
			Assert.AreEqual(Math.Round(208.08,2), creditor.guarantee);
		}
		//Testing the Data.Dabtors Constructor
		[Test]
		public void NewDebtor()
		{
			DateTime dateTime = new DateTime(2025, 10, 12);
			Debtors debtor = new Debtors("1111-2222-3333", "Petur Petrov", 200, dateTime, 2, 123123);
			Assert.AreEqual(Math.Round(3.46512,2), debtor.installment);
		}
	}
}