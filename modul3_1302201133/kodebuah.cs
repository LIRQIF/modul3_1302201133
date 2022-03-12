public enum Buah
{
    Apel,
    Aprikot,
    Alpukat,
    Pisang,
    Paprika,
    Blackberry,
    Ceri,
    Kelapa,
    Kurma,
    Jagung,
    Durian,
    Anggur,
    Melon,
    Semangka,
}

public class KodeBuah
{
    public Buah buah;

    public KodeBuah(Buah buah)
    {
        this.buah = buah;
    }

    public String getKodeBuah()
    {
        switch (this.buah)
        {
            case Buah.Apel:
                return "A00";
            case Buah.Aprikot:
                return "B00";
            case Buah.Alpukat:
                return "C00";
            case Buah.Pisang:
                return "D00";
            case Buah.Paprika:
                return "E00";
            case Buah.Blackberry:
                return "F00";
            case Buah.Ceri:
                return "H00";
            case Buah.Kelapa:
                return "I00";
            case Buah.Jagung:
                return "J00";
            case Buah.Kurma:
                return "K00";
            case Buah.Durian:
                return "L00";
            case Buah.Anggur:
                return "M00";
            case Buah.Melon:
                return "N00";
            default:
                return "O00";
        }
    }
}