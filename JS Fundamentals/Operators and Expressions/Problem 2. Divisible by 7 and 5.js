//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
var arrayOfNumbers = [3,0,5,7,35,140],
    i,
    length = arrayOfNumbers.length;

var testNumbers = function(){
    for(i = 0; i < length; i+=1){
        if(arrayOfNumbers[i] % 5 === 0 && arrayOfNumbers[i] % 7 ===  0){
            console.log(true)
        }
        else {
            console.log(false);
        }
    }
}

testNumbers();
