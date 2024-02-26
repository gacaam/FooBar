class Program{
    static void Main()
    {
        FooBar.DeretFooBar(15);
    }
}

public static class FooBar{
	public static string fooBarRow = "0, ";
	public static string fooBarNum = "";
	public static void DeretFooBar(int index){
		for(int i = 1; i < index; i++){
			fooBarRow += NumToFooBar(i) + ", ";
		fooBarRow += NumToFooBar(index);
		}
    }
    public static string NumToFooBar(int num){
        if(num % 3 == 0 && num % 5 != 0){
            fooBarNum = "foo";
        }
        else if(num % 3 != 0 && num % 5 == 0){
            fooBarNum = "bar";
        }
        else if(num % 3 == 0 && num % 5 == 0){
            fooBarNum = "foobar"; 
        }
        else{
            fooBarNum = num.ToString();
        }
        return fooBarNum
    }
	Console.WriteLine(fooBarRow);
}