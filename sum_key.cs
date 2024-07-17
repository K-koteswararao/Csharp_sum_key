using System;
class Test{
	static int Key(int n1,int n2,int n3){
		int input1 = Math.Max(Math.Max(Math.Max(n1/1000,(n1/100)%10),(n1/10)%10),n1%10);
		int input2 = Math.Max(Math.Max(Math.Max(n2/1000,(n2/100)%10),(n2/10)%10),n2%10);
		int input3 = Math.Max(Math.Max(Math.Max(n3/1000,(n3/100)%10),(n3/10)%10),n3%10);
		int input11 = Math.Min(Math.Min(Math.Min(n1/1000,(n1/100)%10),(n1/10)%10),n1%10);
		int input22 = Math.Min(Math.Min(Math.Min(n2/1000,(n2/100)%10),(n2/10)%10),n2%10);
		int input33 = Math.Min(Math.Min(Math.Min(n3/1000,(n3/100)%10),(n3/10)%10),n3%10);
		Console.WriteLine("max:"+input1);
		Console.WriteLine("max:"+input2);
		Console.WriteLine("max:"+input3);
		Console.WriteLine("min:"+input11);
		Console.WriteLine("min:"+input22);
		Console.WriteLine("min:"+input33);
		int key = (input11+input22+input33)-(input1 + input2+ input3);
		return key;


	}
	public static void Main(string[] args){
	Console.WriteLine("Enter n1 Value:");
	int n1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter n2 Value:");
	int n2 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter n3 Value:");
	int n3 = Convert.ToInt32(Console.ReadLine());
	int key = Key(n1,n2,n3);
	Console.WriteLine(key);

	}
}