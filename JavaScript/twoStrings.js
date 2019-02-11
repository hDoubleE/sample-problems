// Given two strings, determine if they share a common substring. A substring may be as small as one character.
// For example, the words "a", "and", "art" share the common substring 'a'. The words "be" and "cat" do not share a substring.

function twoStrings(s1, s2) {

    const obj = {}

    for (let c in s1) {
        if (!obj[s1[c]]) {
            obj[s1[c]] = 1;
        }
        else {
            obj[s1[c]] += 1;
        }
    }

    for (let c in s2) {
        if (obj[s2[c]]) {
            return "YES"; 
        }
    }
    return "NO";
}