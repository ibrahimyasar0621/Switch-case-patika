namespace switch_case;

class Program
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        switch (month)    // parantez içinde expretion yani kontrol etmek istediğim koşulu yazıyoruz . ben hangi ifade üzerinden dallnma yapacağım. mesela burada month üzerinden dallanma yapacağız oyüzden month yazıyoruz
        {
            case 1:            // case lerin sonuna iki nokta: koyuyyoruz , noktalı viirgül ; atmıyoruz. 
            Console.WriteLine("ocak ayındasın");
            break;

            case 2:
            Console.WriteLine("şubat ayındasın");  // bilgisayar hangi ayda ise ona göre sonuç verecek burada yazılı olmayan ay var aise eğer  yada kullanıcı yanlış değer giererse default kıısmı çalışacak. 
            break;

            case 4:
            Console.WriteLine("nisan ayındasın");
            break;

            case 10:
            Console.WriteLine("ekim ayındasın");   // bunu ekim ayında yazdığım için sonuç çıktı kısmında ekimayındasınz yazsı çıktı.
            break;                                 // eğer buradaki 10 yerine farklı bir ay olsaydı yanlış  veri giridiniz yazacaktı çünkü default bloğu çalışmış olacaktı.

            default:     // hiçbir case uymayan ifade olunca yapılacak işlemi ifade ediyor
            Console.WriteLine("yanlış vveri girdiniz");  // biz burada hata almayacağız ama mesela kulllanıcı gidipte 12 a yerine 13. ay 18 falan yazabilir bu sebepler böyle bir şey yazarsa default bloğu devreye girsin istiyoum.
            break;       // hiçbirşey yapmayacaksam direkt birşey demeden break deyip kapatıyoruz. 

        }
        switch (month)
        {

            case 12:
            case 1:
            case 2:

            Console.WriteLine("kış ayındasınız");
            break;

            default:
            break;
        }

    }
}
