// Single-dimensional
int[] values = { 1, 2, 3, 4, 5, 6, 7 };

// multi-dimensional
int[,] multiInt = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };
int[,,] multiInt2 = new int[2, 3, 4]
{
    {{1,2,3,4 },{4,5,6,7 } ,{ 7,8,9,10} },
    {{10,20 ,30,40}, {40,50,60,70 }, { 70,80,90,100} }
};

// jagged arrays.
int[][] jagged = new int[3][];
jagged[0] = new int[2] { 1, 2 };
jagged[1] = new int[3] { 1, 2, 3 };
jagged[2] = new int[4] { 1, 2, 3 ,4};