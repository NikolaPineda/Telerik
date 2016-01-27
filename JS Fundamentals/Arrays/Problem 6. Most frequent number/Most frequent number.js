//Write a script that finds the most frequent number in an array.
var array = [1,1,1,2,2,3,5,5,5,5,5,6,6,7,7,7,8,8],
    tempMax = 0,
    maxOccurrence = 0,
    number;

for (var i = 0; i < array.length; i += 1) {
    for (var j = 0; j < array.length; j += 1) {
        if(array[i] === array[j]){
            tempMax += 1;

        }
    }
    if(tempMax > maxOccurrence){
        maxOccurrence = tempMax;
        number = array[i];
    }
    tempMax = 0;
}
console.log(number + ' number of times ' + maxOccurrence);