using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Unity Example
        IUnityContainer u = new UnityContainer();
        u.RegisterType<Iservice, service>();
        var res = u.Resolve<Mathcls>();
        res.show();

        // Singleton
        var ob = Singleton.GetInstance;
        ob.Method();

        // Factory Pattern
        var ob2 = factory.GetInstance(3);
        var result = ob2.ShowData();
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        // Prototype
        Class1 obp = new Class1();
        obp.p1 = 100;
        obp.p2 = 200;
        Console.WriteLine(obp.p1);
        Console.WriteLine(obp.p2);
        Console.WriteLine("====================");
        Class1 obp2 = (Class1)obp.Clone();
        obp2.p2 = 500;
        Console.WriteLine(obp2.p1);
        Console.WriteLine(obp2.p2);
        Console.WriteLine("==================");
        Console.WriteLine(obp.p1);
        Console.WriteLine(obp.p2);

        // Adapter
        IPrinter p = new ModernPrinter();
        p.Print("hello world");
        LegacyPrinter o = new LegacyPrinter();
        IPrinter p2 = new LegacyPrinterAdapter(o);
        p2.Print("good afternoon");

        // Observer
        NotificationService notificationService = new NotificationService();
        User user1 = new User("Apporv");
        User user2 = new User("Prince");
        User user3 = new User("Rathan");
        User user4 = new User("Satish");
        notificationService.Subscribe(user1);
        notificationService.Subscribe(user2);
        notificationService.Subscribe(user3);
        notificationService.Subscribe(user4);
        notificationService.NotifyObservers("Hello Students Happy Week end!");
        Console.WriteLine("=================");
        notificationService.Unsubscribe(user4);
        notificationService.NotifyObservers("Have a Great Day!!!");

        // Facade
        facedpattern obf = new facedpattern();
        obf.buyproduct();

        // Template
        books obj = new onlinedelivary();
        obj.ProcessData();
        Console.WriteLine("==================");
        obj = new physicaldevlivary();
        obj.ProcessData();
    }
}

// ================= UNITY MOCK =================

public interface IUnityContainer
{
    void RegisterType<T1, T2>();
    T Resolve<T>();
}

public class UnityContainer : IUnityContainer
{
    public void RegisterType<T1, T2>() { }
    public T Resolve<T>() { return Activator.CreateInstance<T>(); }
}

public interface Iservice { }
public class service : Iservice { }

public class Mathcls
{
    public void show() { Console.WriteLine("Math class show method"); }
}

// ================= SINGLETON =================

internal sealed class Singleton
{
    private Singleton() { }
    static Singleton s = null;
    public static Singleton GetInstance
    {
        get
        {
            if (s == null)
            {
                s = new Singleton();
                return s;
            }
            else
            {
                return s;
            }
        }
    }
    public void Method()
    {
        Console.WriteLine("database code triiggered");
    }
}

// ================= FACTORY =================

interface Mydb
{
    string[] ShowData();
}

internal class Sqldata : Mydb
{
    public string[] ShowData()
    {
        string[] data = { "india", "canada", "uk" };
        return data;
    }
}

internal class oracledata : Mydb
{
    public string[] ShowData()
    {
        string[] data = { "CKS", "RCB", "SRH" };
        return data;
    }
}

internal class mysqldata : Mydb
{
    public string[] ShowData()
    {
        string[] data = { "red", "blue", "green" };
        return data;
    }
}

class factory
{
    public static Mydb GetInstance(int i)
    {
        if (i == 1)
        {
            return new Sqldata();
        }
        if (i == 2)
        {
            return new oracledata();
        }
        else
        {
            return new mysqldata();
        }
    }
}

// ================= PROTOTYPE =================

internal class Class1
{
    public int p1 { get; set; }
    public int p2 { get; set; }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

// ================= ADAPTER =================

public class LegacyPrinter
{
    public void OldPrint(string text)
    {
        Console.WriteLine($"Legacy Printer printing (old way): {text}");
    }
}

public interface IPrinter
{
    void Print(string text);
}

public class ModernPrinter : IPrinter
{
    public void Print(string text)
    {
        Console.WriteLine($"Modern Printer printing: {text}");
    }
}

public class LegacyPrinterAdapter : IPrinter
{
    private readonly LegacyPrinter legacyPrinter;
    public LegacyPrinterAdapter(LegacyPrinter legacyPrinter)
    {
        this.legacyPrinter = legacyPrinter;
    }
    public void Print(string text)
    {
        legacyPrinter.OldPrint(text);
    }
}

// ================= OBSERVER =================

public interface IObserver
{
    void Update(string message);
}

public class User : IObserver
{
    private string _name;
    public User(string name)
    {
        _name = name;
    }
    public void Update(string message)
    {
        Console.WriteLine($"{_name} received update: {message}");
    }
}

public class NotificationService
{
    private List<IObserver> _observers = new List<IObserver>();
    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }
    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}

// ================= FACADE =================

internal class login
{
    public void checkuser()
    {
        Console.WriteLine("login method called");
    }
}

internal class product
{
    public void addtocart()
    {
        Console.WriteLine("item is added to cart");
    }
}

internal class makepayment
{
    public void processpayment()
    {
        Console.WriteLine("payment is processing");
    }
}

internal class sendmail
{
    public void mailtouser()
    {
        Console.WriteLine("send email to user");
    }
}

class facedpattern
{
    login l;
    product p;
    makepayment m;
    sendmail s;
    public facedpattern()
    {
        l = new login();
        p = new product();
        m = new makepayment();
        s = new sendmail();
    }
    public void buyproduct()
    {
        l.checkuser();
        p.addtocart();
        m.processpayment();
        s.mailtouser();
    }
}

// ================= TEMPLATE =================

internal abstract class books
{
    public void ProcessData()
    {
        selectbook();
        makepayment();
        deliver();
    }
    public abstract void selectbook();
    public abstract void makepayment();
    public abstract void deliver();
}

class onlinedelivary : books
{
    public override void selectbook()
    {
        Console.WriteLine("selecting book");
    }
    public override void makepayment()
    {
        Console.WriteLine("making payment via internet bank");
    }
    public override void deliver()
    {
        Console.WriteLine("send a book link to user");
    }
}

class physicaldevlivary : books
{
    public override void selectbook()
    {
        Console.WriteLine("selecting book");
    }
    public override void makepayment()
    {
        Console.WriteLine("making payment via UPI");
    }
    public override void deliver()
    {
        Console.WriteLine("send a physical book to actual address");
    }
}

