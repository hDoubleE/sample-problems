// Given two strings s and t , write a function to determine if t is an anagram of s.

var isAnagram = function(s, t) {
    let arr = Array(26).fill(0);
    if (s.length !== t.length) return false;
    for (let i = 0; i < s.length; i++) {
        arr[s.charCodeAt(i) - 97]++;
        arr[t.charCodeAt(i) - 97]--;
    }
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] !== 0) {
            return false;
        }
    }
    return true;
};