public class KodeBuah
{
    public enum namaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }

    public static string getKodeBuah(namaBuah Buah)
    {
        string[] KodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00", };
        return KodeBuah[(int)Buah];
    }

    public class PosisiKarakterGame
    {
        public enum State
        {
            Tengkurap, Jongkok, Berdiri, Terbang
        }


        public static void Main()
        {
            Console.WriteLine("Nama Buah" + KodeBuah.namaBuah.Pisang + " Kode Buah " + KodeBuah.getKodeBuah(KodeBuah.namaBuah.Pisang));

            State Kondisi = State.Tengkurap;
            Console.WriteLine("kondisi sekarang sedang : " + Kondisi);
            string Perintah;
            while (Kondisi == State.Tengkurap)
            {
                Perintah = Console.ReadLine();
                if (Perintah == "Tombol W")
                {
                    Kondisi = State.Berdiri;
                    Console.WriteLine("Kondisi sekarang sedang : " + Kondisi);
                    while(Kondisi == State.Berdiri)
                    {
                        Perintah = Console.ReadLine();
                    if (Perintah == "Tombol W")
                        {
                            Kondisi = State.Terbang;
                            Console.WriteLine("kondisi sekarang sedang : " + Kondisi);
                          
                            while (Kondisi == State.Terbang)
                            {
                                Perintah = Console.ReadLine();
                                if(Perintah == "Tombol S")
                                {
                                    Kondisi = State.Berdiri;
                                    Console.WriteLine("Kondisi sekarang sedang : " + Kondisi);
                                    Console.WriteLine("Tombol arah bawah ditekan");
                                }
                                else if(Perintah == "Tombol X")
                                {
                                    Kondisi = State.Jongkok;
                                    Console.WriteLine("Kondisi sekarang sedang : " + Kondisi);
                                }
                            }
                        }
                        else if (Perintah == "Tombol S")
                        {
                            Kondisi = State.Jongkok;
                            Console.WriteLine("kondisi sekarang sedang :" + Kondisi);
                        }
                    }

                }
            }
        }
    }
}
