namespace AdventOfCode2022
{
    public static class Day6{

        public static int part1(){
            string[] input = File.ReadAllLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 6/Input.txt");
            int marker = 0;
            //Console.WriteLine(input[0][0]); always going to be input[0][x]

            for (int x = 3; x < input[0].Length; x++){
                if(input[0][x] != input[0][x-1] && input[0][x] != input[0][x-2] && input[0][x] != input[0][x-3] && input[0][x-1] != input[0][x-2] && input[0][x-1] != input[0][x-3] && input[0][x-2] != input[0][x-3]){
                    marker = x+1;
                    break;
                }
            }

            return marker;
        }











    }


}