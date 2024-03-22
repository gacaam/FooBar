namespace FooBar;

public interface IFooBar{
    public string BarisFooBar(int index);
}
public class FooBarMaker : IFooBar{
	public string fooBarRow = "";
	public string fooBarNum = "";
	public string BarisFooBar(int index){
		for(int i = 0; i < index; i++){
			fooBarRow += NumToFooBar(i) + ", ";
		}
		fooBarRow += NumToFooBar(index);
        return fooBarRow;
    }
    public virtual string NumToFooBar(int num){
        string fooBarString = "";
        if(num % 3 == 0 && num != 0){
            fooBarString += "foo";
            if(num % 5 == 0){
                fooBarString += "bar";
            }
        }else if(num % 5 == 0 && num != 0){
            fooBarString += "bar";
        }else{
            fooBarString = num.ToString();
        }
        return fooBarString;
    }
}