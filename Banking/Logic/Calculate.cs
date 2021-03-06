﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Data;

namespace Banking.Logic
{
	public class Calculate
	{
		//Calculating the installment of credit by using Compound interest formula and then dividing by the number of mounts
		public static double Installment(double debt, DateTime end, double interest)
		{
			int years = end.Year - DateTime.Now.Year;
			int mounts = end.Month - DateTime.Now.Month;
			return Math.Round((debt * Math.Pow(1 + (interest / 100), years+1)) / (mounts+(years*12)),2);
		}
		//Calculating the guarantee of debosit by using Compound interest formula
		public static double Guarantee(double lend, double interest)
		{
			return Math.Round((lend * Math.Pow(1 + (interest / 100),2)),2);
		}
	}
}
