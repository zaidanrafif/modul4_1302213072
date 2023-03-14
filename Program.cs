public class KodeBuah
{
    public enum namaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }

    public static string getKodeBuah(namaBuah Buah)
    {
        string[] KodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00", };
        return KodeBuah[(int)Buah];
    }

    public static void Main()
    {
        Console.WriteLine("Nama Buah" + KodeBuah.namaBuah.Pisang + " Kode Buah " + KodeBuah.getKodeBuah(KodeBuah.namaBuah.Pisang));
    }
}