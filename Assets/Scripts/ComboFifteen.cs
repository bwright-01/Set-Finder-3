﻿// class which simply holds all the precomputed values for combinations of 3 cards from a set of 15
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboFifteen 
{
    public static int[,] getComboArray()
    {
        return comboArray;
    }

    static int[,] comboArray = new int[,]{ {0,1,2},
								{0,1,3},
								{0,1,4},
								{0,1,5},
								{0,1,6},
								{0,1,7},
								{0,1,8},
								{0,1,9},
								{0,1,10},
								{0,1,11},
								{0,1,12},
								{0,1,13},
								{0,1,14},
								{0,2,3},
								{0,2,4},
								{0,2,5},
								{0,2,6},
								{0,2,7},
								{0,2,8},
								{0,2,9},
								{0,2,10},
								{0,2,11},
								{0,2,12},
								{0,2,13},
								{0,2,14},
								{0,3,4},
								{0,3,5},
								{0,3,6},
								{0,3,7},
								{0,3,8},
								{0,3,9},
								{0,3,10},
								{0,3,11},
								{0,3,12},
								{0,3,13},
								{0,3,14},
								{0,4,5},
								{0,4,6},
								{0,4,7},
								{0,4,8},
								{0,4,9},
								{0,4,10},
								{0,4,11},
								{0,4,12},
								{0,4,13},
								{0,4,14},
								{0,5,6},
								{0,5,7},
								{0,5,8},
								{0,5,9},
								{0,5,10},
								{0,5,11},
								{0,5,12},
								{0,5,13},
								{0,5,14},
								{0,6,7},
								{0,6,8},
								{0,6,9},
								{0,6,10},
								{0,6,11},
								{0,6,12},
								{0,6,13},
								{0,6,14},
								{0,7,8},
								{0,7,9},
								{0,7,10},
								{0,7,11},
								{0,7,12},
								{0,7,13},
								{0,7,14},
								{0,8,9},
								{0,8,10},
								{0,8,11},
								{0,8,12},
								{0,8,13},
								{0,8,14},
								{0,9,10},
								{0,9,11},
								{0,9,12},
								{0,9,13},
								{0,9,14},
								{0,10,11},
								{0,10,12},
								{0,10,13},
								{0,10,14},
								{0,11,12},
								{0,11,13},
								{0,11,14},
								{0,12,13},
								{0,12,14},
								{0,13,14},
								{1,2,3},
								{1,2,4},
								{1,2,5},
								{1,2,6},
								{1,2,7},
								{1,2,8},
								{1,2,9},
								{1,2,10},
								{1,2,11},
								{1,2,12},
								{1,2,13},
								{1,2,14},
								{1,3,4},
								{1,3,5},
								{1,3,6},
								{1,3,7},
								{1,3,8},
								{1,3,9},
								{1,3,10},
								{1,3,11},
								{1,3,12},
								{1,3,13},
								{1,3,14},
								{1,4,5},
								{1,4,6},
								{1,4,7},
								{1,4,8},
								{1,4,9},
								{1,4,10},
								{1,4,11},
								{1,4,12},
								{1,4,13},
								{1,4,14},
								{1,5,6},
								{1,5,7},
								{1,5,8},
								{1,5,9},
								{1,5,10},
								{1,5,11},
								{1,5,12},
								{1,5,13},
								{1,5,14},
								{1,6,7},
								{1,6,8},
								{1,6,9},
								{1,6,10},
								{1,6,11},
								{1,6,12},
								{1,6,13},
								{1,6,14},
								{1,7,8},
								{1,7,9},
								{1,7,10},
								{1,7,11},
								{1,7,12},
								{1,7,13},
								{1,7,14},
								{1,8,9},
								{1,8,10},
								{1,8,11},
								{1,8,12},
								{1,8,13},
								{1,8,14},
								{1,9,10},
								{1,9,11},
								{1,9,12},
								{1,9,13},
								{1,9,14},
								{1,10,11},
								{1,10,12},
								{1,10,13},
								{1,10,14},
								{1,11,12},
								{1,11,13},
								{1,11,14},
								{1,12,13},
								{1,12,14},
								{1,13,14},
								{2,3,4},
								{2,3,5},
								{2,3,6},
								{2,3,7},
								{2,3,8},
								{2,3,9},
								{2,3,10},
								{2,3,11},
								{2,3,12},
								{2,3,13},
								{2,3,14},
								{2,4,5},
								{2,4,6},
								{2,4,7},
								{2,4,8},
								{2,4,9},
								{2,4,10},
								{2,4,11},
								{2,4,12},
								{2,4,13},
								{2,4,14},
								{2,5,6},
								{2,5,7},
								{2,5,8},
								{2,5,9},
								{2,5,10},
								{2,5,11},
								{2,5,12},
								{2,5,13},
								{2,5,14},
								{2,6,7},
								{2,6,8},
								{2,6,9},
								{2,6,10},
								{2,6,11},
								{2,6,12},
								{2,6,13},
								{2,6,14},
								{2,7,8},
								{2,7,9},
								{2,7,10},
								{2,7,11},
								{2,7,12},
								{2,7,13},
								{2,7,14},
								{2,8,9},
								{2,8,10},
								{2,8,11},
								{2,8,12},
								{2,8,13},
								{2,8,14},
								{2,9,10},
								{2,9,11},
								{2,9,12},
								{2,9,13},
								{2,9,14},
								{2,10,11},
								{2,10,12},
								{2,10,13},
								{2,10,14},
								{2,11,12},
								{2,11,13},
								{2,11,14},
								{2,12,13},
								{2,12,14},
								{2,13,14},
								{3,4,5},
								{3,4,6},
								{3,4,7},
								{3,4,8},
								{3,4,9},
								{3,4,10},
								{3,4,11},
								{3,4,12},
								{3,4,13},
								{3,4,14},
								{3,5,6},
								{3,5,7},
								{3,5,8},
								{3,5,9},
								{3,5,10},
								{3,5,11},
								{3,5,12},
								{3,5,13},
								{3,5,14},
								{3,6,7},
								{3,6,8},
								{3,6,9},
								{3,6,10},
								{3,6,11},
								{3,6,12},
								{3,6,13},
								{3,6,14},
								{3,7,8},
								{3,7,9},
								{3,7,10},
								{3,7,11},
								{3,7,12},
								{3,7,13},
								{3,7,14},
								{3,8,9},
								{3,8,10},
								{3,8,11},
								{3,8,12},
								{3,8,13},
								{3,8,14},
								{3,9,10},
								{3,9,11},
								{3,9,12},
								{3,9,13},
								{3,9,14},
								{3,10,11},
								{3,10,12},
								{3,10,13},
								{3,10,14},
								{3,11,12},
								{3,11,13},
								{3,11,14},
								{3,12,13},
								{3,12,14},
								{3,13,14},
								{4,5,6},
								{4,5,7},
								{4,5,8},
								{4,5,9},
								{4,5,10},
								{4,5,11},
								{4,5,12},
								{4,5,13},
								{4,5,14},
								{4,6,7},
								{4,6,8},
								{4,6,9},
								{4,6,10},
								{4,6,11},
								{4,6,12},
								{4,6,13},
								{4,6,14},
								{4,7,8},
								{4,7,9},
								{4,7,10},
								{4,7,11},
								{4,7,12},
								{4,7,13},
								{4,7,14},
								{4,8,9},
								{4,8,10},
								{4,8,11},
								{4,8,12},
								{4,8,13},
								{4,8,14},
								{4,9,10},
								{4,9,11},
								{4,9,12},
								{4,9,13},
								{4,9,14},
								{4,10,11},
								{4,10,12},
								{4,10,13},
								{4,10,14},
								{4,11,12},
								{4,11,13},
								{4,11,14},
								{4,12,13},
								{4,12,14},
								{4,13,14},
								{5,6,7},
								{5,6,8},
								{5,6,9},
								{5,6,10},
								{5,6,11},
								{5,6,12},
								{5,6,13},
								{5,6,14},
								{5,7,8},
								{5,7,9},
								{5,7,10},
								{5,7,11},
								{5,7,12},
								{5,7,13},
								{5,7,14},
								{5,8,9},
								{5,8,10},
								{5,8,11},
								{5,8,12},
								{5,8,13},
								{5,8,14},
								{5,9,10},
								{5,9,11},
								{5,9,12},
								{5,9,13},
								{5,9,14},
								{5,10,11},
								{5,10,12},
								{5,10,13},
								{5,10,14},
								{5,11,12},
								{5,11,13},
								{5,11,14},
								{5,12,13},
								{5,12,14},
								{5,13,14},
								{6,7,8},
								{6,7,9},
								{6,7,10},
								{6,7,11},
								{6,7,12},
								{6,7,13},
								{6,7,14},
								{6,8,9},
								{6,8,10},
								{6,8,11},
								{6,8,12},
								{6,8,13},
								{6,8,14},
								{6,9,10},
								{6,9,11},
								{6,9,12},
								{6,9,13},
								{6,9,14},
								{6,10,11},
								{6,10,12},
								{6,10,13},
								{6,10,14},
								{6,11,12},
								{6,11,13},
								{6,11,14},
								{6,12,13},
								{6,12,14},
								{6,13,14},
								{7,8,9},
								{7,8,10},
								{7,8,11},
								{7,8,12},
								{7,8,13},
								{7,8,14},
								{7,9,10},
								{7,9,11},
								{7,9,12},
								{7,9,13},
								{7,9,14},
								{7,10,11},
								{7,10,12},
								{7,10,13},
								{7,10,14},
								{7,11,12},
								{7,11,13},
								{7,11,14},
								{7,12,13},
								{7,12,14},
								{7,13,14},
								{8,9,10},
								{8,9,11},
								{8,9,12},
								{8,9,13},
								{8,9,14},
								{8,10,11},
								{8,10,12},
								{8,10,13},
								{8,10,14},
								{8,11,12},
								{8,11,13},
								{8,11,14},
								{8,12,13},
								{8,12,14},
								{8,13,14},
								{9,10,11},
								{9,10,12},
								{9,10,13},
								{9,10,14},
								{9,11,12},
								{9,11,13},
								{9,11,14},
								{9,12,13},
								{9,12,14},
								{9,13,14},
								{10,11,12},
								{10,11,13},
								{10,11,14},
								{10,12,13},
								{10,12,14},
								{10,13,14},
								{11,12,13},
								{11,12,14},
								{11,13,14},
								{12,13,14}};
}
