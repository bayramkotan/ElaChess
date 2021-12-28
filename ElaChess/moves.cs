using System;
using System.Collections.Generic;
using System.Text;

namespace ElaChess
{
    class moves
    {
        public static void defaultPosition()
        {
          
            for(sbyte i=8;i<16;i++)
            {
                MainForm.board063[i]=1; // White Pawns
                MainForm.board063[i+40]=-1; // Black Pawns
            }

            MainForm.board063[0] = MainForm.board063[7] = 4; //White Rooks
            MainForm.board063[56] = MainForm.board063[63] = -4; //Black Rooks

            MainForm.board063[1] = MainForm.board063[6] = 2; //White Knights
            MainForm.board063[57] = MainForm.board063[62] = -2; //Black Knights

            MainForm.board063[2] = MainForm.board063[5] = 3; //White Bishops
            MainForm.board063[58] = MainForm.board063[61] = -3; //Black Bishops

            MainForm.board063[3] = 5; //White Queen
            MainForm.board063[59] = -5; //Black Queen

            MainForm.board063[4] = 6; //White King
            MainForm.board063[60] = -6; //Black King


        }

        public static void defaultPosition_WithoutPawns()
        {

            //for (sbyte i = 8; i < 16; i++)
            //{
            //    MainForm.board063[i] = 1; // White Pawns
            //    MainForm.board063[i + 40] = -1; // Black Pawns
            //}

            MainForm.board063[0] = MainForm.board063[7] = 4; //White Rooks
            MainForm.board063[56] = MainForm.board063[63] = -4; //Black Rooks

            MainForm.board063[1] = MainForm.board063[6] = 2; //White Knights
            MainForm.board063[57] = MainForm.board063[62] = -2; //Black Knights

            MainForm.board063[2] = MainForm.board063[5] = 3; //White Bishops
            MainForm.board063[58] = MainForm.board063[61] = -3; //Black Bishops

            MainForm.board063[3] = 5; //White Queen
            MainForm.board063[59] = -5; //Black Queen

            MainForm.board063[4] = 6; //White King
            MainForm.board063[60] = -6; //Black King


        }

        public static void samplePosition1()
        {

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

            //          Sample 
            //
            //  00  -6  -4  00  00  00  00  -4
            //  -1  -1  -1  -5  00  00  -1  -1
            //  00  00  00  -1  -1  -2  00  00
            //  00  00  00  00  +1  00  00  00
            //  00  00  00  00  00  00  00  00
            //  00  +5  +1  00  00  +1  00  00
            //  +1  +1  00  00  00  +2  +1  +1
            //  00  +6  +4  00  00  00  00  +4

            for (sbyte i = 0; i < 64; i++)
            {
                MainForm.board063[i] = 0; // Reset Table
            }

            MainForm.board063[01] = 6; // White King
            MainForm.board063[02] = 4; // White Rook
            MainForm.board063[17] = 5; // White Queen
            MainForm.board063[07] = 4; // White Rook
            MainForm.board063[13] = 2; // White Knight


            MainForm.board063[57] = -6; // Black King
            MainForm.board063[58] = -4; // Black Rook
            MainForm.board063[51] = -5; // Black Queen
            MainForm.board063[63] = -4; // Black Rook
            MainForm.board063[45] = -2; // Black Knight

            // White Pawns
            MainForm.board063[08] = 1; 
            MainForm.board063[09] = 1; 
            MainForm.board063[18] = 1; 
            MainForm.board063[21] = 1; 
            MainForm.board063[14] = 1;
            MainForm.board063[15] = 1;
            MainForm.board063[36] = 1;

            // Black Pawns
            MainForm.board063[48] = -1;
            MainForm.board063[49] = -1;
            MainForm.board063[50] = -1;
            MainForm.board063[43] = -1;
            MainForm.board063[54] = -1;
            MainForm.board063[55] = -1;
            MainForm.board063[44] = -1; 
        }

        public static sbyte Convert_1188_To_063(sbyte location)
        {
            sbyte newLocation, unitsDigit, tensDigit;
            unitsDigit = Convert.ToSByte(location % 10);
            tensDigit = Convert.ToSByte((location - unitsDigit) / 10);
            unitsDigit--;
            tensDigit--;
            newLocation =Convert.ToSByte( tensDigit * 8 + unitsDigit);
            return newLocation;
        }

        public static sbyte Convert_063_To_1188(sbyte location)
        {
            sbyte newLocation,unitsDigit,tensDigit;
            unitsDigit = Convert.ToSByte(location % 8);
            tensDigit = Convert.ToSByte((location - unitsDigit) / 8);
            unitsDigit++;
            tensDigit++;
            newLocation = Convert.ToSByte(tensDigit * 10 + unitsDigit);
            return newLocation;

        }

        public static string Location_To_Notation(sbyte location)  //<----Board1188
        {
            sbyte column =Convert.ToSByte( location % 10); // A=1 , B=2 , C=3, D=4, E=5, F=6, G=7, H=8
            sbyte row = Convert.ToSByte((location - column)/10); //1,2,....,8
            
            string notation="";

            switch (column)
            {
                case 1: notation = "A"; break; case 2: notation = "B"; break; case 3: notation = "C"; break;
                case 4: notation = "D"; break; case 5: notation = "E"; break; case 6: notation = "F"; break;
                case 7: notation = "G"; break; case 8: notation = "H"; break;

            }
            notation += row.ToString();
            return notation;
        }

        public static sbyte Notation_To_Location(string notation)  //---->Board1188
        {
            sbyte row, column, location;
            column=Convert.ToSByte(notation.Substring(1,1));
            notation=notation.Substring(0,1);
            row = 0;
            switch (notation)
            {
                case "A": row=1;break; case "B":row=2;break; case "C":row=3;break; case "D":row=4; break;

                case "E": row=5;break; case "F":row=6;break; case "G":row=7;break; case "H":row=8; break;

            }

            row = Convert.ToSByte(row);
            location = Convert.ToSByte(10 * row + column);
            return location;
        }

        public static string Value_To_Type(sbyte value)
        {
            string type="";

            switch(value)
            {
                case 0: type = "NT"; break; // NOTHING, EMPTY
                case 1: type="WP"; break; case (-1): type="BP"; break; // PAWN
                case 2: type="WN"; break; case (-2): type="BN"; break; // KNIGHT
                case 3: type="WB"; break; case (-3): type="BB"; break; // BISHOP
                case 4: type="WR"; break; case (-4): type="BR"; break; // ROOK
                case 5: type="WQ"; break; case (-5): type="BQ"; break; // QUEEN
                case 6: type="WK"; break; case (-6): type="BK"; break; // KING

            }
            return type;
        }

        public static string Value_To_SHORTNAME(sbyte value)
        {
            string shortname = "";

            switch (Math.Abs(value))
            {
                case 0: shortname = "NOTHING"; break;
                case 1: shortname = "PAWN"; break;
                case 2: shortname = "KNIGHT"; break;
                case 3: shortname = "BISHOP"; break;
                case 4: shortname = "ROOK"; break;
                case 5: shortname = "QUEEN"; break;
                case 6: shortname = "KING"; break; 
            }
            return shortname;
        }

        public static string Value_To_LONGNAME(sbyte value)
        {
            string longname = "";

            switch (value)
            {
                case 0: longname = "NOTHING"; break;

                case 1: longname = "WHITE PAWN"; break;
                case 2: longname = "WHITE KNIGHT"; break;
                case 3: longname = "WHITE BISHOP"; break;
                case 4: longname = "WHITE ROOK"; break;
                case 5: longname = "WHITE QUEEN"; break;
                case 6: longname = "WHITE KING"; break;

                case -1: longname = "BLACK PAWN"; break;
                case -2: longname = "BLACK KNIGHT"; break;
                case -3: longname = "BLACK BISHOP"; break;
                case -4: longname = "BLACK ROOK"; break;
                case -5: longname = "BLACK QUEEN"; break;
                case -6: longname = "BLACK KING"; break;
            }
            return longname;
        }

        public static sbyte Type_To_Value(string type)
        {
            sbyte value = 0;

            switch(type)
            {
                case "NT": value = 0; break; //NOTHING, EMPTY
                case "WP" : value=1; break; case "BP": value=-1 ; break; // PAWN
                case "WN" : value=2; break; case "BN": value=-2; break; // KNIGHT
                case "WB" : value=3; break; case "BB": value=-3; break; // BISHOP
                case "WR" : value=4; break; case "BR": value=-4; break; // ROOK
                case "WQ" : value=5; break; case "BQ": value=-5; break; // QUEEN
                case "WK" : value=6; break; case "BK": value=-6; break; // KING
            }

            return value;
        }


        /**************FIND UNITS AND TENS **************************/

        public static sbyte findUnitsDigit(sbyte location)
        {
           return(Convert.ToSByte(location % 10));                         //---> Units Digit

        }

        public static sbyte findTensDigits(sbyte location, sbyte unitsDigit)
        {
           return( Convert.ToSByte((location - unitsDigit) / 10));           //----> Tens Digit
        }

        /**********************************************************/



        public static sbyte[] PawnMoves(sbyte location, sbyte type)//<-----Pawns' possible movies// white-->1 black-->-1
        {
            sbyte[] locations = { 0, 0, 0, 0 }; //    /  2 forward + 2 take ---- (2 x en passant)

            sbyte temp, counter, tempUnitsDigits, tempTenDigits;
            location = Convert_063_To_1188(location);  //<-----063 To 1188
            counter = 0;

                temp = location;
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);
                if (((type == 1) && (tempTenDigits == 8)) || ((type == -1) && (tempTenDigits == 1)))
                    goto exit;

                /// go forward 1 square ///

                temp += (sbyte)(type * 10); // go forward +-9 +-10 +-11

             if((temp>=11)&&(temp<=88))
             {
                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 up
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }
             }
                /// go forward 2 square ///
            
                temp = location;
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                if (((type == 1) && (tempTenDigits == 2)) || ((type == -1) && (tempTenDigits == 7)))
                {

                    temp += (sbyte)(type * 20); // go forward 2 square

                    if ((temp >= 11) && (temp <= 88))
                    {
                        if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 up
                        {
                            locations[counter] = temp;  // save all possible locations in an array "locations"
                            counter++;                  // index of locations[]
                        }
                    }
                }
                /// go diagonal 1 square to NORTHWEST and to NORTHEAST ///

                

                /// go forward 1 square ///
                for (sbyte i = 9; i <12; i += 2)
                {
                    temp = location;
                    temp += (sbyte)(type * i); // go forward +-9 +-10 +-11
                    if ((temp >= 11) && (temp <= 88))
                    {
                    
                      sbyte value=MainForm.board063[Convert_1188_To_063(temp)];

                    if (value != 0)
                    {
                        if (((Math.Abs(value)) / value) == (sbyte)((-1) * type))  // If it is NOT empty square! if its occupied with opponent pieces.
                        {
                            locations[counter] = temp;  // save all possible locations in an array "locations"
                            counter++;                  // index of locations[]
                        }
                    }
                    }
                }

            exit:
            return locations;
        }

        public static sbyte[] KnightMoves(sbyte location)//<-----Knights' possible movies
        {
            sbyte[] locations = { 0, 0, 0, 0, 0, 0, 0, 0 }; // 14+1=15, the last one for exit

            sbyte unitsDigit, tensDigit, temp, counter, tempTenDigits, tempUnitsDigits;
            location = Convert_063_To_1188(location);  //<-----063 To 1188

            unitsDigit = findUnitsDigit(location);                         //---> Units Digit
            tensDigit = findTensDigits(location, unitsDigit);              //----> Tens Digit


            counter = 0;
            sbyte i,j;

            /*************** CHECK HORIZONTAL (4 places) *******************************/

            for (j = -1; j < 2; j += 2)
            {
                for (i = 8; i < 13; i += 4)
                {
                    temp = location;
                    temp += (sbyte)(j*i);
                    tempUnitsDigits = findUnitsDigit(temp);
                    tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                    if ((tempTenDigits != 9) && (tempTenDigits != 0) && (tempUnitsDigits != 9) && (tempUnitsDigits != 0) && (temp > 10) && (temp < 89))
                    {
                        if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 up
                        {
                            locations[counter] = temp;  // save all possible locations in an array "locations"
                            counter++;                  // index of locations[]
                        }
                    }

                }
            }

            /*************** CHECK VERTICAL (4 places)*******************************/

            for (j = -1; j < 2; j += 2)
            {
                for (i = 19; i < 22; i += 2)
                {
                    temp = location;
                    temp += (sbyte)(j * i);
                    tempUnitsDigits = findUnitsDigit(temp);
                    tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                    if ((tempTenDigits != 9) && (tempTenDigits != 0) && (tempUnitsDigits != 9) && (tempUnitsDigits != 0) && (temp > 10) && (temp < 89))
                    {
                        if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 up
                        {
                            locations[counter] = temp;  // save all possible locations in an array "locations"
                            counter++;                  // index of locations[]
                        }
                    }

                }
            }
                return locations;
            
        }

        public static sbyte[] BishopMoves(sbyte location) //<-----Bishos's possible movies
        {
            sbyte[] locations = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 14+1=15, the last one for exit

            sbyte unitsDigit, tensDigit, temp, counter, tempTenDigits, tempUnitsDigits;
            location = Convert_063_To_1188(location);  //<-----063 To 1188

            unitsDigit = findUnitsDigit(location);                         //---> Units Digit
            tensDigit = findTensDigits(location, unitsDigit);              //----> Tens Digit


            counter = 0;
        

        

            /*******************  MOVE NORTHEAST (NE)  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while ((tempTenDigits < 8)&&(tempUnitsDigits < 8))
            {
                temp += 11;   //--->NE
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);


                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 up
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }

            }


            /*******************  MOVE SOUTHEAST (SE)  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while ((tempTenDigits > 1) && (tempUnitsDigits > 1))
            {
                temp -= 11;   //--->SE
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then decrease -1 down
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }

            }


            /*******************  MOVE NORTHWEST  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while ((tempTenDigits < 8) && (tempUnitsDigits > 1))
            {
                temp += 9;   //--->NW
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 right
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }

            }

            /*******************  MOVE SOUTHEAST  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while ((tempTenDigits > 1) && (tempUnitsDigits < 8))
            {
                temp -= 9;   //--->SE
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then decrease -1 left
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }

            }
            /// 
            /******************************************/


          

            return locations;
        }

        public static sbyte[] RookMoves(sbyte location) //<-----Rooks' possible movies
        {
            sbyte[] locations = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}; // 14+1=15, the last one for exit

            sbyte unitsDigit, tensDigit, temp, counter, tempTenDigits, tempUnitsDigits;
            location = Convert_063_To_1188(location);  //<-----063 To 1188

            unitsDigit = findUnitsDigit(location);                         //---> Units Digit
            tensDigit = findTensDigits(location,unitsDigit);              //----> Tens Digit
            
            
            counter = 0;

            //temp = location;
            //tempTenDigits = tensDigit;
            //tempUnitsDigits = unitsDigit;

 
            //sbyte i,j;

            //for (j = -1; j < 2; j += 2)
            //{
            //    for (i = 1; i < 11; i += 9)
            //    {
            //        temp = location;
            //        tempTenDigits = tensDigit;
            //        tempUnitsDigits = unitsDigit;

            //        while((tempTenDigits < 8) && (tempTenDigits > 1) && (tempUnitsDigits > 1) && (tempUnitsDigits < 8) )
            //        {

            //            temp += (sbyte)(i*j);   //--->All
            //            tempUnitsDigits = findUnitsDigit(temp);
            //            tempTenDigits = findTensDigits(temp, tempUnitsDigits);


            //                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square 
            //                {
            //                    locations[counter] = temp;  // save all possible locations in an array "locations"
            //                    counter++;                  // index of locations[]
            //                }
                        
            //        }
            //    }
            //}

            #region

            /*******************  MOVE UP  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while (tempTenDigits < 8)
            {
                temp += 10;   //--->UP
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);


                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 up
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }
                else
                    break;
            }


            /*******************  MOVE DOWN  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while (tempTenDigits > 1)
            {
                temp -= 10;   //--->DOWN
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then decrease -1 down
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }
                else
                    break;

            }


            /*******************  MOVE RIGHT  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while (tempUnitsDigits < 8)
            {
                temp += 1;   //--->RIGHT
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then increase +1 right
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }
                else
                    break;

            }

            /*******************  MOVE LEFT  ***********************/

            temp = location;
            tempTenDigits = tensDigit;
            tempUnitsDigits = unitsDigit;

            while (tempUnitsDigits > 1)
            {
                temp -= 1;   //--->LEFT
                tempUnitsDigits = findUnitsDigit(temp);
                tempTenDigits = findTensDigits(temp, tempUnitsDigits);

                if (MainForm.board063[Convert_1188_To_063(temp)] == 0)  // If it is empty square then decrease -1 left
                {
                    locations[counter] = temp;  // save all possible locations in an array "locations"
                    counter++;                  // index of locations[]
                }
                else
                    break;
            }
            /// 
            /******************************************/
            

            #endregion

            return locations;
        }

        public static sbyte[] QueenMoves(sbyte location)//<-----Queen's possible movies
        {
            sbyte[] locations = new sbyte[14]; //
            // RookMoves + Bishop Moves
            return locations;
        }

        public static sbyte[] KingMoves(sbyte location) //<-----King's possible movies
        {
            sbyte[] locations = new sbyte[8]; //
            return locations;
        }
    }
}

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