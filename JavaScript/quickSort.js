/* jshint esversion: 6 */

function quickSort(arr, left = 0, right = arr.length - 1) {
    // base case can't be on arr.length because "in-place" always entire array
    if (left < right) {
        let pivotIndex = pivot(arr, left, right);
        // left
        quickSort(arr, left, pivotIndex - 1)
        // right 
        quickSort(arr, pivotIndex + 1, right)
    }
    return arr;
}

function pivot(arr, start=0, end = arr.length - 1) {
        function swap(arr, i, j) {
        let temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    
    let pivot = arr[start];
    let swapIndex = start;

    for (let i = start + 1; i < arr.length; i++) {
        if(pivot > arr[i]) {
            swapIndex++;
            swap(arr, i, swapIndex);
        }
    }
    swap(arr, start, swapIndex);
    return swapIndex;
}

quickSort([4, 2, 8, 5, 9, 6, 3, 7]);