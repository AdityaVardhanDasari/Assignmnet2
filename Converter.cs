namespace Program{
class Converter
{
	public double convert(string forConvert)
		{
			// int index = 1;
			string exp = forConvert.Substring(1, 8);
			int a = Convert.ToInt32(exp, 2);
			Console.WriteLine(a);
			double fin_a = Math.Pow(2, (a - 127));
			Console.WriteLine(fin_a);

			double fraction = 0;
			for (int i = 9; i < 32; i++)
			{
				if (forConvert[i] == '1')
				{
					fraction = fraction + Math.Pow(2, (-1 * (i - 8)));
				}
			}
			Console.WriteLine(fraction);
			fraction += 1;
			Console.WriteLine(fraction);

			double res = fraction * fin_a;
			
			if(forConvert[0]=='1')
				return -1*res;
			// Console.WriteLine(res);
			else
				return res;
		}
}
}