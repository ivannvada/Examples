﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//               0   1    2   3   4  5   6   7   8
int[] Array = { 11, 31, 53, 63, 46, 73, 23, 57, 89};


int max = Max(
    Max(Array[0], Array[1], Array[2]),
    Max(Array[3], Array[4], Array[5]),
    Max(Array[6], Array[7], Array[8]));

Console.WriteLine(max);