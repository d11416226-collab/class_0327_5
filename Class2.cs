using System;

public class Student
{
	private int ID;
	private string Name;
	private Test Score;
	public static int Count;
	public Student(int id, string n, int m, int f)
	{
		ID = id;
		Name = n;
		Score = new Test(m, f);
	}

	public string GetStudent()
	{
		string str = "";

		str = "學生編號" + ID.ToString();
		str += "\n學生姓名" + Name;
		str += "\n學生期末考試" + Score.GetMid();
		str+="\n學生期末考試"+Score.GetFinal();

		return str;
	}
	public static int StdCount()
	{
		return Count;
	}
}
