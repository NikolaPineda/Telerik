/*Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.*/

document.addEventListener('DOMContentLoaded', function(){
    document.getElementById('btn').addEventListener('click', function(){
        var firstNumber = document.getElementById('firstNumber').value,
            secondNumber = document.getElementById('secondNumber').value,
            thirdNumber = document.getElementById('thirdNumber').value,
            result = document.getElementById('result'),
            countOfMinus = 0,
            i,
            numbers = [firstNumber, secondNumber, thirdNumber],
            countOfNumbers = numbers.length,
            zero = false;

        if(isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)){
            throw new Error("Invalid input!");
        }else {
            for(i = 0; i < countOfNumbers; i += 1){
                if(+numbers[i] === 0){
                    zero = true;
                }else {
                    if(+numbers[i] < 0){
                        countOfMinus += 1;
                    }
                }
            }
            if (zero) {
                result.innerHTML = 'Result of the product is: 0'
            } else  if(countOfMinus % 2){
                result.innerHTML = 'Sign is: -';
            } else {
                result.innerHTML = 'Sign is: +';
            }
        }
    })
});