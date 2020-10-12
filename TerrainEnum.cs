using System;
using System.Collections.Generic;
using System.Collections;

public enum TerrainEnum{
    Grass,
    Sand,
    Water,
    Wall
}




public static class TerrainEnumExtensions{

    public static ConsoleColor GetColor(this TerrainEnum terrain){
        switch(terrain){
            case TerrainEnum.Grass: return ConsoleColor.Green;
            case TerrainEnum.Sand: return ConsoleColor.Yellow;
            case TerrainEnum.Water: return ConsoleColor.Blue;
            default: return ConsoleColor.DarkGray;
        }
    }

    public static char GetChar(this TerrainEnum terrain){
        switch(terrain){
            case TerrainEnum.Grass: return '\u201c';
            case TerrainEnum.Sand: return '\u25cb';
            case TerrainEnum.Water: return '\u2248';
            default: return '\u25cf';
        }
    }








}
