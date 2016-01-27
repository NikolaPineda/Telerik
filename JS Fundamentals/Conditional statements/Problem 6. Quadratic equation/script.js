/*Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.*/
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var a = document.getElementById("firstNumber").value,
           b = document.getElementById("secondNumber").value,
           c = document.getElementById("thirdNumber").value,
           root1,
           root2,
           D,
           onlyRoot;

       a = +a;
       b = +b;
       c = +c;

       if (isNaN(a) || isNaN(b) || isNaN(c)) {
           document.getElementById("result").innerHTML = 'Invalid input!';
       }
       else {
           D = b * b - 4 * a * c;
           root1 = (-b + Math.sqrt(D)) / 2 * a;
           root2 = (-b - Math.sqrt(D)) / 2 * a;
           onlyRoot = -b / (2 * a);

           if (D < 0) {
               document.getElementById("result").innerHTML = 'There are no real roots!'
           } else if (D === 0) {
               document.getElementById("result").innerHTML = 'There is one root: ' + onlyRoot;
           }else{
               document.getElementById("result").innerHTML = 'There are two roots:' + root1 + 'and' + root2;
           }
       }
   })
});
