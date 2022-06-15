using System;
using System.Collections.Generic;
internal class Location
{
    public int[,] Level;
    public int PlayerX, PlayerY;

    public Location(){
        PlayerX = 2;
        PlayerY = 3;
        Level = new int[,] {
            {0,0,0},
            {0,0,0},
            {0,0,0},
            {0,0,0}
        };
    }

    public int Menu()
    {
        //check location
        if(CanMoveNorth()) {
            // display north menu option
        }
        //display directions
        //move character
        return 0;

    }

    private bool CanMoveNorth() {
        return PlayerY != 0;
    }

    private bool CanMoveSouth() {
        return Level.GetLength(1) != PlayerY;
    }

    private bool CanMoveEast() {
        return PlayerY != 0;
    }

    private bool CanMoveWest() {
        return Level.GetLength(1) != PlayerY;
    }

        /*public string Area {get; set;}
        public string Left {get; set;}
        public string Right {get; set;}
        public string Up {get; set;}
        public string Down {get; set;}*/

        
}
