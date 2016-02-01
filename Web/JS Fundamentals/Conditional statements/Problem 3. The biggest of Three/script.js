/*Write a script that finds the biggest of three numbers.
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
                   result.innerHTML = firstNumber;
               }else {
                   result.innerHTML = thirdNumber;
               }
           }else if(secondNumber > firstNumber){
               if(secondNumber > thirdNumber){
                   result.innerHTML = secondNumber
               }else {
                   result.innerHTML = thirdNumber;
               }
           }
       }
   })
});
