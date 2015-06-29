using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci_rad2
{
	public class Date 
	{
		public Date()
		{ }
		public Date(int d, int m, int y)
		{
			checkDateFormat(d, m, y);
			this.day = d;
			this.month = m;
			this.year = y;
			
		}
		public void checkDateFormat(int d, int m, int y)
		{
			if (d <= 0 || m <= 0 || y <= 0)
			{
				throw new InvalidProgramException("Brojevi moraju biti pozitivni");
			}
			if (m > 12)
			{
				throw new InvalidProgramException("Unijeli ste broj mjeseca koji ne postoji");
			}
			if (d > numberOfDaysInMonth[m - 1] || isLeapYear(y) && m == 2 && d > numberOfDaysInMonth[m - 1] + 1)
			{
				throw new InvalidProgramException("Unijeli ste veći broj dana nego što ima u navedenom mjesecu");
			}
		}
		public int getDay()
		{
			return this.day;
		}

		public int getMonth()
		{
			return this.month;
		}

		public int getYear()
		{
			return this.year;
		}
		public string getMonthName()
		{
			string[] months = new string[]{"Siječanj","Veljača","Ožujak","Travanj","Svibanj","Lipanj","Srpanj",
				"Kolovoz","Rujan","Listopad","Studeni","Prosinac"};
			return months[this.month - 1];
		}
		public string getMonthName(int month)
		{
			string[] months = new string[]{"Siječanj","Veljača","Ožujak","Travanj","Svibanj","Lipanj","Srpanj",
				"Kolovoz","Rujan","Listopad","Studeni","Prosinac"};
			if (month > 0 && month <= 12)
			{
				return months[month - 1];
			}
			else
			{ throw new InvalidProgramException("Unijeli ste ne postojeći mjesec"); }
		}
		public int getNumberOfRemaingDaysInMonth()
		{
			if (isLeapYear() && this.month == 2)
			{
				return numberOfDaysInMonth[this.month - 1]+1 - this.day;
			}
			else
				return numberOfDaysInMonth[this.month - 1] - this.day;
		}
		public int getNumberOfRemaingDaysInMonth(int d, int m, int y)
		{
			if (isLeapYear(y) && m == 2)
			{
				return numberOfDaysInMonth[m - 1] + 1 - d;
			}
			else
				return numberOfDaysInMonth[m - 1] - d;
		}

		public bool isLeapYear(int year)
		{
			if (year % 4 == 0 && year % 100 != 0)
			{
				return true;
			}
			else if (year % 400 == 0)
				return true;
			else
				return false;
		}
		public bool isLeapYear()
		{
			if (year % 4 == 0 && year % 100 != 0)
			{
				return true;
			}
			else if (year % 400 == 0)
				return true;
			else
				return false;
		}


		int day;
		int month;
		int year;
		int[] numberOfDaysInMonth=new int[12] {31,28,31,30,31,30,31,31,30,31,30,31};
	}
}
