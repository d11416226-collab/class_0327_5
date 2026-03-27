using System;

public class Test
{
	private int Mid;
	private int Final;

	public Test(int Mid, int Final)
	{
		this.Mid = Mid;
		this.Final = Final;
	}

	public void SetMid(int Mid)
	{
		this.Mid = Mid;
	}
	public void SetFinal(int Final)
	{
		this.Final = Final;
	}
}

	public class Test
	{
		public int GetMid()
		{
			return Mid;
		}
		public int GetFinal()
		{
			return Final;
		}
		public double GetAvg()
		{
			return (Mid + Final) / 2.0;
		}
	
}
