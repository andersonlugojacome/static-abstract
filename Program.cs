// See https://aka.ms/new-console-template for more information

using System.Numerics;
var val1 = Sumaa<int>(1, 2);
var val2 = Sumaa<double>(1, 2);
Console.WriteLine(val1);
Console.WriteLine(val2);

//static int sum(int a, int b) => a + b;
static K Sumaa<K>(K a, K b) where K : INumber<K> {
    return a + b;
}

Console.WriteLine("Hello, World! I really like this new feature!"); 
//var pet = Pet.Create();
//System.Console.WriteLine((Guid)pet);
public interface ICreatable<T> where T : ICreatable<T>{
    Guid Id { get; }
    static abstract T Create();
    static abstract implicit operator Guid(T t);
}

public class Pet : ICreatable<Pet> {
    public Guid Id { get; } = Guid.NewGuid();
    private Pet(){}
    public static Pet Create(){
        return new Pet();
    }
    public static implicit operator Guid(Pet p){
       return p.Id;
    }
}

