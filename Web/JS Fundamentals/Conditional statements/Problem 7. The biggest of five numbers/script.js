/*Write a script that finds the greatest of given 5 variables.
 Use nested if statements.*/
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var firstNumber = document.getElementById('firstNumber').value,
           secondNumber = document.getElementById('secondNumber').value,
           thirdNumber = document.getElementById('thirdNumber').value,
           fourthNumber = document.getElementById('fourthNumber').value,
           fifthNumber = document.getElementById('fifthNumber').value,
           biggestNumber,
           result = document.getElementById('result');

       if(firstNumber > secondNumber){
           biggestNumber = fifthNumber;
       }else {
           biggestNumber = secondNumber;
       }
       if(thirdNumber > biggestNumber){
           biggestNumber = thirdNumber;
       }
       if(fourthNumber > biggestNumber){
           biggestNumber = fourthNumber;
       }
       if(fifthNumber > biggestNumber){
           biggestNumber = fifthNumber
       }

       result.innerHTML = 'The biggest number is: ' + biggestNumber
   })
});
