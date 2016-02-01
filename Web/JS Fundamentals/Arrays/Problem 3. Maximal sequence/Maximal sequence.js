//Write a script that finds the maximal sequence of equal elements in an array.
var array = [1,1,1,2,2,3,5,5,5,5,5,6,6,7,7,7,8,8],
    i,
    tempLongestCount = 1,
    longestCount = 1;

function findLongestSequence(arr){
    for (var i = 1; i < arr.length; i += 1) {
        if(arr[i] === arr[i - 1]){
            tempLongestCount += 1;
        }else {
            tempLongestCount = 1;
        }
        if(longestCount < tempLongestCount){
            longestCount = tempLongestCount;
        }
    }
    console.log('The longest sequence is: ' + longestCount)
}

findLongestSequence(array);