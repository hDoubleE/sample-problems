/* The "Sliding Window" creates an equally spaced window that slides through data. 
 * Depending on conditions the window either increases or closes incrementally. 
 * Useful for keeping track of a subset in a string or array. 
 * 
 * Example: Design a method that takes an array of integers 
 * and an integer n, where n is the length of subarray to add.  
 * Return an integer that is the sum of max subarray of size n. 
 * 
 * The brute force approach is O(n^2) comparing every possible sum to max.
 * The sliding window approach is O(n). 
*/

/* jshint esversion: 6 */

function maxSubArray(arr, num) {
    let max = 0;
    let temp = 0;
    if (arr.length < num) {
        return null;
    }
    // Add first n numbers and assign to max.
    for (let i = 0; i < num; i++) {
        max += arr[i];        
    }
    // Loop through array using i and num as window buffer.
    for (let i = num; i < arr.length; i++) {
        temp = temp - arr[i - num] + arr[i];
        // Equivalent to if/else max > temp.
        max = Math.max(max, temp);

        console.log(arr[i-num], arr[i], temp, max)
    }
    return max;
}

// n = arr[i - num]
// [2, 2, 2, 2, 1, 8, 5, 6, 3]  t - n + i
//  n        i                = 0 - 2 + 2, max = 6
// [2, 2, 2, 2, 1, 8, 5, 6, 3]
//     n        i             = -1 - 2 + 1, max = 6
// [2, 2, 2, 2, 1, 8, 5, 6, 3]
//        n        i          = 5 - 2 + 8, max = 6
// [2, 2, 2, 2, 1, 8, 5, 6, 3]
//           n        i       = 8 - 2 + 5, max = 8
// [2, 2, 2, 2, 1, 8, 5, 6, 3]
//              n        i    = 13 - 6 + 1, max = 13
// [2, 2, 2, 2, 1, 8, 5, 6, 3]
//                 n        i = 8 - 8 + 3, max = 13