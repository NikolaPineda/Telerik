//Write a function that reverses the digits of given decimal number.
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var number = document.getElementById('number').value,
           result = document.getElementById('result'),
           reverseNumber = '';

       if(isNaN(number)){
           throw new Error('Invalid Input!');
       }else {
           for (var i = number.length - 1; i >= 0; i -= 1) {
               reverseNumber += number[i];
           }
           result.innerHTML = reverseNumber;
       }
   })
});