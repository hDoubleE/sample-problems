function _linearSearch(arr: Array<number>, val: number): boolean {
    for (let i in arr) {
        if (arr[i] === val) {
            return true;
        }
    }
    return false;
}


function _binarySearch(arr: Array<number>, val: number): number {
    let min: number = 0;
    let max: number = arr.length;

    while (min <= max) {
        let mid: number = Math.floor((min + max) / 2)
        let current =  arr[mid];
        
        if (current < val) {
            min = mid + 1;
        }
        else if (current > val) {
            max = mid - 1;
        }
        else {
            return mid;
        }
    }
    return -1;
}