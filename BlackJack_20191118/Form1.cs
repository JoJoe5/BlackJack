using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_20191118
{

    public partial class Form1 : Form
    {
        Player Banker = new Player();
        Player P1 = new Player();
        Rule rule = new Rule();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            rule.Shuffle();

            Shuffle_btn.Enabled = false;
            Start_btn.Enabled = true;
            B_add_btn.Enabled = false;
            B_pass_btn.Enabled = false;
            P_add_btn.Enabled = false;
            P_pass_btn.Enabled = false;
        }
        private void AddCard(Player player)
        {
            player.Poker[player.DeckNumber] = rule.PokerNew[count];
            player.Poker_Value[player.DeckNumber] = rule.PokerValue_New[count];
            count++;
            player.Deck_Construct();
        }
        static void TooBig(int _value)      //Over21事件的處理方法 (int _value)引數跟委託的引數一樣
        {
            MessageBox.Show("哈哈~你爆了~");
        }
        private void ShowResult()
        {
            MessageBox.Show(rule.ShowResult(Banker,P1));
            if(count > 42)
            {
                MessageBox.Show("牌不夠了, 請重新洗牌");
                Shuffle_btn.Enabled = true;
                Start_btn.Enabled = false;
            }
            else
            {
                Start_btn.Enabled = true;
            }
        }
        private void P1_Add()
        {
            AddCard(P1);
            P_decklabel.Text = P1.Deck;
            P_value_label.Text = P1.Deck_Value + "點";
            //P1.Over21 += new Over21_event(TooBig);      //P1的Over21事件, 由TooBig方法 來處理
            if (P1.Overload == true)
            {
                MessageBox.Show("你爆了~莊家勝利");

                if (count > 42)
                {
                    MessageBox.Show("牌不夠了, 請重新洗牌");
                    Shuffle_btn.Enabled = true;
                    Start_btn.Enabled = false;
                }
                else
                {
                    Start_btn.Enabled = true;
                    P_add_btn.Enabled = false;
                    P_pass_btn.Enabled = false;
                }
            }
            if (P1.DeckNumber == 5)
                P_add_btn.Enabled = false;

            Counter_label.Text = ("" + count);
        }
        private void Banker_Add(int _Switch)
        {
            switch (_Switch)
            {
                case 1:
                    AddCard(Banker);
                    B_decklabel.Text = Banker.Deck;
                    B_value_label.Text = Banker.Deck_Value + "點";
                    break;
                case 2:
                    while (Banker.Deck_Value < 17)
                    {
                        AddCard(Banker);
                        B_decklabel.Text = Banker.Deck;
                        B_value_label.Text = Banker.Deck_Value + "點";
                        //Banker.Over21 += new Over21_event(TooBig);
                        if (Banker.Overload == true)
                        {
                            MessageBox.Show("莊家爆了~閒家勝利");

                            if (count > 42)
                            {
                                MessageBox.Show("牌不夠了, 請重新洗牌");
                                Shuffle_btn.Enabled = true;
                                Start_btn.Enabled = false;
                            }
                            Start_btn.Enabled = true;

                            return;
                        }
                        if (Banker.DeckNumber == 5)
                            this.ShowResult();
                    }
                    this.ShowResult();
                    break;
            }
            Counter_label.Text = ("" + count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            P1.DeckClear();
            P_decklabel.Text = (P1.Deck);
            Banker.DeckClear();
            B_decklabel.Text = (Banker.Deck);
            Banker_Add(1);
            P1_Add();
            P1_Add();

            Shuffle_btn.Enabled = false;
            Start_btn.Enabled = false;
            P_add_btn.Enabled = true;
            P_pass_btn.Enabled = true;
        }

        private void Shuffle_btn_Click(object sender, EventArgs e)
        {
            rule.Shuffle();
            count = 0;
            P1.DeckClear();
            Banker.DeckClear();

            Counter_label.Text = ("" + count);

            Shuffle_btn.Enabled = false;
            Start_btn.Enabled = true;
            B_add_btn.Enabled = false;
            B_pass_btn.Enabled = false;
            P_add_btn.Enabled = false;
            P_pass_btn.Enabled = false;
        }

        private void P_add_btn_Click(object sender, EventArgs e)
        {
            P1_Add();
        }
        private void P_pass_btn_Click(object sender, EventArgs e)
        {
            P_add_btn.Enabled = false;
            P_pass_btn.Enabled = false;

            Banker_Add(2);
        }
        private void B_add_btn_Click(object sender, EventArgs e)
        {
        }
        private void B_pass_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
