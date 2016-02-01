//Write an expression that calculates trapezoid's area by given sides a and b and height h.

document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var sideA = document.getElementById('sideA').value,
           sideB = document.getElementById('sideB').value,
           height = document.getElementById('height').value,
           result = document.getElementById('result');

       if(isNaN(sideA) || isNaN(sideB) || isNaN(height)){
           result.innerHTML = 'Incorrect input!'
       }else {
           result.innerHTML = parseFloat(height) * (parseFloat(sideA) + parseFloat(sideB)) / 2;
       }
   })
});