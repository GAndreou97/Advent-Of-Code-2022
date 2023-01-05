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

        public static int part2(){
            string[] input = File.ReadAllLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 6/Input.txt");
            int marker = 0;
            bool dupefound =  false;

            for(int x = 13; x< input[0].Length; x++){
                // for (int y = 1; y < 14; y++) {
                //  if(input[0][x] == input[0][x-y]){dupefound = true;}   
                //  //Console.WriteLine(y); 

                for(int w = 0; w < 13; w++) {
                    for (int y = 1; y < 14-w; y++) {
                        if(input[0][x-w] == input[0][x-w-y]){dupefound = true;}   
                 //Console.WriteLine(y); 
                    }
                }


                if(dupefound == false) {
                    marker = x+1;
                    break;
                }
                else {dupefound = false;}

                }


               


            return marker;



            

        }


    }


}