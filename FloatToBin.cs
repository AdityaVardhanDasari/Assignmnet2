namespace Program{
public class FloatToBin
{
	
	public string FloatToBinary(float num)
	{
		char sign = '0';
		if(num<0)
		{
			sign = '1';
		}
		int int_part = Math.Abs((int)num);
		
		float rad_part = Math.Abs(num) - int_part;
		
		string int_bin = Convert.ToString(int_part, 2);
		
		string rad_bin = radToBin(rad_part);
		
		string binary = int_bin + rad_bin;
		
		int exp = int_bin.Length - 1;
		
		int index = 0;
		
		while (binary[index] == '0' && index < 22)
		{
			index++;
			binary += "0";
		}
		if (binary[0] == '0')
		{
			exp -= index;

			binary = binary.Substring(index);
		}
		
		string exp_bin = Convert.ToString((int)exp + 127, 2);
		if (exp_bin.Length != 8)
		{
			for (int i = 0; i < 8 - exp_bin.Length; i++)
			{
				exp_bin = '0' + exp_bin;
			}
		}
		// Console.WriteLine(sign);
		
		string result = sign+exp_bin+binary.Substring(1,23);	
		Console.WriteLine(sign + " " + exp_bin + " " + binary.Substring(1,23));
		
		return result;
	}
	public string radToBin(float rad)
		{
			string ans = string.Empty;
			for (int i = 0; i < 23; i++)
			{
				rad = rad * 2;
				if (rad >= 1)
				{
					ans = ans + "1";
					rad = rad - 1;
				} 
				else{
					ans = ans + "0";
				}
			}
			return ans;
		}
}
}