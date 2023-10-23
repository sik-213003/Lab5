﻿using System;
namespace Basics
{
    class TestArraysClass
        static void Main(string[] args)
    {
        int[] array1 = new int[5];
        int[] array2 = new int[] { 1, 3, 5, 7, 9};
        int[] array3 = { 1, 2, 3, 4, 5, 6 };
        int[,] multiDimensionalArray1 = new int[2, 3];
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[][] jaggedArray = new int[6][];
        jaggedArray[0] = new int[4] { 1, 2, 3, 4};
    }
}