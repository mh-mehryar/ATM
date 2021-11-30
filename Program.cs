
MyData.create();
Process p = new Process();

bool c = p.check();
// int show = 0;

// if (c)
// {
//     show = p.showMenu();
    
// }

// else
// {
//     System.Console.WriteLine("Pass is Wrong");
// }
if (c)
{
    p.showMenu();
}
else
{
    System.Console.WriteLine("Lotfan dobare talash konid ...");
}

public class Process : IMyInterface
{
    static double moj = 0;

    public bool check()
    {

        System.Console.WriteLine("Enter Pass :");
        int password = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter BankName :");
        string bName = Console.ReadLine();

        foreach (var item in MyData.listBank)
        {
            if (password == item.pass && bName == item.bankName)
            {
                moj = item.mojodi;
                return true;
            }
        }
        return false;
    }
    private List<Tarakonesh> amaliatBanki = new List<Tarakonesh>();
    public double bardasht()
    {
        Tarakonesh tB = new Tarakonesh();
        System.Console.WriteLine($"Mojoodi shoma dar {DateTime.Now}: mablaghe {moj}");
        System.Console.WriteLine("Mablagh Bardasht ra vered konid :");
        // double b = int.Parse(Console.ReadLine());
        tB.amount = int.Parse(Console.ReadLine());
        tB.date = DateTime.Now;
        tB.amaliat = "Bardasht";
        moj = moj - tB.amount;
        amaliatBanki.Add(tB);
        return moj;
    }
    public double enteghal()
    {
        Tarakonesh tE = new Tarakonesh();
        System.Console.WriteLine($"Mojoodi shoma dar {DateTime.Now}: mablaghe {moj}");
        System.Console.WriteLine("Lotfan mablagh Enteghal ra vared konid :");
        tE.amount = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Shomare karte maghsad ra vared konid :");
        tE.cardNum = Console.ReadLine();
        tE.date = DateTime.Now;
        tE.amaliat = "Enteghal";
        MyData dataBank1 = new MyData();

        foreach (var item in MyData.listBank)
        {
            if (tE.cardNum == item.cardNumber)
            {
                moj = moj - tE.amount;
                amaliatBanki.Add(tE);
            }
            else
            {
                System.Console.WriteLine("Shomare Karte Maghsad eshtebah ast");
            }
        }
        return moj;

    }

    public void mojodi()
    {

        // System.Console.WriteLine($"Mojodi Hesabe shoma : {moj} rial");
        System.Console.WriteLine($"Mojoodi shoma dar {DateTime.Now}: mablaghe {moj}");

    }
    public void changePass()
    {
        Tarakonesh tC = new Tarakonesh();
        System.Console.WriteLine("lotfan Ramze Karte Khod ra vared konid :");
        // int p = int.Parse(Console.ReadLine());
        tC.passT = int.Parse(Console.ReadLine());
        foreach (var item in MyData.listBank)
        {
            if (tC.passT == item.pass)
            {
                System.Console.WriteLine("Ramze jadid ra Vared konid :");
                tC.passT = int.Parse(Console.ReadLine());
                item.pass = tC.passT;
                tC.date = DateTime.Now;
                tC.amaliat = "changePass";
                amaliatBanki.Add(tC);

                System.Console.WriteLine($"tagheer ramz ba movafighat anjam shod,ramze jadide shoma : {item.pass}");
            }
        }
    }

    // public int showMenu()
    public void showMenu()
    {
        
        System.Console.WriteLine("***");
        System.Console.WriteLine("to see Menu press 1");
        int s = int.Parse(Console.ReadLine());
        System.Console.WriteLine("***");
        // return 1;

        
        System.Console.WriteLine(" Enteghal = 1 ; Bardasht = 2 ; Mojoodi = 3 ; Change Pass = 4 ; Log = 5 ; Exit = 0 ");
        int pressedKey = int.Parse(Console.ReadLine());



        if (pressedKey == 1)
        {
            enteghal();
            mojodi();
            showMenu();

        }
        else if (pressedKey == 2)
        {
            bardasht();
            mojodi();
            showMenu();

        }
        else if (pressedKey == 3)
        {
            mojodi();
            showMenu();

        }
        else if (pressedKey == 4)
        {
            changePass();
            showMenu();

        }
        else if (pressedKey == 5)
        {
            log();
        }
        else if (pressedKey == 0)
        {
            System.Console.WriteLine("Karte Khod ra Bardarid ...");
        }

        // }


    }

    public void log()
    {
        System.Console.WriteLine("*** Gozaresh tarakonesh ***");
        foreach (var item in amaliatBanki)
        {
            
            
            System.Console.WriteLine(item.date);

            if (item.amaliat == "changePass")
            {
                System.Console.WriteLine(item.amaliat);
                System.Console.WriteLine(item.passT);
            }
            else if (item.amaliat == "Enteghal")
            {
                System.Console.WriteLine(item.amaliat);
                System.Console.WriteLine(item.amount);
                System.Console.WriteLine(item.cardNum);
            }
            else
            {
                System.Console.WriteLine(item.amaliat);
                System.Console.WriteLine(item.amount);
            }
            System.Console.WriteLine("*************");
        }
        
    }



    public class Tarakonesh
    {
        public double amount;
        public DateTime date;
        public string cardNum;
        public int passT;
        public string amaliat;


    }
}