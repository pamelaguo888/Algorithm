#include <iostream>

void swap(int* a, int* b)
{
  int temp = *a;
  *a = *b;
  *b = temp;
}

int Partition(int arr[], int low, int high)
{
  int pivot = arr[high];
  int i = low -1;

  for(int j=low; j<high; j++)
  {
    if(arr[j]<=pivot)
    {
      i++;
      swap(&arr[i], &arr[j]);
    }
  }

  swap(&arr[i+1], &arr[high]);
  return i+1;
}

void QuickSort(int arr[], int low, int high)
{
  if(low < high)
  {
    int pivot = Partition(arr, low, high);
    QuickSort(arr, low, pivot-1);
    QuickSort(arr, pivot+1, high);
  }
}

/* Function to print an array */
void printArray(int arr[], int size) 
{ 
    int i; 
    for (i=0; i < size; i++) 
        printf("%d ", arr[i]); 
    printf("Done"); 
} 

int main(){
  std::cout << "Hello World!";

  int arr[5] = {64, 30, 2, 10, -12};
  int length = sizeof(arr)/sizeof(arr[0]);
  QuickSort(arr, 0, length-1);
  printArray(arr, length);
  return 0;
}

