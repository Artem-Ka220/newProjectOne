int [] arrays = {5, 8, 10, 7, 1, 3, 5, 2, 4, 6, 8, 7, 9};
for(int i = 0; i < arrays.Length; i++){
    Console.Write(arrays[i] + ", ");
}
    Console.WriteLine();
arrayOne(arrays);
printArray(arrays);

void arrayOne(int[] array){
    for(int i = 0; i < array.Length - 1; i++){
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++){
            if(array[j] < array[minPosition]){
                minPosition = j;
            }
        }
        int temporary = array[i];
            array[i] = array[minPosition];
                array[minPosition] = temporary;
    }
}
void printArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + ", ");
    }
}

