using System;
using System.IO;

namespace lab
{
	class MainClass
	{


		public static void Main (string[] args)
		{

			member m = new member ("");

			StreamWriter write = new StreamWriter ("text.txt"); 
				

			write.WriteLine("sdfsdfsd");
		}



		class member{
		
			string name;

			member()
			{
				name = "Ilya";
			}

		string inp_members(string name)
		{
				Console.WriteLine ("Inp name of member");
				name = Console.ReadLine ();
				return name;
		}
	}
	}
}
