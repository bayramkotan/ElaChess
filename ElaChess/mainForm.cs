using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElaChess
{
    public partial class MainForm : Form
    {
        public static Graphics g;

        public static bool canWhiteRook0_0;
        public static bool canWhiteRook0_0_0; 
        public static bool canBlackRook0_0;
        public static bool canBlackRook0_0_0;
        public static bool IsWhiteTurn;

        public static bool didWhiteCastle;
        public static bool didBlackCastle;

        public static sbyte[] board1188=new sbyte[64]; //11,12,.....,88
        public static sbyte[] board063 = new sbyte[64]; //0,1,2,....,63



#region board   
        //          board063
        //
        //  56  57  58  59  60  61  62  63
        //  48  49  50  51  52  53  54  55
        //  40  41  42  43  44  45  46  47
        //  32  33  34  35  36  37  38  39
        //  24  25  26  27  28  29  30  31
        //  16  17  18  19  20  21  22  23
        //  08  09  10  11  12  13  14  15
        //  00  01  02  03  04  05  06  07


                //   
        //          board1188
        //
        //  81  82  83  84  85  86  87  88
        //  71  72  73  74  75  76  77  78
        //  61  62  63  64  65  66  67  68
        //  51  52  53  54  55  56  57  58
        //  41  42  43  44  45  46  47  48
        //  31  32  33  34  35  36  37  38
        //  21  22  23  24  25  26  27  28
        //  11  12  13  14  15  16  17  18
        

        // A=1 , B=2 , C=3, D=4, E=5, F=6, G=7, H=8-----> so for example 42=B(2) + 4 (row), 4-->row, 2-->column(B)





        // WP=1             BP=-1       W-->White, B-->Black
        // WN=2             BN=-2       P-->Pawn
        // WB=3             BB=-3       N-->KNight
        // WR=4             BR=-4       B-->Bishop
        // WQ=5             BQ=-5       R-->Rook
        // WK=6             BK=-6       Q-->Queen   K-->King    
#endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            String Msg = "                 Ela Chess\n" +
            "Author : Bayram Kotan\n" +
            "bayramkotan@gmail.com\n" +
            "Website: www.bayramkotan.com";

            MessageBox.Show(Msg, "About", MessageBoxButtons.OK);
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sbyte i;
            //moves.defaultPosition();

           // moves.defaultPosition_WithoutPawns();           // set board without pawns

            moves.samplePosition1();
            for (i = 0; i < 64; i++)
                if(board063[i]!=0)
                listBoxMoves.Items.Add(moves.Value_To_LONGNAME(board063[i]) + " at " + moves.Location_To_Notation(moves.Convert_063_To_1188(i)));

            listBoxMoves.Items.Add("*******************************");
#region
            //MessageBox.Show(moves.Convert_063_To_1188(63).ToString()); //---->88

            //MessageBox.Show(moves.Convert_1188_To_063(88).ToString()); //--->63

            //MessageBox.Show(moves.Location_To_Notation(11)); //-->A1

            //MessageBox.Show(moves.Notation_To_Location("B4").ToString()); //--->24




            //sbyte[] squares = new sbyte[15];
            //sbyte rookslocation = 36;
            //for (i = 0; i < 15; i++)
            //    squares[i] = moves.RookMoves(rookslocation)[i];

            ////Array.Sort(squares);

            //listBoxMoves.Items.Add("the Rook is at " + moves.Location_To_Notation(moves.Convert_063_To_1188(rookslocation)));
            //listBoxMoves.Items.Add("Possible Moves");
            //for (i = 0; i < 15; i++)
            //{
            //    if (squares[i] != 0)
            //    {
            //        listBoxMoves.Items.Add(moves.Location_To_Notation(squares[i]));
            //    }
            //}


            //sbyte[] squares = new sbyte[15];
            //sbyte bishopslocation = 28;
            //for (i = 0; i < 15; i++)
            //    squares[i] = moves.BishopMoves(bishopslocation)[i];

            ////Array.Sort(squares);

            //listBoxMoves.Items.Add("the Bishop is at " + moves.Location_To_Notation(moves.Convert_063_To_1188(bishopslocation)));
            //listBoxMoves.Items.Add("Possible Moves");
            //for (i = 0; i < 15; i++)
            //{
            //    if (squares[i] != 0)
            //    {
            //        listBoxMoves.Items.Add(moves.Location_To_Notation(squares[i]));
            //    }
            //}


            //sbyte[] squares = new sbyte[8];
            //sbyte knightslocation = 22;
            //for (i = 0; i < 8; i++)
            //    squares[i] = moves.KnightMoves(knightslocation)[i];

            ////Array.Sort(squares);

            //listBoxMoves.Items.Add("the Knight is at " + moves.Location_To_Notation(moves.Convert_063_To_1188(knightslocation)));
            //listBoxMoves.Items.Add("Possible Moves");
            //for (i = 0; i < 8; i++)
            //{
            //    if (squares[i] != 0)
            //    {
            //        listBoxMoves.Items.Add(moves.Location_To_Notation(squares[i]));
            //    }
            //}

            #endregion

            sbyte[] squares = new sbyte[4];
            sbyte pawnslocation = 36;
            sbyte type = 1;  // 1 for white, -1 for black
          

            for (i = 0; i < 4; i++)
                squares[i] = moves.PawnMoves(pawnslocation,type)[i]; 
            //Array.Sort(squares);

            listBoxMoves.Items.Add("the " + moves.Value_To_LONGNAME(type).ToString() + " is at " + moves.Location_To_Notation(moves.Convert_063_To_1188(pawnslocation)));
            listBoxMoves.Items.Add("Possible Moves");
            for (i = 0; i < 4; i++)
            {
                if (squares[i] != 0)
                {
                    listBoxMoves.Items.Add(moves.Location_To_Notation(squares[i]));
                }
            }

            listBoxMoves.Items.Add("-----------X----Y-------");

            for (i = 0; i < 64; i++)
            {
                listBoxMoves.Items.Add
                    (moves.Location_To_Notation(moves.Convert_063_To_1188(i)).ToString() + " = (" 
                    + board1188_To_Location_XY(moves.Convert_063_To_1188(i)).X.ToString() + ", " + 
                    board1188_To_Location_XY(moves.Convert_063_To_1188(i)).Y.ToString() + ") ");
            }

        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            newGame frm = new newGame();
            frm.ShowDialog();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            #region
            //int height, width;
            //height = pbBoard.Height;
            //width = pbBoard.Width;

            //int Dx = width / 8;  // width of one cell
            //int Dy = height / 8; //height of one cell


            //int x, y;
            //x = ((e.X - (e.X % Dx)) / Dx) + 1;

            //y = Dy*8 - e.Y;

            //y = ((y - (y % Dy)) / Dy) + 1;


            ////int x, y;
            ////x = ((e.X-(e.X % 80))/80)+1;

            ////y = 640 - e.Y;

            ////y = ((y - (y % 80)) / 80) + 1;  // Bu this board---> Dy=Dx=80

            //this.Text = "X=" + x.ToString() + " Y=" + y.ToString();
            #endregion

            //this.Text = "X=" + findX(e.X).ToString() + " Y=" + findY(e.Y).ToString();
            
            sbyte coord = (sbyte)sendXY(e.X, e.Y);

            if ((coord >= 11) && (coord <= 88))
            {
                this.Text = moves.Location_To_Notation((sbyte)coord).ToString() + " = (" + e.X.ToString() + ", " + e.Y.ToString() + ")";

                sbyte coord063 = moves.Convert_1188_To_063((sbyte)coord);
                if ((coord063 >= 0) && (coord063 <= 63))
                {

                    this.Text += "     " + moves.Value_To_LONGNAME(MainForm.board063[moves.Convert_1188_To_063(coord)]).ToString();
                }
            }

        }

        public int findX(int locationX)
        {
            int width = pbBoard.Width;
            int Dx = width / 8;

            return ((locationX - (locationX % Dx)) / Dx) + 1;
        }


        public int findY(int locationY)
        {
            int height = pbBoard.Height;
            int Dy = height / 8;

            return (((height - locationY) - ((height - locationY) % Dy)) / Dy) + 1;
        }

        public int sendXY(int locationX, int locationY)
        {
            return 10 * findY(locationY) + findX(locationX);  //---> send as board1188 coordination
        }

        
        public Point board1188_To_Location_XY(sbyte location)  //<-----board1188
        {
            sbyte x = Convert.ToSByte(location % 10); // A=1 , B=2 , C=3, D=4, E=5, F=6, G=7, H=8
            sbyte y = Convert.ToSByte((location - x) / 10); //1,2,....,8

            int width = pbBoard.Width;
            int Dx = width / 8;

            int height = pbBoard.Height;
            int Dy = height / 8;

            
            int locationX = x*Dx-(Dx/2);
            int locationY = (9-y)*Dy-(Dy/2);
            
            Point XY = new Point(locationX, locationY);
            
            return XY;
        }
    }
}
