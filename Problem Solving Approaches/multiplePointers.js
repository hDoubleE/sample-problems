/* "Multiple Pointers" create pointers(values) that correspond to an index(position)
 * and move toward beginning, end, middle, based on condition. 
 * Efficient: O(n).
 * Minimal space complexity.
 * 
 * Example: Design a function which takes a sorted array of integers. 
 * Find the first pair that has a sum of 0.
 * Return an array that includes both values or -1 if none exist. 
 * 
 * Note: Good for sorted data, if data is unsorted, no efficient solutions exist. 
 * Note: Naive approach is O(n^2), brute force, comparing all possible combinations. 
*/

/* jshint esversion: 6 */

function sumZero(arr) {
    let left = 0;
    let right = arr. length -1;
    
    while (left < right) {
        let sum = arr[left] + arr[right];
        if (sum === 0) {
            return [arr[left], arr[right]];
        }
        else if (sum > 0) {
            right--;
        }
        else {
            left++;
        }
    }
    return -1;
}

sumZero([-4, -3, -2, -1, 0, 1, 2, 6, 10]);
// -> [3, 3]

// [-4, -3, -2, -1, 0, 1, 2, 6, 10]
//   ^                           ^ = 6, right--
// [-4, -3, -2, -1, 0, 1, 2, 6, 10]
//   ^                       ^     = 2, right--
// [-4, -3, -2, -1, 0, 1, 2, 6, 10]
//   ^                    ^        = -2, left++
// [-4, -3, -2, -1, 0, 1, 2, 6, 10]
//       ^                ^        = -1, left++
// [-4, -3, -2, -1, 0, 1, 2, 6, 10]
//           ^            ^        = 0, return
//

sumZero([-4, -2, 1, 10]);
// [-4, -3, 1, 10]
//   ^          ^ = 6, right--
// [-4, -3, 1, 10]
//   ^      ^     = -3, left++
// [-4, -3, 1, 10]
//       ^  ^     = -2, exit loop, return -1

// Example: Design a function that takes a sorted array and 
// returns an integer of the quantity of unique values in array.

function countUniqueValues(arr) {
    if (arr.length === 0) {
        return 0;
    }

    let i = 0;
    for (let j = 1; j < arr.length; j++) {
        // Everytime pointers do NOT match, i increments and is set to match j
        // i's index tracks qty of unique nums through inequality.
        if (arr[i] !== arr[j]) {
            i++;
            arr[i] = arr[j];
        }
    }
    return i + 1;
}

countUniqueValues([2, 2, 4, 4, 5, 6])
// -> 4
// [2, 2, 4, 4, 5, 6]
//  i  j             = j++
// [2, 2, 4, 4, 5, 6] 
//  i     j          = i++, i <- j 
// [2, 4, 4, 4, 5, 6]
//     i  j          = j++
// [2, 4, 4, 4, 5, 6]
//     i     j       = j++ 
// [2, 4, 4, 4, 5, 6]
//     i        j    = i++, i <- j
// [2, 4, 5, 4, 5, 6]
//        i     j    = j++ 
// [2, 4, 5, 4, 5, 6]
//        i        j = i++, i <- j
// [2, 4, 5, 6, 5, 6]
//           i     j = return i + 1
// i index position is 3 + 1 = 4