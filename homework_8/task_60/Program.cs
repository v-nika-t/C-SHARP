// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int [,,]? CreateThreeDMatrix(int x, int y, int z,  int min, int max) {
        int [,,] matrix = new int[x, y, z];
        int step = min;
        if( (matrix.GetLength(0) + matrix.GetLength(1) + matrix.GetLength(2)) > (max - min) ) {
             Console.WriteLine("Кол-во ячеейк матрицы больше чем чисел в диопозоне. Ячейки не смогут быть заполнены неповторяющимеся числам."); 
             return null;
        }
        for(int i = 0; i < matrix.GetLength(0); i++) {
            for(int e = 0; e < matrix.GetLength(1); e++) {
                for(int k = 0; k < matrix.GetLength(2); k++) {
                    matrix[i , e,  k] = step++;
                    Console.Write($"{matrix[i , e,  k]}({i} , {e} , {k}) ");
                }
            Console.WriteLine(""); 
            }
            Console.WriteLine("");
        }

        return matrix;
}


int [,,]? matrix = CreateThreeDMatrix(3, 3, 3,  10 , 99); 
