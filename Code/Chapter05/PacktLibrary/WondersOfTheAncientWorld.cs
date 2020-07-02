namespace Packt.Shared
{   
    [System.Flags]    
    public enum WondersOfTheAncientWorld : byte
    {
        None                    =   0b_0000_0000, // 0
        Pyramid                 =   0b_0000_0001, // 1
        HangingGardens          =   0b_0000_0010, // 2
        StatueOfZeus            =   0b_0000_0100, // 4
        TempleOfArt             =   0b_0000_1000, // 8
        LighthouseOfAlexandria  =   0b_0001_0000 // 16
    }
}