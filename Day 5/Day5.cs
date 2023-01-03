using System.Collections.Generic;

namespace AdventOfCode2022{

    public static class Day5{

        public static string part1(){
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
            

            foreach (string line in input){ //finds the index of the white space between the two inputs
                if (line == ""){
                    indexofLinebreak = counter;
                    break;
                }
                counter++;
            }

            indexOfColumnNums = indexofLinebreak -1;
            indexOfStartofInstructions = indexofLinebreak +1; 

            for (int x = 0; x < input[indexOfColumnNums].Length -1; x++){
                tempstring = input[indexOfColumnNums][x]; 
                if (tempstring == ' '){ //do nothing
                }
                else {
                    indexOfColumnTemp = x;
                    for(int y = indexOfColumnNums-1; y >= 0; y-- ){
                        tempCrate = input[y][indexOfColumnTemp];
                        if (tempCrate != ' ' && tempCrate != '[' && tempCrate != ']'){
                            tempList.Add(Char.ToString(tempCrate));
                            
                        }
                    }

                    column.Add(new List<string>(tempList));
                    tempList.Clear(); //then clears the temp list to go around again
                    
                }
    
            }     

            // start going through instructions here:

            int lineCount = File.ReadAllLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 5/Input.txt").Count();
            //lineCount = lineCount - 10;
            string numtomove = "";
            string movefrom = "";
            string moveto = "";
            string movingcontainer = "";

            for (int x = indexOfStartofInstructions; x<= lineCount-1; x++){ //loop through all lines
                
                numtomove = Char.ToString(input[x][5]);
                if (Char.IsNumber(input[x][6]) == true){ numtomove = numtomove + Char.ToString(input[x][6]);}

                if(Char.IsNumber(input[x][12]) == true){ movefrom = Char.ToString(input[x][12]);}
                else {movefrom = Char.ToString(input[x][13]);}

                if(Char.IsNumber(input[x][17]) == true){ moveto = Char.ToString(input[x][17]);}
                else {moveto = Char.ToString(input[x][18]);}
                
                Console.WriteLine(numtomove + " " + movefrom + " " + moveto);


                for (int y = 0; y < int.Parse(numtomove); y++ ){
                    movingcontainer = column[int.Parse(movefrom)-1].Last();
                    column[int.Parse(moveto)-1].Add(movingcontainer);
                    column[int.Parse(movefrom)-1].RemoveAt(column[int.Parse(movefrom)-1].Count-1);
                    //Console.WriteLine("moving");
                }

                numtomove = "";
                movefrom = "";
                moveto = "";
            }


            string Answer = "";

            for (int w = 0; w<9; w++){
                if(column[w].Count != 0){
                  Answer = Answer + column[w].Last();  
                }
                
            }
  
            return Answer;
           // foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 4/Input.txt")){}


        }



        public static string part2(){

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
            

            foreach (string line in input){ //finds the index of the white space between the two inputs
                if (line == ""){
                    indexofLinebreak = counter;
                    break;
                }
                counter++;
            }

            indexOfColumnNums = indexofLinebreak -1;
            indexOfStartofInstructions = indexofLinebreak +1; 

            for (int x = 0; x < input[indexOfColumnNums].Length -1; x++){
                tempstring = input[indexOfColumnNums][x]; 
                if (tempstring == ' '){ //do nothing
                }
                else {
                    indexOfColumnTemp = x;
                    for(int y = indexOfColumnNums-1; y >= 0; y-- ){
                        tempCrate = input[y][indexOfColumnTemp];
                        if (tempCrate != ' ' && tempCrate != '[' && tempCrate != ']'){
                            tempList.Add(Char.ToString(tempCrate));
                            
                        }
                    }

                    column.Add(new List<string>(tempList));
                    tempList.Clear(); //then clears the temp list to go around again
                    
                }
    
            }     

            // start going through instructions here:

            int lineCount = File.ReadAllLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 5/Input.txt").Count();
            //lineCount = lineCount - 10;
            string numtomove = "";
            string movefrom = "";
            string moveto = "";
            string movingcontainer = "";


            for (int x = indexOfStartofInstructions; x<= lineCount-1; x++){ //loop through all lines
                
                numtomove = Char.ToString(input[x][5]);
                if (Char.IsNumber(input[x][6]) == true){ numtomove = numtomove + Char.ToString(input[x][6]);}

                if(Char.IsNumber(input[x][12]) == true){ movefrom = Char.ToString(input[x][12]);}
                else {movefrom = Char.ToString(input[x][13]);}

                if(Char.IsNumber(input[x][17]) == true){ moveto = Char.ToString(input[x][17]);}
                else {moveto = Char.ToString(input[x][18]);}
                
                Console.WriteLine(numtomove + " " + movefrom + " " + moveto);


                for (int y = 0; y < int.Parse(numtomove); y++ ){
                    movingcontainer = column[int.Parse(movefrom)-1].Last();
                    tempList.Add(movingcontainer);
                    column[int.Parse(movefrom)-1].RemoveAt(column[int.Parse(movefrom)-1].Count-1);
                    //Console.WriteLine(column[int.Parse(movefrom)-1].Last());
                    //Console.WriteLine(movingcontainer);
                    // Console.WriteLine(column[int.Parse(movefrom)-1].Count);
                    // Console.WriteLine(y);
                    //Console.WriteLine(tempList.Last());
                     Console.WriteLine("testing");
                }
                for (int z = 0; z < int.Parse(numtomove); z++){
                    movingcontainer = tempList.Last();
                    column[int.Parse(moveto)-1].Add(movingcontainer);
                    tempList.RemoveAt(tempList.Count-1);
                   Console.WriteLine("Count is " + tempList.Count);
                }

                


                numtomove = "";
                movefrom = "";
                moveto = "";
            }


            string Answer = "";

            for (int w = 0; w<9; w++){
                if(column[w].Count != 0){
                  Answer = Answer + column[w].Last();  
                }
                
            }
  
            return Answer;
           // foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 4/Input.txt")){}


        }

            





    }


}