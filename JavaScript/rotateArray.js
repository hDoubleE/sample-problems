function rotate(nums, k) {
    let tempArr = [];
    for (let i = 0; i < nums.length; i++) {
        tempArr[(i + k) % nums.length] = nums[i];
    }
    for (let i = 0; i < nums.length; i++) {
        nums[i] = tempArr[i];
    }
};

function rotate(nums, k) {
    k %= nums.length;
    reverse(nums, 0, nums.length - 1);
    reverse(nums, 0, k-1);
    reverse(nums, k, nums.length - 1);
};

function reverse(nums, start, end) {
    while (start < end) {
    let temp = nums[start];
    nums[start] = nums[end];
    nums[end] = temp;
    start++;
    end--;
    }
};