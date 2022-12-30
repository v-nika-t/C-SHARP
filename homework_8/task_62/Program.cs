// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7


void ShowMatrix(int [,] matrix) {
        for(int i = 0; i < matrix.GetLength(0); i++) {
           for(int k = 0; k < matrix.GetLength(1); k++) {
               Console.Write($"{matrix[i , k]} ");
           }
          Console.WriteLine("");
        }
        Console.WriteLine("");

};

int[,] ? CreateMatrix(int x, int y) {
    if( x != y ) {
      Console.WriteLine("Введите одинаковые x и y");
      return null;
    }
    int[,] matrix = new int[x,y];
    bool column = true;
    bool reverse = false;
    int value = 1;
    int countStep = matrix.GetLength(0);
    int count = 0;
    int offsetColumnStart = 0;
    int offseRowStart = 0;
    int offsetColumnEnd = 0;
    int offseRowEnd = 0;
    int length = matrix.GetLength(0) - 1;
                                                                                                                                                                                                                                                            
   for(int i = 0; i < countStep; i++) {
      reverse = count % 2 != 0;
      if(column) {
        for(int k = 0; k < countStep ; k++) { 
          if(!reverse) {
            matrix[offseRowStart, offsetColumnStart + k] = value++;
          } else {
            matrix[length - offseRowEnd, length - offsetColumnEnd - k] = value++;
          }
        };
    
        if(!reverse) offseRowStart++;
        if(reverse) offseRowEnd++;
        column = false;
        i=-1;
        countStep--;

      } else {
          if(!reverse) {
            matrix[offseRowStart + i, length - offsetColumnEnd] = value++;
          } else {
            matrix[length - offseRowEnd - i, offsetColumnStart] = value++;
          }
        if((i + 1) == countStep) {
          i = -1;
          column = true;
          if(!reverse) offsetColumnEnd++;
          if(reverse) offsetColumnStart++;;
          count++;
        }
      }
   }
   return matrix;
}




int[,] ? matrix =  CreateMatrix(4, 4);
if(matrix != null) ShowMatrix( matrix);
