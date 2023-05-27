using System;
class HelloWorld {
  static void Main() {
int [] arrayOne = {15, 1, 12, 5, 8, 3, 7, 16, 19, 23, 18};
    for(int i = 0; i < arrayOne.Length; i ++){
        Console.Write(arrayOne[i] + ", ");
    }
Console.WriteLine(" ");

findMax(arrayOne);

Sorted(arrayOne);
}
   static void Sorted(int[]arrays){
        for(int i = 0; i < arrays.Length; i ++){
            Console.Write(arrays[i] + ", ");
        }
    }
    
 //static void findMax(int[]array){
 //for(int j = 0; j < array.Length -1; j++){
   //      for(int i = 1; i < array.Length; i++){
     //       if(array[i] > array[i - 1]){
       //         int max = array[i];
         //       array[i] = array[i - 1];
           //      array[i - 1] = max;
             //  }
        //}
    // }
    //} 
static void findMax(int[]array){
    bool Sort = false;
        while(!Sort){
            Sort = true;
            for(int i = 1; i < array.Length; i++){
                if(array[i] > array[i - 1]){
                    int max = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = max;
                    Sort = false;
                }
           }
        }
     }
   }
