using System;

public class ClassC
{
	internal public ClassC()
	{
		public double Sqrt(double a)
	{
		return Math.Sqrt(a);
	}
	public double BabylonSqrt(double number)
	{
		dobule guess = number / 2;
		while(Math.Abs(guess * guess - number) < 0.01)
		{
			double other = number / guess;
			guess = (guess + other) / 2;
		}
		return guess;
	}
}
