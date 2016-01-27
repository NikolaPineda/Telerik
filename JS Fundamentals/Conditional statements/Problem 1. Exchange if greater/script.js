/*Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.*/

document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var numberA = document.getElementById('numberA').value,
           numberB = document.getElementById('numberB').value,
           result = document.getElementById('result');

       if(isNaN(numberA) || isNaN(numberB)){
           throw new Error('Invalid input!');
       }else {
           if(+numberA > +numberB){
               result.innerHTML = numberB + ' ' + numberA;
           }else {
               result.innerHTML = numberA + ' ' + numberB;
           }
       }
   })
});