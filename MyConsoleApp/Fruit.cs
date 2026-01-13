using System;

public class Fruit {
    public string name;
    public double price;

    public Fruit(string n, double p){
        this.name = n;
        this.price = p;
    }

    public override string ToString()
    {
        return "This tasty " + name + " is only $" + price;
    }
}
