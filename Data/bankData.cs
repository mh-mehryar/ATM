public class MyData
{
    public int id;
    public string name;
    public string cardNumber;
    public double mojodi;
    public int pass;
    public string bankName;

    public static List<MyData> listBank = new List<MyData>();

    static int count = 0;

    public static void create()
    {
        MyData dataBank = new MyData();
        dataBank.id = count;
        dataBank.name = "MH Mehryar";
        dataBank.cardNumber = "6104337836540649";
        dataBank.mojodi = 1000000;
        dataBank.pass = 1234;
        dataBank.bankName = "Mellat";

        listBank.Add(dataBank);


        MyData dataBank1 = new MyData();
        dataBank1.id = count;
        dataBank1.name = "Kiana Mehryar";
        dataBank1.cardNumber = "6037997521301412";
        dataBank1.mojodi = 5000000;
        dataBank1.pass = 5648;
        dataBank1.bankName = "Melli";

        listBank.Add(dataBank1);
    }



}