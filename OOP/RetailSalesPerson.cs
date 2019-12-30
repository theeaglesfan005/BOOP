using System;

public class RetailSalesPerson : Salesman, SelfDeveloping
{
    public RetailSalesPerson(string firstname, string lastName) : base(firstname, lastName)
    {
    }

    public void Develop()
    {
        Console.WriteLine("I develop myself by watching retail sales training videos.");
    }

    protected override void Engage()
    {
        Console.WriteLine("Hello");
    }

    protected override void EstablishTrust()
    {
        Console.WriteLine("I just wanted to quickly help you.");
    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Everything is 80% discounted!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our customers love it.");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this pen.");
    }
}