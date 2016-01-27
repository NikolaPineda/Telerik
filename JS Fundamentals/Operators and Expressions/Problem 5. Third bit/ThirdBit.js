/*Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
 The bits are counted from right to left, starting from bit #0.
 The result of the expression should be either 1 or 0.*/

document.addEventListener('DOMContentLoaded', function(){
    document.getElementById('btn').addEventListener('click', function(){
        var number = document.getElementById('numberInput').value,
            result = document.getElementById('result');
        if(isNaN(number)){
            result.innerHTML = 'The input ' + number + 'is not a number!';
        }else {
            result.innerHTML = ('Third bit of number ' + number + (parseInt(number) & (1 << 3) ? ' is 1' : ' is 0'));
        }
    })
});