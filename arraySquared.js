/*
"Frequency Counter" problem solving approach. 
This approach can be used to compare the frequency of occurrences for different inputs.
Good for comparing strings, characters, arrays, numbers for anagrams, repetition, etc...

Write a function that accepts two arrays, checks if Array 2, contains all values of Array 1, squared.
Return true or false.

The naive approach is nested loops with an O(n^2) runtime. This should be avoided at all costs. 
This solution is O(3N) due to 3 separate loops.
Drop the constant and it's an O(n) runtime.

*/ 

/* jshint esversion: 6 */
function arraySquared(arr1, arr2) {
    // Short circuit the algorithm is array lengths are not equal. 
    if (arr1.length !== arr2.length) return false;

    let frequencyCounter1 = {};
    let frequencyCounter2 = {};

    // Iterate object 1 and populate with Array 1, value: number of occurrences. 
    // {1: 1, 2: 1, 3: 1...}
    for (let i of arr1) {
        frequencyCounter1[i] = (frequencyCounter1[i] || 0) + 1;
    }
    // Iterate object 2 and populate with Array 2, value: number of occurrences. 
    // {1: 1, 4: 1, 9: 1...}
    for (let j of arr2) {
        frequencyCounter2[j] = (frequencyCounter2[j] || 0) + 1;
    }
    // Iterate through either object and compare against the other to check if squared. 
    for (let key in frequencyCounter1) {
        // If key (from frequencyCounter1) is NOT squared in frequencyCounter2, return false.
        // Checks frequency of occurrences is the same in each object.
        if (!(key ** 2 in frequencyCounter2)) {
            return false;
        }
        // If the values do not square, return false.
        if (frequencyCounter2[key ** 2] !== frequencyCounter1[key]) {
            return false;
        }
    }
    return true;
}

arraySquared([1,2,3,4,5,], [9, 25, 4, 1, 16]); 
// True

arraySquared([1,2,3,4,5,], [1, 4, 9, 16, 1]); 
// False