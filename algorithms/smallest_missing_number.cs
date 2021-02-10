using System.IO;
using System;

class Program
{
    static void Main()
    {   
        int [] arr = { 1, 2, 3, 4, 5, 6, 7, 10};
        
        Console.WriteLine("Hello, Rahul! "+ findSmallestMissinginSortedArray(arr, 0, arr.Length));
    }
    
    public static int findSmallestMissinginSortedArray(int [] arr, int start, int end){
        if(start != arr[start]){
            return start;
        }
        if((end -1) == arr[end-1]){
            return end;
        }
        
        return findmissing(arr, 0, arr.Length);
        
    }
    
    
    public static int findmissing(int [] arr, int start, int end){
        int mid = (start+end)/2;
        
        if (start < end){
        
        if (arr[mid] != mid){
            return findmissing(arr, start, mid);
        } else {
            return findmissing(arr, mid+1, end);
        }
            
        }
        
        return start;
    }
}
