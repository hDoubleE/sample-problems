// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// One pass hash table, leet code.

var twoSum = function(nums, target) {
    let ht = {};

    for (let i = 0; i < nums.length; i++) {
        let current = nums[i];
        let complement = target - current;

        if (complement in ht) {
            return [ht[complement], i];
        }
        ht[current] = i;
    }
    return null;
};