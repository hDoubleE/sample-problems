/* "Frequency Counters" can be used to compare different inputs. 
 * Useful for strings, arrays, characters and anagrams.
 * Avoid quadratic algorithms as linear solutions exist.
 *
 * Example: Given two Arrays, check if Array 2 contains values that are the square root of values contained in Array 1.
 * Return boolean. 
 * 
*/

/* jshint esversion: 6 */

function arraySquared(arr1, arr2) {
    
    if (arr1.length !== arr2.length) return false;

    let frequencyCounter1 = {};
    let frequencyCounter2 = {};

    // Populate object1 with values in array1.
    for (let i of arr1) {
        frequencyCounter1[i] = (frequencyCounter1[i] || 0) + 1;
    }

    // Populate object2 with values in array2.
    for (let j of arr2) {
        frequencyCounter2[j] = (frequencyCounter2[j] || 0) + 1;
    }
    // Iterate through one object and compare against the other to check squared values. 
    for (let key in frequencyCounter1) {
        // If key in frequencyCounter1 is NOT squared in frequencyCounter2, return false.
        if (!(key ** 2 in frequencyCounter2)) {
            return false;
        }
        // If the values (frequency of occurrences) do not match, return false.
        if (frequencyCounter1[key] !== frequencyCounter2[key ** 2]) {
            return false;
        }
    }
    // If all keys are squared values, and frequency values match, exit loop and return true. 
    return true;
}

arraySquared([1,2,3,4,5,], [9, 25, 4, 1, 16]); 
// True

arraySquared([1,2,3,4,5,], [1, 4, 9, 16, 1]); 
// False

/* Example: Design a function that takes two strings and compares them to see if they are a valid anagram. 
 * Return nboolean.
 * O(n)
*/

function checkAnagram(str1, str2) {
    if (str1.length !== str2.length) {
        return false;
    }
    // Create object to collect string characters(key) and occurrences(value).
    const frequencyCounter = {};
    
    for (let i = 0; i < str1.length; i++) {
        // Does letter exist in obj? True: Increment by 1. False: Initialize to 1.
        frequencyCounter[i] ? frequencyCounter[i] += 1 : frequencyCounter[i] = 1; 
    }
    
    for (let j = 0; j < str2.length; j++) {
        // If letter from string 2 NOT in obj.
        // Strings are different, return false.
        if (!frequencyCounter[j]) {
            return false;
        } 
        // Letter from str2 exists in str1.
        // Decrement 1 occurrence from obj.
        else {
            frequencyCounter[j] -= 1;
        }
    }
    // If strings match, loop exits, object values at 0.
    return true;
}

checkAnagram("listen", "silent");
checkAnagram("has", "ash");
checkAnagram("dude", "duke");
checkAnagram("dude", "dud");