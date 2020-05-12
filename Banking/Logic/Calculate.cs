using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Data;

namespace Banking.Logic
{
	class Calculate
	{
		public static double Installment(double debt, DateTime end, double interest)
		{
			int years = end.Year - DateTime.Now.Year;
			int mounts = end.Month - DateTime.Now.Month;
			return (debt * Math.Pow(1 + (interest / 100), years)) / (mounts+(years*12));
		}
		
	}
}
