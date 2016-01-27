//Write a script that finds the max and min number from a sequence of numbers.
var arrayOfNumbers = [1,2,3,4,5,6,7,8,9,-11,-15],
    min = arrayOfNumbers[1],
    max = arrayOfNumbers[1],
    i;

function displayMinAndMaxNumber(array){
    for ( i = 1; i < array.length; i += 1) {
        min = Math.min(min, array[i]);
        max = Math.max(max, array[i]);
    }
    console.log('Max number is: ' + max);
    console.log('Min number is: ' + min);
}

displayMinAndMaxNumber(arrayOfNumbers);