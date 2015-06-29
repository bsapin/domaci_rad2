using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using domaci_rad2;

namespace DateTest
{
	[TestClass]
	public class DateTesting
	{
		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void negativeDateEnterTest()
		{
			var date = new Date(5, 3, -2000);
		}
		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void zeroDateEnterTest()
		{
			var date = new Date(0,3, 2000);
		}
		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void EnterInvalidMonthTest()
		{
			var date = new Date(5, 13, 2000);
		}
		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void tooManyDaysEnterTest()
		{
			var date = new Date(38, 12, 2000);
		}
		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void tooManyDaysInFebruaryEnterNotLeapYearTest()
		{
			var date = new Date(29, 2, 2009);
		}
		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void tooManyDaysInFebruaryEnterLeapYearTest()
		{
			var date = new Date(30, 2, 2012);
		}
		
		[TestMethod]
		public void getMonthNameTest()
		{
			var date = new Date(5,5,2013);
			Assert.AreEqual("svibanj".ToUpper(), date.getMonthName().ToUpper());
		}
		[TestMethod]
		public void getMonthName_2Test()
		{
			var date = new Date();
			Assert.AreEqual("svibanj".ToUpper(), date.getMonthName(5).ToUpper());
		}
		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void getMonthNameInvalidMonthTest()		// testing what happens when is entered a number higher than 12
		{
			var date = new Date(5, 13, 2015);
			string mjesec = date.getMonthName();
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void getMonthNameZeroMonthTest()		// testing what happens when is entered zero or a number lower than 0
		{
			var date = new Date();	
			string mjesec = date.getMonthName(0);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidProgramException))]
		public void getMonthNameNegativeMonthTest()			// testing what happens when is entered a number lower than 0
		{
			var date = new Date();
			string mjesec = date.getMonthName(-5);
		}

		[TestMethod]
		public void getNumberOfRemaingDaysInMonthNotLeapYearTest()
		{
			var date = new Date(10, 2, 1981);
			Assert.AreEqual(18, date.getNumberOfRemaingDaysInMonth());
		}
		[TestMethod]
		public void getNumberOfRemaingDaysInMonthLeapYearTest()
		{
			var date = new Date(10, 2, 2012);
			Assert.AreEqual(19, date.getNumberOfRemaingDaysInMonth());
		}
		[TestMethod]
		public void getNumberOfRemaingDaysInMonthNotLeapYear_2Test()
		{
			var date = new Date();
			Assert.AreEqual(20, date.getNumberOfRemaingDaysInMonth(8,2,2013));
		}
		[TestMethod]
		public void getNumberOfRemaingDaysInMonthLeapYear_2Test()
		{
			var date = new Date();
			Assert.AreEqual(27, date.getNumberOfRemaingDaysInMonth(2,2,2008));
		}
		[TestMethod]
		public void isLeapYearTest()
		{
			var date = new Date(1,1,2008);
			Assert.AreEqual(true, date.isLeapYear());
		}
		[TestMethod]
		public void isNotLeapYearTest()
		{
			var date = new Date(1, 1, 2007);
			Assert.AreEqual(false, date.isLeapYear());
		}
		[TestMethod]
		public void isLeapYear_2Test()
		{
			var date = new Date();
			Assert.AreEqual(true, date.isLeapYear(2012));
		}
		public void isNotLeapYear_2Test()
		{
			var date = new Date();
			Assert.AreEqual(false, date.isLeapYear(2011));
		}
		[TestMethod]
		public void isLeapYearBecause400Test()
		{
			var date = new Date(1, 1, 2000);
			Assert.AreEqual(true, date.isLeapYear());
		}
		[TestMethod]
		public void isLeapYearBecause400_2Test()
		{
			var date = new Date();
			Assert.AreEqual(true, date.isLeapYear(2000));
		}
	}
}
