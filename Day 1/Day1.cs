namespace AdventOfCode2022 

{
    public static class Day1{
        
        public static int test(){

            int CurrVal = 0;
            int MaxVal = 0;

            foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 1/Input.txt"))
            {
              //Console.WriteLine(line);  
              if(line != "") {
                CurrVal = CurrVal + Int32.Parse(line);
              }
              else if(CurrVal > MaxVal){ MaxVal = CurrVal; CurrVal = 0;}
              else {CurrVal = 0;}

            }
            
            return MaxVal;
        }
    }
}