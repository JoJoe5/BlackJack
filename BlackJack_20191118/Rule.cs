using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_20191118
{
    //delegate void Over21_event(int _value); //委託事件 -> 超過21點
    class Rule
    {
        string[] Color = new string[] { "♠", "♥", "♦", "♣" };
        string[] Number = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        //string[,] Poker = new string[4, 13];
        public string[] PokerNew = new string[52];
        int[] PokerValue = new int[13] { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };  //A2345678910JQK的點數
        public int[] PokerValue_New = new int[52];  //每次洗牌後點數暫存的地方, 跟隨著PokerNew的編號, 因為牌面是string, 點數是int, 所以分開存
        public int count = 0;     //PokerNew的編號

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int a, b;
                a = random.Next(0, 4);
                b = random.Next(0, 13);
                PokerNew[i] = Color[a]+Number[b];
                PokerValue_New[i] = PokerValue[b];
                for (int j = 0; j < i; j++)
                {
                    while (PokerNew[j] == PokerNew[i])
                    {
                        //如果發到重複的牌就重新取亂數, 直到52張牌都沒重複為止
                        j = 0;
                        a = random.Next(0, 4);
                        b = random.Next(0, 13);
                        PokerNew[i] = Color[a] + Number[b];
                        PokerValue_New[i] = PokerValue[b];
                    }
                }
            }
        }

        //public void AddPoker(string Poker, int Poker_Value, int count)
        //{
        //    Poker = this.PokerNew[count];
        //    Poker_Value = this.PokerValue_New[count];
        //}

        public string ShowResult(Player B, Player P)
        {
            if (P.DeckNumber == 5)
            {
                if (B.DeckNumber == 5)
                {
                    if (B.Deck_Value > P.Deck_Value)
                        return "莊家贏了";
                    else if (B.Deck_Value == P.Deck_Value)
                        return "平局";
                    else
                        return "閒家贏了";
                }
                else
                    return "閒家贏了";
            }
            else if (P.Deck_Value == 21)
            {
                if (B.DeckNumber == 5)
                    return "莊家贏了";
                else if (B.Deck_Value == 21)
                    return "平局";
                else
                    return "閒家贏了";
            }
            else
            {
                if (B.DeckNumber == 5)
                    return "莊家贏了";
                else if (B.Deck_Value == 21)
                    return "莊家贏了";
                else if (B.Deck_Value > P.Deck_Value)
                    return "莊家贏了";
                else if (B.Deck_Value == P.Deck_Value)
                    return "平局";
                else
                    return "閒家贏了";
            }
        }
    }
    class Player
    {
        public string[] Poker = new string[5];
        public string Deck;
        public int[] Poker_Value = new int[5];
        public int Deck_Value = 0;
        public int DeckNumber = 0;
        private int Money = 1000;
        public bool Overload = false;
        //public event Over21_event Over21;
        public void Deck_Construct()
        {
            Deck += Poker[DeckNumber] + "\n";
            Deck_Value += Poker_Value[DeckNumber];
            if (Deck_Value > 21)
            {
                for (int i = 0; i < 5; i++)
                {
                    //當手上有A時, 預設當作11點, 當點數超過21點時, A就當作1點
                    //但Deck_Value為累加的值, 所以將A當作1點之後再重新把所有點數累加一次
                    if (Poker_Value[i] == 11)
                    {
                        if (Deck_Value > 21)
                        {
                            Poker_Value[i] = 1;
                            Deck_Value = 0;
                            for (int j = 0; j < 5; j++)
                                Deck_Value += Poker_Value[j];
                        }
                        else
                        {
                            Deck_Value = 0;
                            for (int j = 0; j < 5; j++)
                                Deck_Value += Poker_Value[j];
                        }
                    }
                }
                if (Deck_Value > 21)
                {
                    //if (Over21 != null) Over21(Deck_Value);
                    Overload = true;
                }
                    
            }
            else
                Overload = false;

            DeckNumber++;
        }
        public void DeckClear()
        {
            this.DeckNumber = 0;
            this.Deck = null;
            this.Deck_Value = 0;
        }
        public int GetMoney
        {
            get { return Money; }
            set
            {
                if (Money < 0)
                    Money = 0;
                else
                    Money = value;
            }
        }
        public int Bet(int bet)
        {
            return bet;
        }
        public void Earn(int earn)
        {
            Money += earn;
        }
        public void Pay(int pay)
        {
            Money -= pay;
        }
    }
}
