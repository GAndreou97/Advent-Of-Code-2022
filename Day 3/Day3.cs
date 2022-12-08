namespace AdventOfCode2022
{
    public static class Day3{

        public static int part1() {
            int linelength;
            string[] splitPacks = new string[2];
            string Duplicates = "";
            string allDupes = "";
            int priorityScore = 0;
            

            foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 3/Input.txt")){
                linelength = line.Length;
                splitPacks = splitPack(line,linelength);  
                //need to do comparison and build a string

                for (int x = 0; x < splitPacks[0].Length; x++){
                    for (int y = 0; y < splitPacks[1].Length; y++){
                        if (splitPacks[0][x] == splitPacks[1][y]) {
                            if (Duplicates.Contains(splitPacks[0][x])){
                                //if it contains it then do nothing
                            }
                            else{Duplicates = Duplicates + splitPacks[0][x];}

                        }

                    }
                }

                //put them into the permanent memory and wipe the temp duplicate one for the next line
                allDupes = allDupes + Duplicates;
                Duplicates = "";
                
            }

            //then need to run the TotalVal method and return it
            priorityScore = TotalVal(allDupes);

            return priorityScore;
        }


        public static int TotalVal (String DuplicateList){
            int TotalValofItems=0;

            for (int x = 0; x<DuplicateList.Length; x++){
                switch(DuplicateList[x]){
                    case 'a':
                        TotalValofItems = TotalValofItems + 1;
                        break;
                    case 'b':
                        TotalValofItems = TotalValofItems + 2;
                        break;
                    case 'c':
                        TotalValofItems = TotalValofItems + 3;
                        break;
                    case 'd':
                        TotalValofItems = TotalValofItems + 4;
                        break;
                    case 'e':
                        TotalValofItems = TotalValofItems + 5;
                        break;
                    case 'f':
                        TotalValofItems = TotalValofItems + 6;
                        break;
                    case 'g':
                        TotalValofItems = TotalValofItems + 7;
                        break;
                    case 'h':
                        TotalValofItems = TotalValofItems + 8;
                        break;
                    case 'i':
                        TotalValofItems = TotalValofItems + 9;
                        break;
                    case 'j':
                        TotalValofItems = TotalValofItems + 10;
                        break;
                    case 'k':
                        TotalValofItems = TotalValofItems + 11;
                        break;
                    case 'l':
                        TotalValofItems = TotalValofItems + 12;
                        break;
                    case 'm':
                        TotalValofItems = TotalValofItems + 13;
                        break;
                    case 'n':
                        TotalValofItems = TotalValofItems + 14;
                        break;
                    case 'o':
                        TotalValofItems = TotalValofItems + 15;
                        break;
                    case 'p':
                        TotalValofItems = TotalValofItems + 16;
                        break;
                    case 'q':
                        TotalValofItems = TotalValofItems + 17;
                        break;
                    case 'r':
                        TotalValofItems = TotalValofItems + 18;
                        break;
                    case 's':
                        TotalValofItems = TotalValofItems + 19;
                        break;
                    case 't':
                        TotalValofItems = TotalValofItems +20;
                        break;
                    case 'u':
                        TotalValofItems = TotalValofItems + 21;
                        break;
                    case 'v':
                        TotalValofItems = TotalValofItems + 22;
                        break;
                    case 'w':
                        TotalValofItems = TotalValofItems + 23;
                        break;
                    case 'x':
                        TotalValofItems = TotalValofItems + 24;
                        break;
                    case 'y':
                        TotalValofItems = TotalValofItems + 25;
                        break;
                    case 'z':
                        TotalValofItems = TotalValofItems + 26;
                        break;
                    case 'A':
                        TotalValofItems = TotalValofItems + 27;
                        break;
                    case 'B':
                        TotalValofItems = TotalValofItems + 28;
                        break;
                    case 'C':
                        TotalValofItems = TotalValofItems + 29;
                        break;
                    case 'D':
                        TotalValofItems = TotalValofItems + 30;
                        break;
                    case 'E':
                        TotalValofItems = TotalValofItems + 31;
                        break;
                    case 'F':
                        TotalValofItems = TotalValofItems + 32;
                        break;
                    case 'G':
                        TotalValofItems = TotalValofItems + 33;
                        break;
                    case 'H':
                        TotalValofItems = TotalValofItems + 34;
                        break;
                    case 'I':
                        TotalValofItems = TotalValofItems + 35;
                        break;
                    case 'J':
                        TotalValofItems = TotalValofItems + 36;
                        break;
                    case 'K':
                        TotalValofItems = TotalValofItems + 37;
                        break;
                    case 'L':
                        TotalValofItems = TotalValofItems + 38;
                        break;
                    case 'M':
                        TotalValofItems = TotalValofItems + 39;
                        break;
                    case 'N':
                        TotalValofItems = TotalValofItems + 40;
                        break;
                    case 'O':
                        TotalValofItems = TotalValofItems + 41;
                        break;
                    case 'P':
                        TotalValofItems = TotalValofItems + 42;
                        break;
                    case 'Q':
                        TotalValofItems = TotalValofItems + 43;
                        break;
                    case 'R':
                        TotalValofItems = TotalValofItems + 44;
                        break;
                    case 'S':
                        TotalValofItems = TotalValofItems + 45;
                        break;
                    case 'T':
                        TotalValofItems = TotalValofItems +46;
                        break;
                    case 'U':
                        TotalValofItems = TotalValofItems + 47;
                        break;
                    case 'V':
                        TotalValofItems = TotalValofItems + 48;
                        break;
                    case 'W':
                        TotalValofItems = TotalValofItems + 49;
                        break;
                    case 'X':
                        TotalValofItems = TotalValofItems + 50;
                        break;
                    case 'Y':
                        TotalValofItems = TotalValofItems + 51;
                        break;
                    case 'Z':
                        TotalValofItems = TotalValofItems + 52;
                        break;


                }
            }

            return TotalValofItems;
        }

        public static string[] splitPack (String line, int length){
            string[] splitPacks = new string[2];
            string tempWord ="";

            for (int x=0;x<length/2;x++){
                tempWord = tempWord + line[x];
            }
            splitPacks[0] = tempWord;
            tempWord = "";

            for (int x=length/2;x<length;x++){
                tempWord = tempWord + line[x];
            }
            splitPacks[1] = tempWord;

            return splitPacks;
        }

    }

}