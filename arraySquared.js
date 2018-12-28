/*jshint esversion: 6 */ 

function arraySquared(arr1, arr2) {
    if (arr1.length !== arr2.length) return false;

    let frequencyCounter1 = {};
    let frequencyCounter2 = {};

    for (let i of arr1) {
        frequencyCounter1[i] = (frequencyCounter1[i] || 0) + 1;
    }

    for (let j of arr2) {
        frequencyCounter2[j] = (frequencyCounter2[j] || 0) + 1;
    }

    for (let key in frequencyCounter1) {
        if (!(key ** 2 in frequencyCounter2)) {
            return false;
        }
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