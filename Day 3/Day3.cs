namespace AdventOfCode2022
{
    public static class Day3{

        public static int part1() {
            int linelength;
            string[] splitPacks = new string[2];
            string Duplicates = "";
            

            foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 3/Input.txt")){
                linelength = line.Length;
                splitPacks = splitPack(line,linelength);  
                //need to do comparison and build a string


                //then need to run the TotalVal method and return it
                
            }

            return 0;
        }


        public static int TotalVal (String Duplicates){
            int TotalValofItems;


            return 0;
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