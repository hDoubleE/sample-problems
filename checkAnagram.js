/*
Function takes two strings and compares to see if they are valid anagrams.
Returns true or false. 

Runtime is O(2n) = O(n)

*/
/* jshint esversion: 6 */

function checkAnagram(str1, str2) {
    if (str1.length !== str2.length) return false;

    const lookup = {};
    for (let i = 0; i < str1.length; i++) {
        const letter = str1[i];
        lookup[letter] ? lookup[letter] += 1 : lookup[letter] = 1; 
    }
    for (let j = 0; j < str2.length; j++) {
        const letter = str2[j];
        if (!lookup[letter]) {
            return false;
        } 
        else {
            lookup[letter] -= 1;
        }
    }
    return true;
}

checkAnagram("listen", "silent");
checkAnagram("has", "ash");
checkAnagram("dude", "duke");
checkAnagram("dude", "dud");
