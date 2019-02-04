// Given an array of integers, find if the array contains any duplicates.
// Your function should return true if any value appears at least twice in 
// the array, and it should return false if every element is distinct.

function containsDuplicate(nums) {
    let set = {};
    for (let i = 0; i < nums.length; i++) {
        if (set[nums[i]]) {
          return true;  
        }
        set[nums[i]] = true;
    }
    return false
}

// Using es6 Set
var containsDuplicate = function(nums) {
    if (new Set(nums).size === nums.length)
        return false;
    return true;
};
