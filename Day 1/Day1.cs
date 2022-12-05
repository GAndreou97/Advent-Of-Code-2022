namespace AdventOfCode2022 

{
    public static class Day1{
        
        public static int Part1(){

            int CurrVal = 0;
            int MaxVal = 0;

            foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 1/Input.txt"))
            {
              if(line != "") {
                CurrVal = CurrVal + Int32.Parse(line);
              }
              else if(CurrVal > MaxVal){ MaxVal = CurrVal; CurrVal = 0;}
              else {CurrVal = 0;}

            }
            
            return MaxVal;
        }


        public static int Part2(){
            int Top1 = 0;
            int Top2 = 0;
            int Top3 = 0;
            int CurrVal = 0;
            int MaxVal = 0;

            foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 1/Input.txt"))
            {
                if(line != "") {
                    CurrVal = CurrVal + Int32.Parse(line);
                } 
                else if(CurrVal > Top1){
                    Top3 = Top2;
                    Top2 = Top1;
                    Top1 = CurrVal;
                    CurrVal = 0;
                }
                else if (CurrVal > Top2){
                    Top3 = Top2;
                    Top2 = CurrVal;
                    CurrVal = 0;
                }
                else if (CurrVal > Top3){
                    Top3 =  CurrVal;
                    CurrVal = 0;
                }
                else {CurrVal = 0;}  
            }

            MaxVal = Top1 + Top2 + Top3;
            return MaxVal;
        }

    }
}