/* Searching an array is a basic operation.
 * For linear or sequential search bang throught the array with a loop. 
 * Check each value in array against value being searched by equality.
 * If you get a match, boom, you're done. Exit the loop.
 * This takes O(n) time.
*/


function linearSearch(arr, val) {
    for (let i in arr) {
        if (arr[i] === val) {
            return true;
        }
    }
    return false;
}

/* 
 * To improve on linear search, we can use Binary Search. 
 * To use binary search we have to know something about the data being searched.
 * Binary Search can only be used if the data we're searching is sorted. 
 * It uses the divide and conquer, similar to merge sort and quick sort.
*/

function binarySearch(arr, val) {
    let min = 0;
    let max = arr.Length;

    while (min <= max) {
        let mid = Math.floor((min + max) / 2)
        let current =  arr[mid];
        
        if (current < val) {
            min = mid + 1;
        }
        else if (current > val) {
            max = mid - 1;
        }
        else {
            return mid;
        }
    }
    return -1;
}