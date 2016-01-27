/*Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3)
and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var sideX =parseFloat( document.getElementById("sideX").value);
       var sideY = parseFloat(document.getElementById("sideY").value);
       var radius = parseFloat(3);
       var inTheCircle = false;
       var outsideRectangle = false;
       if(isNaN(sideX) || isNaN(sideY)){
           document.getElementById("resultCircleAndRect").innerHTML = 'Invalid input!';
       }
       else{
           if((sideX - 1)*(sideX-1) + ((sideY - 1)*(sideY-1))< (radius*radius)){
               inTheCircle = true;
           }
           if (!((sideX >= -1 && sideX <=5) && (sideY >= -1 && sideY <=1))){
               outsideRectangle = true;
           }
           if(outsideRectangle === true && inTheCircle === true){
               document.getElementById("result").innerHTML ="The given point is both inside the circle and" +
                   " outside of the rectangle";
           }
           else{
               document.getElementById("result").innerHTML = "The given point is either outside the circle " +
                   "and/or inside of the rectangle";
           }


       }
       if(sideY >= -1){
           console.log(true)
       }
       else{
           console.log(false);
       }
   })
});