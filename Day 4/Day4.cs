namespace AdventOfCode2022 
{
    public static class Day4{

        public static int part1(){
            string[] zones = new string[2];
            string[] firstZones = new string[2];
            string[] secondZones = new string[2];
            int numOfOverlaps = 0;

            foreach (string line in System.IO.File.ReadLines(@"/Users/georgeandreou/Documents/GitHub/Advent-Of-Code-2022/Day 4/Input.txt")){
                zones = line.Split(',');
                firstZones = zones[0].Split('-');
                secondZones = zones[1].Split('-');

                if (Int32.Parse(firstZones[0]) >= Int32.Parse(secondZones[0]) && Int32.Parse(firstZones[1]) <= Int32.Parse(secondZones[1]) ){
                    numOfOverlaps = numOfOverlaps +1;
                }
                else if (Int32.Parse(secondZones[0]) >= Int32.Parse(firstZones[0]) && Int32.Parse(secondZones[1]) <= Int32.Parse(firstZones[1]) ){
                    numOfOverlaps = numOfOverlaps +1;
                }


            }

            return numOfOverlaps;

        }




    }
}

//Int32.Parse(line);