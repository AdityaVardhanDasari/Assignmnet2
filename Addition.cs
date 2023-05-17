namespace Program{
class Addition
{
	public static string add(string binary1, string binary2)
		{
			string ans = string.Empty;
			int carry = 0;
			binary1 = binary1.Substring(0, 23);
			binary2 = binary2.Substring(0, 23);
			for (int i = binary1.Length - 1; i >= 0; i--)
			{
				if (binary1[i] == '0' && binary2[i] == '0')
				{
					if (carry == 0)
					{
						ans = "0" + ans;
						carry = 0;
					}
					else
					{
						ans = "1" + ans;
						carry = 0;
					}
				}
				if (binary1[i] == '1' && binary2[i] == '0')
				{
					if (carry == 0)
					{
						ans = "1" + ans;
						carry = 0;
					}
					else
					{
						ans = "0" + ans;
						carry = 1;
					}
				}

				if (binary1[i] == '0' && binary2[i] == '1')
				{
					if (carry == 0)
					{
						ans = "1" + ans;
						carry = 0;
					}
					else
					{
						ans = "0" + ans;
						carry = 1;
					}
				}
				if (binary1[i] == '1' && binary2[i] == '1')
				{
					if (carry == 0)
					{
						ans = "0" + ans;
						carry = 1;
					}
					else
					{
						ans = "1" + ans;
						carry = 1;
					}
				}
			}
			Console.WriteLine(ans+" in add fun");
			if (carry != 0)
				return "2" + ans;
			else
				return ans;
		}
}
}