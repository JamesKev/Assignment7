using System;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray1 = {12,5,36,18,2,1,30};
            int[] myArray2 = {16,3,3,14,15,9,12};

            // bubble sort
            bubbleSort(myArray1);
            printArray(myArray1);

            // quick sort
            quickSort(myArray2, 0, myArray2.Length-1);
            printArray(myArray2);

            
        }

        static void bubbleSort(int[] myArray){
            int arrayLength = myArray.Length; 
            for (int i = 0; i < arrayLength - 1; i++) 
                for (int j = 0; j < arrayLength - i - 1; j++) 
                    if (myArray[j] > myArray[j + 1]){ 
                         
                        int temp = myArray[j]; 
                        myArray[j] = myArray[j + 1]; 
                        myArray[j + 1] = temp; 
                    } 
        }

        
        static int partition(int []myArray, int low, int high) { 

            int pivot = myArray[high];  
            
            
            int i = (low - 1);  
            for (int j = low; j < high; j++) { 
                
                if (myArray[j] < pivot) 
                { 
                    i++; 
    
                    
                    int temp = myArray[i]; 
                    myArray[i] = myArray[j]; 
                    myArray[j] = temp; 
                } 
            } 
    
            
            int temp1 = myArray[i+1]; 
            myArray[i+1] = myArray[high]; 
            myArray[high] = temp1; 
    
            return i+1; 
        } 
  
  
    
    static void quickSort(int []myArray, int low, int high) { 
        if (low < high) { 
              
            
            int part = partition(myArray, low, high); 
  
            
            quickSort(myArray, low, part-1); 
            quickSort(myArray, part+1, high); 
        } 
    } 

        static void printArray(int []myArray) { 
       
            for (int i = 0; i < myArray.Length; ++i) 
                Console.WriteLine(myArray[i] + " "); 
             

        } 
    }
}
