using Program;
namespace Program{
class Compliment
{
	public string compli(string binf)
	{

			string final = string.Empty;
			for(int i=0;i<binf.Length;i++)
			{
				if(binf[i]=='1')
					final = final+'0';
					
				else
					final = final+'1';
			}
			
			string forComp = "1";
			for(int i=0;i<22;i++)
			{
				forComp = "0"+ forComp;
			}
			
			final = Addition.add(final,forComp);
			return final;
		}
	}
}
