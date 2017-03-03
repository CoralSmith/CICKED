using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catapult
{
    public interface IUtil
    {
        int Add(int first, int second);
        double Add(double first, double second);
        int DaysFromNow(DateTime targetDate);
    }

	public class Util : IUtil
	{
		public int Add(int first, int second)
		{
			return first + second;
		}
		public double Add(double first, double second)
		{
			return first + second;
		}

		public int DaysFromNow(DateTime targetDate)
		{
			int[] monthLengths = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			int totalDays = 0;
			DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

			if (targetDate > DateTime.Now)
			{
				while (today.AddMonths(1) < targetDate)
				{
					totalDays += monthLengths[today.Month];
					today = today.AddMonths(1);
				}
				while (today.AddDays(1) <= targetDate)
				{
					totalDays++;
					today = today.AddDays(1);
				}
				return totalDays;
			}
			while (today.AddMonths(-1) > targetDate)
			{
				totalDays += monthLengths[today.Month];
				today = today.AddMonths(-1);
			}
			while (today.AddDays(-1) >= targetDate)
			{
				totalDays++;
				today = today.AddDays(-1);
			}
			return totalDays;
		}
	}

}
