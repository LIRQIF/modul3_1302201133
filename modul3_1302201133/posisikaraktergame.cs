public enum State
{
    Tengkurap,
    Jongkok,
    Berdiri,
    Terbang,
}

public class PosisiKarakterGame
{
    private State state = State.Berdiri;

    public void tombolS()
    {
        switch (this.state)
        {
            case State.Terbang:
                this.state = State.Berdiri;
                printStatus();
                break;
            case State.Berdiri:
                this.state = State.Jongkok;
                printStatus();
                break;
            case State.Jongkok:
                this.state = State.Tengkurap;
                printStatus();
                break;
        }
    }

    public void tombolW()
    {
        switch (this.state)
        {
            case State.Tengkurap:
                this.state = State.Jongkok;
                printStatus();
                break;
            case State.Jongkok:
                this.state = State.Berdiri;
                printStatus();
                break;
            case State.Berdiri:
                this.state = State.Terbang;
                printStatus();
                break;
        }
    }

    private void printStatus()
    {
        switch (this.state)
        {
            case State.Tengkurap:
                Console.WriteLine("Posisi Istirahat");
                break;
            case State.Jongkok:
                Console.WriteLine("Posisi Landing");
                break;
            case State.Berdiri:
                Console.WriteLine("Posisi Standby");
                break;
            case State.Terbang:
                Console.WriteLine("Posisi Take off");
                break;
        }
    }
}