//Write an expression that checks if given integer is odd or even.
var odd = 'odd',
    even = 'even',
    arrayOfNumberToCheck = [1, 2, 3, 4, 5, 6],
    i,
    length = arrayOfNumberToCheck.length;

var testOddOrEven = function(){
    for(arrayOfNumberToCheck[i] = 0; arrayOfNumberToCheck[i] < length; i+=1){
        if(i % 2 === 0){
            console.log(even)
        }else {
            console.log(odd)
        }
    }
};

testOddOrEven();
