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
            
            //return input[2][1];

            foreach (string line in input){ //finds the index of the white space between the two inputs
                if (line == ""){
                    indexofLinebreak = counter;
                    break;
                }
                counter++;
            }

            indexOfColumnNums = indexofLinebreak -1;
            indexOfStartofInstructions = indexofLinebreak +1;
            //column[2].Add("what"); Example of how to add to an individual internal list

            //goes through the index line and then moves up building up a temp list which is then applied to the list of lists
             //Console.WriteLine(input[indexOfColumnNums][1]);
            // Console.WriteLine(input[indexOfStartofInstructions]); 
            // Console.WriteLine(input[indexofLinebreak]); 

            for (int x = 0; x < input[indexOfColumnNums].Length -1; x++){
                tempstring = input[indexOfColumnNums][x]; 
                if (tempstring == ' '){ //do nothing
                //Console.WriteLine("Empty");
                //Console.WriteLine(input[indexOfColumnNums][x]);
                }
                else {
                    indexOfColumnTemp = x;
                    //Console.WriteLine(tempstring);
                    //Console.WriteLine(input[indexOfColumnNums][x]);
                    for(int y = indexOfColumnNums-1; y >= 0; y-- ){
                        tempCrate = input[y][indexOfColumnTemp];
                        //Console.WriteLine(input[y][indexOfColumnTemp]);
                        //Console.WriteLine(y);
                        if (tempCrate != ' ' && tempCrate != '[' && tempCrate != ']'){
                            tempList.Add(Char.ToString(tempCrate));
                            //Console.WriteLine(tempList[0]);
                        }
                    }
                    //List<string> tempList2 = new List<string>(tempList);
                    //so its not WORKING BECAUSE OF LIST REFERENCING
                    column.Add(tempList); //built up one column at a time and adding it to main list of lists
                    tempList.Clear(); //then clears the temp list to go around again
                    Console.WriteLine(column[0][0]);
                }
                //x++;
                //Console.WriteLine(x);
            }     



            //return column[0][0];
            return input[1][1];
           // foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 4/Input.txt")){}



        }











    }


}