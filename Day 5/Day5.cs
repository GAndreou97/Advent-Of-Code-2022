using System.Collections.Generic;

namespace AdventOfCode2022{

    public static class Day5{

        public static char part1(){
            List<List<string>> column = new List<List<string>>(); //an outer list containing individual lists for each column
            int indexofLinebreak = 0;
            int counter = 0;
            int indexOfColumnNums = 0;
            int indexOfStartofInstructions = 0;
            char tempstring = ' ';
            List<string> tempList = new List<string>();
            int indexOfColumnTemp = 0;
            char tempCrate = ' ';
            string[] input = File.ReadAllLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 5/Input.txt");
            
            //return input[1][1];

            foreach (string line in input){ //finds the index of the white space between the two inputs
                counter++;
                if (line == ""){
                    indexofLinebreak = counter;
                    break;
                }
            }

            indexOfColumnNums = indexofLinebreak -1;
            indexOfStartofInstructions = indexofLinebreak +1;

            //column[2].Add("what"); Example of how to add to an individual internal list

            //goes through the index line and then moves up building up a temp list which is then applied to the list of lists
            for (int x = 0; x < input[indexOfColumnNums].Length -1; x++){
                tempstring = input[indexOfColumnNums][x]; 
                if (tempstring == ' '){ //do nothing
                }
                else {
                    indexOfColumnTemp = x;
                    for(int y = indexOfColumnNums-1; y > 0; y-- ){
                        tempCrate = input[y][indexOfColumnTemp];
                        if (tempCrate != ' ' && tempCrate != '[' && tempCrate != ']'){
                            tempList.Add(Char.ToString(tempCrate));
                        }
                    }
                    column.Add(tempList); //built up one column at a time and adding it to main list of lists
                    tempList.Clear(); //then clears the temp list to go around again

                }
                x++;
            }     



            //return input[0][0];

           // foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 4/Input.txt")){}



        }











    }


}