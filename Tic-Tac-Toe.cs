using System;
namespace StarterPorgram
{
    static class First
    {
        static public char FirstAigolAoAix;
        static public char Bot;

        static public void FirstOperate()
        {
            Random randomization = new Random();
            string? AigolAoAix;
            char[,] AixAigolBoard = new char[3, 3];
            for (int CountingIis = 0; CountingIis < 3; CountingIis++)
            {
                for (int CountingIis2 = 0; CountingIis2 < 3; CountingIis2++)
                {
                    AixAigolBoard[CountingIis, CountingIis2] = 'E';
                }
            }
            char[,] NotAgain = new char[3, 3];
            for (int CountingIs = 0; CountingIs < 3; CountingIs++)
            {
                for (int Counting2 = 0; Counting2 < 3; Counting2++)
                {
                    NotAgain[CountingIs, Counting2] = '0';
                }
            }
            Console.WriteLine("Please decide if you want to play Aix or Aigol");
            char Always = '0';
            char Looping = '0';
            char WinOrLost = '0';
            char Tie = '0';
            char OnlyAtFirstMovePlayer = '0';
            char Stop = '0';
            char FixingSomething = '0';
            char SaveTie = '0';
            int RandomBeginner = randomization.Next(2);
            while (Always == '0')
            {
                while (Looping == '0')
                {
                    AigolAoAix = Console.ReadLine();
                    if (AigolAoAix == "Aix")
                    {
                        Console.WriteLine("You have decided to pick Aix");
                        Console.WriteLine("The computer will now choose if you or the Bot starts..");
                        if (RandomBeginner == 0)
                        {
                            Console.WriteLine("You, the player was chosen to be first");
                        }
                        if (RandomBeginner == 1)
                        {
                            Console.WriteLine("The bot was chosen to be first");
                        }
                        Console.WriteLine("Please put respond in the format of" + " X, Y");
                        Looping = '1';
                        First.FirstAigolAoAix = 'X';
                        First.Bot = 'O';
                    }
                    if (AigolAoAix == "Aigol")
                    {
                        Console.WriteLine("You have decided to pick Aigol");
                        Console.WriteLine("The computer will now choose if you or the Bot starts..");
                        if (RandomBeginner == 0)
                        {
                            Console.WriteLine("You, the player was chosen to be first");
                        }
                        if (RandomBeginner == 1)
                        {
                            Console.WriteLine("The bot was chosen to be first");
                        }
                        Console.WriteLine("Please put respond in the format of" + " X, Y");
                        Looping = '1';
                        First.FirstAigolAoAix = 'O';
                        First.Bot = 'X';
                    }
                    if (Looping == '0')
                    {
                        Console.WriteLine("there is an Error please try again");
                    }
                }
                    char WinOrLoseButNotTie = '0';
                    if (AixAigolBoard[0, 0] == 'X' && AixAigolBoard[0, 1] == 'X' && AixAigolBoard[0, 2] == 'X' || AixAigolBoard[1, 0] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[1, 2] == 'X' || AixAigolBoard[2, 0] == 'X' && AixAigolBoard[2, 1] == 'X' && AixAigolBoard[2, 2] == 'X' || AixAigolBoard[0, 0] == 'X' && AixAigolBoard[1, 0] == 'X' && AixAigolBoard[2, 0] == 'X' || AixAigolBoard[0, 1] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[2, 1] == 'X' || AixAigolBoard[0, 2] == 'X' && AixAigolBoard[1, 2] == 'X' && AixAigolBoard[2, 2] == 'X' || AixAigolBoard[0, 0] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[2, 2] == 'X' || AixAigolBoard[2, 0] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[0, 2] == 'X' || AixAigolBoard[0, 0] == 'O' && AixAigolBoard[0, 1] == 'O' && AixAigolBoard[0, 2] == 'O' || AixAigolBoard[1, 0] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[1, 2] == 'O' || AixAigolBoard[2, 0] == 'O' && AixAigolBoard[2, 1] == 'O' && AixAigolBoard[2, 2] == 'O' || AixAigolBoard[0, 0] == 'O' && AixAigolBoard[1, 0] == 'O' && AixAigolBoard[2, 0] == 'O' || AixAigolBoard[0, 1] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[2, 1] == 'O' || AixAigolBoard[0, 2] == 'O' && AixAigolBoard[1, 2] == 'O' && AixAigolBoard[2, 2] == 'O' || AixAigolBoard[0, 0] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[2, 2] == 'O' || AixAigolBoard[2, 0] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[0, 2] == 'O')
                    {
                       WinOrLoseButNotTie = '1'; 
                    }
                    if (First.FirstAigolAoAix == 'X' && RandomBeginner == 0 && SaveTie == '0' && WinOrLoseButNotTie == '0' || First.FirstAigolAoAix == 'O' && RandomBeginner == 0 && SaveTie == '0' && WinOrLoseButNotTie == '0')
                    {
                        if (OnlyAtFirstMovePlayer == '0')
                        {
                            Console.WriteLine("--E represent empty--");
                            for (int Count = 0; Count < 3; Count++)
                            {
                                for (int Count2 = 0; Count2 < 3; Count2++)
                                {
                                    if (Count2 == 0)
                                    {
                                        Console.Write("       " + AixAigolBoard[Count, Count2]);
                                    }
                                    if (Count2 != 0 && Count2 != 2)
                                    {
                                        Console.Write(" " + AixAigolBoard[Count, Count2]);
                                    }
                                    if (Count2 == 2)
                                    {
                                        Console.WriteLine(" " + AixAigolBoard[Count, Count2]);
                                    }
                                    if (Count2 > 2)
                                    {
                                        Count2 = 0;
                                    }
                                } 
                            }
                        }
                        SaveTie = '0';
                        OnlyAtFirstMovePlayer = '1';
                        int Loops = 1;
                        while (Loops == 1 && RandomBeginner == 0)
                        {
                            char Correction = First.FirstAigolAoAix;
                            string? Input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(Input) && Input.Length == 4 && Input[1] == ',' && Input[2] == ' ' && Char.IsDigit(Input, 0) == true && Char.IsDigit(Input, 3) == true)
                            {
                                char INPUT1 = Input[0];
                                char INPUT2 = Input[1];
                                char INPUT3 = Input[2];
                                char INPUT4 = Input[3];
                                int Correcting = Convert.ToInt16(INPUT4) - 49;
                                int Correcting2 = Convert.ToInt16(INPUT1) - 49;
                                if (Correcting + 1 < 4 && Correcting + 1 > 0 && Correcting2 + 1 < 4 && Correcting2 + 1 > 0)
                                {
                                    if (Correcting == 1)
                                    {
                                        if (NotAgain[Correcting, Correcting2] == '0')
                                        {
                                            NotAgain[Correcting, Correcting2] = '1';
                                            AixAigolBoard[Correcting, Correcting2] = Correction;
                                            Loops = 0;
                                            RandomBeginner = 1;
                                            Console.WriteLine("--E represent empty--");
                                            for (int Count = 0; Count < 3; Count++)
                                            {
                                                for (int Count2 = 0; Count2 < 3; Count2++)
                                                {
                                                    if (Count2 == 0)
                                                    {
                                                        Console.Write("       " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 != 0 && Count2 != 2)
                                                    {
                                                        Console.Write(" " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 == 2)
                                                    {
                                                        Console.WriteLine(" " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 > 2)
                                                    {
                                                        Count2 = 0;
                                                    }
                                                } 
                                            }
                                            Console.WriteLine("");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Spot is already taken");
                                        }
                                    }
                                    if (Correcting > 1)
                                    {
                                        if (NotAgain[Correcting - 2, Correcting2] == '0')
                                        {
                                            NotAgain[Correcting - 2, Correcting2] = '1';
                                            AixAigolBoard[Correcting - 2, Correcting2] = Correction;
                                            Loops = 0;
                                            Console.WriteLine("--E represent empty--");
                                            for (int Count = 0; Count < 3; Count++)
                                            {
                                                for (int Count2 = 0; Count2 < 3; Count2++)
                                                {
                                                    if (Count2 == 0)
                                                    {
                                                        Console.Write("       " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 != 0 && Count2 != 2)
                                                    {
                                                        Console.Write(" " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 == 2)
                                                    {
                                                        Console.WriteLine(" " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 > 2)
                                                    {
                                                        Count2 = 0;
                                                    }
                                                } 
                                            }
                                            Console.WriteLine("");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Spot is already taken");
                                        }
                                    }
                                    if (Correcting < 1)
                                    {
                                        if (NotAgain[Correcting + 2, Correcting2] == '0')
                                        {
                                            NotAgain[Correcting + 2, Correcting2] = '1';
                                            AixAigolBoard[Correcting + 2, Correcting2] = Correction;
                                            Loops = 0;
                                            RandomBeginner = 1;
                                            Console.WriteLine("--E represent empty--");
                                            for (int Count = 0; Count < 3; Count++)
                                            {
                                                for (int Count2 = 0; Count2 < 3; Count2++)
                                                {
                                                    if (Count2 == 0)
                                                    {
                                                        Console.Write("       " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 != 0 && Count2 != 2)
                                                    {
                                                        Console.Write(" " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 == 2)
                                                    {
                                                        Console.WriteLine(" " + AixAigolBoard[Count, Count2]);
                                                    }
                                                    if (Count2 > 2)
                                                    {
                                                        Count2 = 0;
                                                    }
                                                } 
                                            }
                                            Console.WriteLine("");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Spot is already taken");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect X coordinate");
                                }
                            }
                            else
                            {
                                Console.WriteLine("An error has occured please try again");
                            }
                        }
                    }
                    RandomBeginner = 1;
                    FixingSomething = '1';
                    int REMOVEDLATER = 0;
                    if (RandomBeginner == 1 && Stop == '0')
                    {
                        Tie = '0';
                        for (int counts = 0; counts < 3; counts++)
                        {
                            for (int counts2 = 0; counts2 < 3; counts2++)
                            {
                                if (AixAigolBoard[counts, counts2] != 'E')
                                {
                                    REMOVEDLATER++;
                                }
                                if (REMOVEDLATER == 9)
                                {
                                    Tie = '1';
                                }
                            }
                        }
                    REMOVEDLATER = 0;
                    if (Tie == '1')
                    {
                        SaveTie = '1';
                    }
                    RandomBeginner = 0;
                        int Shora = randomization.Next(3);
                        int Tor = randomization.Next(3);
                        if (AixAigolBoard[0, 0] == 'X' && AixAigolBoard[0, 1] == 'X' && AixAigolBoard[0, 2] == 'X' || AixAigolBoard[1, 0] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[1, 2] == 'X' || AixAigolBoard[2, 0] == 'X' && AixAigolBoard[2, 1] == 'X' && AixAigolBoard[2, 2] == 'X' || AixAigolBoard[0, 0] == 'X' && AixAigolBoard[1, 0] == 'X' && AixAigolBoard[2, 0] == 'X' || AixAigolBoard[0, 1] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[2, 1] == 'X' || AixAigolBoard[0, 2] == 'X' && AixAigolBoard[1, 2] == 'X' && AixAigolBoard[2, 2] == 'X' || AixAigolBoard[0, 0] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[2, 2] == 'X' || AixAigolBoard[2, 0] == 'X' && AixAigolBoard[1, 1] == 'X' && AixAigolBoard[0, 2] == 'X' || AixAigolBoard[0, 0] == 'O' && AixAigolBoard[0, 1] == 'O' && AixAigolBoard[0, 2] == 'O' || AixAigolBoard[1, 0] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[1, 2] == 'O' || AixAigolBoard[2, 0] == 'O' && AixAigolBoard[2, 1] == 'O' && AixAigolBoard[2, 2] == 'O' || AixAigolBoard[0, 0] == 'O' && AixAigolBoard[1, 0] == 'O' && AixAigolBoard[2, 0] == 'O' || AixAigolBoard[0, 1] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[2, 1] == 'O' || AixAigolBoard[0, 2] == 'O' && AixAigolBoard[1, 2] == 'O' && AixAigolBoard[2, 2] == 'O' || AixAigolBoard[0, 0] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[2, 2] == 'O' || AixAigolBoard[2, 0] == 'O' && AixAigolBoard[1, 1] == 'O' && AixAigolBoard[0, 2] == 'O' || Tie == '1') 
                        {
                            string? LineLength = null;
                            if (AixAigolBoard[0, 0] == First.FirstAigolAoAix && AixAigolBoard[0, 1] == First.FirstAigolAoAix && AixAigolBoard[0, 2] == First.FirstAigolAoAix || AixAigolBoard[1, 0] == First.FirstAigolAoAix && AixAigolBoard[1, 1] == First.FirstAigolAoAix && AixAigolBoard[1, 2] == First.FirstAigolAoAix || AixAigolBoard[2, 0] == First.FirstAigolAoAix && AixAigolBoard[2, 1] == First.FirstAigolAoAix && AixAigolBoard[2, 2] == First.FirstAigolAoAix || AixAigolBoard[0, 0] == First.FirstAigolAoAix && AixAigolBoard[1, 0] == First.FirstAigolAoAix && AixAigolBoard[2, 0] == First.FirstAigolAoAix || AixAigolBoard[0, 1] == First.FirstAigolAoAix && AixAigolBoard[1, 1] == First.FirstAigolAoAix && AixAigolBoard[2, 1] == First.FirstAigolAoAix || AixAigolBoard[0, 2] == First.FirstAigolAoAix && AixAigolBoard[1, 2] == First.FirstAigolAoAix && AixAigolBoard[2, 2] == First.FirstAigolAoAix || AixAigolBoard[0, 0] == First.FirstAigolAoAix && AixAigolBoard[1, 1] == First.FirstAigolAoAix && AixAigolBoard[2, 2] == First.FirstAigolAoAix || AixAigolBoard[2, 0] == First.FirstAigolAoAix && AixAigolBoard[1, 1] == First.FirstAigolAoAix && AixAigolBoard[0, 2] == First.FirstAigolAoAix)
                            {
                                Console.WriteLine("You had won");
                                LineLength = "-----------";
                                WinOrLost = '1';
                            }
                            if (AixAigolBoard[0, 0] == First.Bot && AixAigolBoard[0, 1] == First.Bot && AixAigolBoard[0, 2] == First.Bot || AixAigolBoard[1, 0] == First.Bot && AixAigolBoard[1, 1] == First.Bot && AixAigolBoard[1, 2] == First.Bot || AixAigolBoard[2, 0] == First.Bot && AixAigolBoard[2, 1] == First.Bot && AixAigolBoard[2, 2] == First.Bot || AixAigolBoard[0, 0] == First.Bot && AixAigolBoard[1, 0] == First.Bot && AixAigolBoard[2, 0] == First.Bot || AixAigolBoard[0, 1] == First.Bot && AixAigolBoard[1, 1] == First.Bot && AixAigolBoard[2, 1] == First.Bot || AixAigolBoard[0, 2] == First.Bot && AixAigolBoard[1, 2] == First.Bot && AixAigolBoard[2, 2] == First.Bot || AixAigolBoard[0, 0] == First.Bot && AixAigolBoard[1, 1] == First.Bot && AixAigolBoard[2, 2] == First.Bot || AixAigolBoard[2, 0] == First.Bot && AixAigolBoard[1, 1] == First.Bot && AixAigolBoard[0, 2] == First.Bot)
                            {
                                Console.WriteLine("You had lost");
                                LineLength = "------------";
                                WinOrLost = '1';
                            }
                            if (Tie == '1' && WinOrLost == '0')
                            {
                                Console.WriteLine("Its a tie");
                                LineLength = "---------";
                            }
                            Console.WriteLine(LineLength);
                            Console.WriteLine("Game has ended");
                            Console.WriteLine("--------------");
                            Console.WriteLine("Would you like to play again?");
                            string? YesOrNo = null;
                            while (YesOrNo != "Yes")
                            {
                                YesOrNo = Console.ReadLine();
                                if (YesOrNo == "No")
                                {
                                    return;
                                }
                                if (YesOrNo != "Yes")
                                {
                                    Console.WriteLine("An error has occured please try again");
                                }
                            }
                            Looping = '0';
                            OnlyAtFirstMovePlayer = '0';
                            WinOrLost  = '0';
                            Tie = '0';
                            SaveTie = '0';
                            RandomBeginner = randomization.Next(2);
                            while (Looping == '0')
                            {
                                Console.WriteLine("Please decide if you want to play Aix or Aigol");
                                AigolAoAix = Console.ReadLine();
                                if (AigolAoAix == "Aix")
                                {
                                    Console.WriteLine("You have decided to pick Aix");
                                    Console.WriteLine("The computer will now choose if you or the Bot starts..");
                                    if (RandomBeginner == 0)
                                    {
                                        FixingSomething = '0';
                                        Console.WriteLine("You, the player was chosen to be first");
                                    }
                                    if (RandomBeginner == 1)
                                    {
                                        FixingSomething = '1';
                                        Console.WriteLine("The bot was chosen to be first");
                                    }
                                    Console.WriteLine("Please put respond in the format of" + " X, Y");
                                    Looping = '1';
                                    First.FirstAigolAoAix = 'X';
                                    First.Bot = 'O';
                                }
                                if (AigolAoAix == "Aigol")
                                {
                                    Console.WriteLine("You have decided to pick Aigol");
                                    Console.WriteLine("The computer will now choose if you or the Bot starts..");
                                    if (RandomBeginner == 0)
                                    {
                                        FixingSomething = '0';
                                        Console.WriteLine("You, the player was chosen to be first");
                                    }
                                    if (RandomBeginner == 1)
                                    {
                                        FixingSomething = '1';
                                        Console.WriteLine("The bot was chosen to be first");
                                    }
                                    Console.WriteLine("Please put respond in the format of" + " X, Y");
                                    Looping = '1';
                                    First.FirstAigolAoAix = 'O';
                                    First.Bot = 'X';
                                }
                                if (Looping == 0)
                                {
                                    Console.WriteLine("there is an Error please try again");
                                }
                            }
                            for (int Counting = 0; Counting < 3; Counting++)
                            {
                                for (int Counting2 = 0; Counting2 < 3; Counting2++)
                                {
                                    AixAigolBoard[Counting, Counting2] = 'E';
                                    NotAgain[Counting, Counting2] = '0';
                                }
                            }
                        }
                        if (FixingSomething == '1')
                        {
                            if (NotAgain[Tor, Shora] == '0')
                            {
                                AixAigolBoard[Tor, Shora] = First.Bot;
                                NotAgain[Tor, Shora] = '1';
                            }
                            else
                            {
                                while (NotAgain[Tor, Shora] != '0')
                                {
                                    Tor = randomization.Next(3);
                                    Shora = randomization.Next(3);
                                }
                                AixAigolBoard[Tor, Shora] = First.Bot;
                                NotAgain[Tor, Shora] = '1';
                            }
                            Console.WriteLine("--E represent empty--");
                            for (int Count = 0; Count < 3; Count++)
                            {
                                for (int Count2 = 0; Count2 < 3; Count2++)
                                {
                                    if (Count2 == 0)
                                    {
                                        Console.Write("       " + AixAigolBoard[Count, Count2]);
                                    }
                                    if (Count2 != 0 && Count2 != 2)
                                    {
                                        Console.Write(" " + AixAigolBoard[Count, Count2]);
                                    }
                                    if (Count2 == 2)
                                    {
                                        Console.WriteLine(" " + AixAigolBoard[Count, Count2]);
                                    }
                                    if (Count2 > 2)
                                    {
                                        Count2 = 0;
                                    }
                                } 
                            }
                            if (Tor > 1)
                            {
                                Tor = 0;
                            }
                            if (Tor < 1)
                            {
                                Tor = 2;
                            }
                            Console.WriteLine(Convert.ToString(Shora + 1) + ", " + Convert.ToString(Tor + 1) + " (Bot)");
                            Console.WriteLine("");
                            OnlyAtFirstMovePlayer = '1';
                        }
                    }
                    Tie = '0';
                    for (int counts = 0; counts < 3; counts++)
                    {
                        for (int counts2 = 0; counts2 < 3; counts2++)
                        {
                            if (AixAigolBoard[counts, counts2] != 'E')
                            {
                                REMOVEDLATER++;
                            }
                            if (REMOVEDLATER == 9)
                            {
                                Tie = '1';
                            }
                        }
                    }
                    REMOVEDLATER = 0;
                    if (Tie == '1')
                    {
                        SaveTie = '1';
                    }
                    RandomBeginner = 0;
                }
            }
        static void Main(string[] args)
        {   
            First.FirstOperate();
        }
    }
}
