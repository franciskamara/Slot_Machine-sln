﻿using System;

namespace SlotMachine; // Note: actual namespace depends on the project name.

class Program
{
    const int COL_NUMBER = 3;
    const int ROW_NUMBER = 3;
    const int RDM_NUMBER_TOP_END = 11;


    static void Main(string[] args)
    {


        Console.WriteLine(" Slot Machine"); //Intro text
        Console.WriteLine("*-*-*-*-*-*-*-*\n");

        double[,] slotMachine = new double[ROW_NUMBER, COL_NUMBER]; //2D Array with numbers for each slot

        var rng = new Random(); //Random generator

        int rowIndex;
        int colIndex;
        for (rowIndex = 0; rowIndex < ROW_NUMBER; rowIndex++) //Random number for slots
        {
            for (colIndex = 0; colIndex < COL_NUMBER; colIndex++)
            {
                slotMachine[rowIndex, colIndex] = rng.Next(RDM_NUMBER_TOP_END); //Random generator for each slot in machine
                                                                                //           Console.Write(slotMachine[rowIndex, colIndex] + "\t"); //Pring random numbers for slot
            }

        }//end Slot loop

        for (rowIndex = 0; rowIndex < ROW_NUMBER; rowIndex++) //Random number for slots
        {
            for (colIndex = 0; colIndex < COL_NUMBER; colIndex++)
            {
                Console.Write(slotMachine[rowIndex, colIndex] + "\t"); //Print random numbers for slot
            }
            Console.WriteLine("");

        }//end Slot Print loop

        

    }//end Main args
}//end class Program