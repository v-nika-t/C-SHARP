// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

int [,] CreateMatrix(int n) {
    int column = (n * 2) - 1 ;
    int row = n;
    if(n == 2)  column = n + 1;
        int [,] matrix = new int[row, column];
        for(int i = 0; i < matrix.GetLength(0); i++) {
           for(int k = 0; k < matrix.GetLength(1); k++) {
               matrix[i , k] = 0;
               int halfLength = matrix.GetLength(1) / 2;
               if(i == 0 && k == halfLength)   matrix[i , k] = 1;
               if(k == halfLength -i || k == halfLength + i)  matrix[i , k] = 1;
               
               if( !((i == 0 || i == 1) || (i == matrix.GetLength(0) - 1) ) )  {
                    if( (k > halfLength - i) && (k < halfLength + i) )  {
                        //Console.WriteLine($"i, k, halfLength: {i}, {k}, {halfLength}, {matrix.GetLength(0)}");

                     matrix[i , k] = matrix[i - 1 , k - 1] + matrix[i - 1 , k + 1];
                    }
               }
               if( i == matrix.GetLength(0) - 1 ) {
                if( (k == (matrix.GetLength(1) - 1)) || (k == 0)) {
                    matrix[i , k] = 1;
                } else {
                    matrix[i , k] = matrix[i - 1 , k - 1] + matrix[i - 1 , k + 1];
                }
               }
               if(matrix[i , k] == 0) {
                Console.Write($" ");
               } else {
                Console.Write($"{matrix[i , k]}");
                
               }
              Console.Write($" ");
           }
          Console.WriteLine("");
        }
        return matrix;
}

void ShowMatrix(int [,] matrix) {
        for(int i = 0; i < matrix.GetLength(0); i++) {
           for(int k = 0; k < matrix.GetLength(1); k++) {
               Console.Write($"{matrix[i , k]} ");
           }
          Console.WriteLine("");
        }
        Console.WriteLine("");

}

int [,] matrix = CreateMatrix(7); 
//ShowMatrix(matrix );