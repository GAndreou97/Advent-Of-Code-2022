namespace AdventOfCode2022
{
    public static class Day2{

        public static int part1(){

            int TotalScore = 0;
            foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 2/Input.txt"))
            {
                if(line[0] == 'A'){
                    if(line[2] == 'X') {TotalScore = TotalScore + 4;}
                    else if(line[2] == 'Y') {TotalScore = TotalScore + 8;}
                    else if(line[2] == 'Z') {TotalScore = TotalScore + 3;}
                }

                if(line[0] == 'B'){
                    if(line[2] == 'X') {TotalScore = TotalScore + 1;}
                    else if(line[2] == 'Y') {TotalScore = TotalScore + 5;}
                    else if(line[2] == 'Z') {TotalScore = TotalScore + 9;}
                }

                if(line[0] == 'C'){
                    if(line[2] == 'X') {TotalScore = TotalScore + 7;}
                    else if(line[2] == 'Y') {TotalScore = TotalScore + 2;}
                    else if(line[2] == 'Z') {TotalScore = TotalScore + 6;}
                }
            }

            return TotalScore;
        }
    }
}

//A & X = Rock
//B & Y = Paper
//C & Z = Scissors
//R = 1, P = 2, S = 3
//Win = 6, Draw = 3, Loss = 0