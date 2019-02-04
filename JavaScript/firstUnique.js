// Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
// Hash table, Works
function firstUniqChar(s) {
    
    let ht = {};
    
    for (let i = 0; i < s.length; i++) {
        ht[s[i]] ? ht[s[i]] += 1 : ht[s[i]] = 1;
    }
    
    
    for (let j = 0; j < s.length; j++) {
        if (ht[s.charAt(j)] === 1) {
            return j;
        }
    }
    return -1;
}
// Hash table, Works
function firstUniqChar(s) {
    
    let ht = {};
    
    for (let i = 0; i < s.length; i++) {
        ht[s[i]] = (ht[s[i]] || 0) + 1;
    }
    
    for (let j = 0; j < s.length; j++) {
        if (ht[s.charAt(j)] === 1) {
            return j;
        }
    }
    return -1;
}
// Array with ascii codes
function firstUniqChar(s) {
    
    let arr = [];
    
    for (let i = 0; i < s.length; i++) {
        if (arr[s.charCodeAt(i)]) {
            arr[s.charCodeAt(i)] += 1;
        }
        else {
        arr[s.charCodeAt(i)] = 1;
        }
    }
    
    for (let i = 0; i < s.length; i++) {
        if (arr[s.charCodeAt(i)] === 1) {
            return i;
        }
    }
    return -1;
}