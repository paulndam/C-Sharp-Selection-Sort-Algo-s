using System;
using System.Collections.Generic;
using System.Collections;



public enum TransportEnum{
    Car,
    Bus,
    Subway,
    Bike,
    Feet
}


// creating an extension method that will return the character and color representing a given mean of transportation

public static class TransportEnumExtension{

    public static char GetChar(this TransportEnum transport){
        switch(transport){
            case TransportEnum.Bike: return 'B';
            case TransportEnum.Bus: return 'U';
            case TransportEnum.Car: return 'C';
            case TransportEnum.Subway: return 'S';
            case TransportEnum.Feet: return 'F';
            default: throw new Exception("Unknown means of transport");

        }

    }

    public static ConsoleColor GetColor(this TransportEnum transport){

        switch(transport){
            case TransportEnum.Bike: return ConsoleColor.Red;
            case TransportEnum.Bus: return ConsoleColor.Yellow;
            case TransportEnum.Car: return ConsoleColor.Magenta;
            case TransportEnum.Subway: return ConsoleColor.Green;
            case TransportEnum.Feet: return ConsoleColor.Blue;
            default: throw new Exception("Unknown Transport");






        }







    }






}