using System;

namespace lab
{
	interface Inter_3
	{
		string Find();
		void TovarRead(Tovar [] arr, int amount);


	}

	class Tovar:Base_3
	{
		
		int count{ get; set;}


		public void TovarRead(Tovar [] arr, int amount)
		{
			foreach (Tovar i in arr) {

				Console.WriteLine ("Input name of item");
				i.Shop_Set(Console.ReadLine());

			}	
			
		}

	}



	class Base_3:Abstr_3{

		 String Shop;

		public void Shop_Set(string inp){
			this.Shop = inp;
		}

		public string Shop_Get(){
			return Shop;
		}
	}


	abstract class Abstr_3{

		public void Find(Tovar [] arr, int amount){

			Console.WriteLine ("Inp your string for search");

			string compare = Console.ReadLine ();

			for (int i = 0; i < amount; i++) {
				
				if (compare == arr[i].Shop_Get()) {

					Console.WriteLine ("Your item is '" + arr[i].Shop_Get() + "' in our list, it's number is " + i);
					break;
				} else {
					Console.WriteLine ("There is not your item in the list");
					break;
				}
			}

		}

	}

	class main{
		public static void Main(){

			Console.WriteLine ("Set the length");
			Tovar [] T = new Tovar[Convert.ToInt32(Console.ReadLine())];
			for (int i = 0; i < T.Length; i++) {
				T [i] = new Tovar ();
			}

			Tovar t = new Tovar ();

			while (true) {

				t.TovarRead (T,T.Length);
				t.Find (T,T.Length);
				break;
			}

		}
	}

}