/*Sort 3 real values in descending order.
 Use nested if statements.*/

document.addEventListener('DOMContentLoaded', function(){
    document.getElementById('btn').addEventListener('click', function(){
        var firstNumber = document.getElementById('firstNumber').value,
            secondNumber = document.getElementById('secondNumber').value,
            thirdNumber = document.getElementById('thirdNumber').value,
            result = document.getElementById('result');

        if(isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)){
            throw new Error("Invalid input!");
        }else {
            if (firstNumber > secondNumber){
                if(firstNumber > thirdNumber){
                    if(secondNumber > thirdNumber){
                        result.innerHTML = firstNumber + ' ' +  secondNumber + ' ' + thirdNumber;
                    }else {
                        result.innerHTML = firstNumber + ' ' +  thirdNumber + ' ' + secondNumber;
                    }
                }else {
                    result.innerHTML = thirdNumber + ' ' +  firstNumber + ' ' + secondNumber;
                }
            }else if(secondNumber > firstNumber){
                if(secondNumber > thirdNumber){
                    if(firstNumber > thirdNumber){
                        result.innerHTML = secondNumber + ' ' +  firstNumber + ' ' + thirdNumber;
                    }else {
                        result.innerHTML = secondNumber + ' ' +  thirdNumber + ' ' + firstNumber;
                    }
                }else {
                    result.innerHTML = thirdNumber + ' ' +  secondNumber + ' ' + firstNumber;
                }
            }
        }
    })
});