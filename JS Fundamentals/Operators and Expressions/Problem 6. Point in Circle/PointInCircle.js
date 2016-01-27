//Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius

document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var pointX = document.getElementById('pointX').value,
           pointY = document.getElementById('pointY').value,
           result = document.getElementById('result'),
           radius = 5;
       if(isNaN(pointX) || isNaN(pointY)){
           result.innerHTML = 'Incorrect input!'
       }else {
           if((parseFloat(pointX) * parseFloat(pointX) + parseFloat(pointY) * parseFloat(pointY)) < (parseFloat(radius) * parseFloat(radius))){
               result.innerHTML = 'The point is in the circle!';
           }
           else{
               result.innerHTML = 'The point is not in the circle!';
           }
       }
   })
});