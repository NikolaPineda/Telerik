//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

document.addEventListener('DOMContentLoaded', function () {
    document.getElementById('btn').addEventListener('click', function(){
        var number = document.getElementById('numberInput').value,
            result = document.getElementById('result').innerHTML,
            thirdDigit = number.length - 3;
        if(isNaN(number)){
            result = "Input is not a number!"
        }else if(number[thirdDigit] === '7'){
            result = 'The third digit is 7: true';
            console.log(result);
        }else {
            result = 'The third digit is 7: false';
            console.log(result);
        }
    })
});
