namespace FooBar;

public interface IFooBar{
    public string DeretFooBar(int index);
}
public class FooBarMaker : IFooBar{
	public string fooBarRow = "";
	public string fooBarNum = "";
	public string DeretFooBar(int index){
		for(int i = 0; i < index; i++){
			fooBarRow += NumToFooBar(i) + ", ";
		}
		fooBarRow += NumToFooBar(index);
        return fooBarRow;
    }
    public virtual string NumToFooBar(int num){
        if(num % 3 == 0 && num % 5 != 0){
            fooBarNum = "foo";
        }
        else if(num % 3 != 0 && num % 5 == 0){
            fooBarNum = "bar";
        }
        else if(num % 3 == 0 && num % 5 == 0 && num != 0){
            fooBarNum = "foobar"; 
        }
        else{
            fooBarNum = num.ToString();
        }
        return fooBarNum;
    }
}