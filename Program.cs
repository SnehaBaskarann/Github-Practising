// See https://aka.ms/new-console-template for more information

interface IBaseclass{
    public void ShowInterest(); 
    public void ShowDeposit(); 

}

class Derivedclass : IBaseclass
{
    public void ShowDeposit()
    {
        Console.WriteLine("The Deposited amount is 3000");
    }

    public void ShowInterest()
    {
        Console.WriteLine("2% interest");
    }
}

class Program{
     static void Main(string[] args){
        Derivedclass MyClass = new Derivedclass();
        MyClass.ShowDeposit();         
        MyClass.ShowInterest();         

     }

}