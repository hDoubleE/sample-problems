// Given two arrays, return true/false if there are matching items in each array.

// array1: [2, 4, 6, 12]
// array2: [3, 5, 14, 43, 12]
// True

// array1: ['a', 'b', 'c', 'x']
// array2: ['d', 'e', 'f']
// False

/* jshint esversion: 6 */

function isPair(arr1, arr2) {
    if (arr1.length === 0 || arr2.Length === 0) {
        return false;
    }

    let smaller = isSmaller(arr1, arr2);
    let bigger = isBigger(arr1, arr2);
    
    let collection = {};
    
    for (let i = 0; i < smaller.length; i++) { 
        if (!collection[smaller[i]]) {
            collection[smaller[i]] = true;
        }
    }
    
    for (let i = 0; i < bigger.length; i++) { 
        if (collection[bigger[i]]) {
            return true;
        }
    }
    return false;
}

// O(n+m)

function isSmaller(arr1, arr2) {
    if (arr1.length <= arr2.length) {
        return arr1;
    }
    else {
        return arr2;
    }
}

function isBigger(arr1, arr2) {
    if (arr1.length <= arr2.length) {
        return arr2;
    }
    else {
        return arr1;
    }
}