//Write a script that compares two char arrays lexicographically (letter by letter).
var arrayA  = ['z', 'x', 'v', 'b'],
    arrayB = ['a','s','d','f'];

function compareArrays(arrA, arrB){
    for (var i = 0; i < arrA.length; i += 1) {
        console.log(arrA[i] > arrB[i] ? arrA[i] + ' is bigger than ' + arrB[i] : arrB[i] + ' is bigger than ' + arrA[i]);
    }
}

compareArrays(arrayA, arrayB);
