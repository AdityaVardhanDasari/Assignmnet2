namespace Program
{
	
	class Project1
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the First Number");
			float num1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Second Number");
			float num2 = float.Parse(Console.ReadLine());
			
			char sign = '0';
			// if(Math.Abs(num1)<Math.Abs(num2))
			// {
			// 	sign = '1';
			// }
			if(num1<0 && num2<0){
				sign = '1';
			}
			
			
			if(num1<0 && num2>0)
			{
				float temp = num1;
				num1 = num2;
				num2 = temp;
			}
			
			FloatToBin obj = new FloatToBin();
					
			string num1_bin = obj.FloatToBinary(num1);
			string num2_bin = obj.FloatToBinary(num2);
			
			int correction1 = Convert.ToInt32(num1_bin.Substring(1,8),2);
			int correction2 = Convert.ToInt32(num2_bin.Substring(1,8),2);
			
			string binf1 = '1'+num1_bin.Substring(9,23);
			string binf2 = '1'+num2_bin.Substring(9,23);
			
			if (correction1 > correction2)
			{
				int diff = correction1 - correction2;
				for (int i = 0; i < diff; i++)
				{
					binf2 = "0" + binf2;
				}
			}
			else
			{
				int diff = correction2 - correction1;
				for (int i = 0; i < diff; i++)
				{
					binf1 = "0" + binf1;
				}
			}
			
			num1_bin = num1_bin.Substring(0,9)+" "+binf1.Substring(1,23);
			num2_bin = num2_bin.Substring(0,9)+" "+binf2.Substring(1,23);
			
			Console.WriteLine(num1_bin);
			Console.WriteLine(num2_bin);
			
			Compliment com = new Compliment();
			if(num2_bin[0]=='1'){
				
			
			string compli_bin = com.compli(binf2.Substring(0,23));
			binf2 = compli_bin;
			Console.WriteLine(binf2+" comp");
			
			}
			
			// Addition ad = new Addition();
			Console.WriteLine(binf1+" binf1");
			Console.WriteLine(binf2+" binf2");
			string add_bin = Addition.add(binf1.Substring(0,23),binf2);
			Console.WriteLine(add_bin+" addbin");
			
			if(Math.Abs(num2)>=num1)
			{
				// Console.WriteLine(123456);
				add_bin = com.compli(add_bin);
				sign = '1';
			}
			
			string max = Convert.ToString(Math.Max(correction1, correction2),2);
			// Console.WriteLine(max);
			if(max.Length!=8)
			{
				int diffi = 8-max.Length;
				for(int i=0;i<diffi;i++)
				{
					max = '0' + max;
				}
			}
			if(num1>0 && num2>0 && add_bin[0]=='2')
			{
				add_bin = '1' + add_bin.Substring(1);
				int final_exp = Math.Max(correction1, correction2);
				final_exp += 1;
				max = Convert.ToString(final_exp, 2);
				if (max.Length != 8)
				{
					for (int i = 0; i < 8 - max.Length; i++)
					{
						max = '0' + max;
					}
				}
			}
			bool IsZero = true;
			if((num1>0 && num2<0) && (add_bin[0]=='2' || add_bin[0]!='2'))
			{
				Console.WriteLine("hello");
				if(add_bin.Length>23){
				add_bin = add_bin.Substring(1,23);
				}
				
				int index1 = 0;
				
				while (add_bin[index1] == '0' && index1 <= 22)
				{
					//Console.WriteLine(index1);
					index1++;
					add_bin += "0";
				}
				if(index1<22)
				{
					IsZero = false ;
				}
				
				if (add_bin[0] == '0')
				{
					Console.WriteLine(index1 + "g");

					// x1 -= index1;
					//Console.WriteLine(bin1.Substring(index) + "pe");

					add_bin = add_bin.Substring(index1);
					Console.WriteLine(add_bin + "ee");
					
					int final_exp = Math.Max(correction1, correction2);
					Console.WriteLine(correction1+" "+correction2);
					
					final_exp -= index1;
					max = Convert.ToString(final_exp, 2);
					Console.WriteLine(max);
					if (max.Length != 8)
					{
						for (int i = 0; i < 8 - max.Length; i++)
						{
							max = '0' + max;
						}
					}
				}
			}
			
			if(add_bin.Length!=24)
			{
				for(int i=0;i<24-add_bin.Length;i++)
				{
					add_bin+='0';
				}
			}
			
			string forConvert = sign+max+add_bin.Substring(1,23);
			Console.WriteLine(forConvert+" forconvert");
			
			Converter con = new Converter();
			if(IsZero && (sign=='1'))	
			{
				Console.WriteLine(0);
			}
			else
			{
			double answer = con.convert(forConvert);
			Console.WriteLine(answer);
			}
			
			// if()
			
			}			
		}
	}

	
