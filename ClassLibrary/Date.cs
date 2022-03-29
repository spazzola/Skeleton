using System;

public class Date
{
	public int day;
	public int month;
	public int year;
	public string dateStr;

	public Date()
	{
		day = 29;
		month = 3;
		year = 2001;
		dateStr = day + "/" + month + "/" + year;
	}
}
