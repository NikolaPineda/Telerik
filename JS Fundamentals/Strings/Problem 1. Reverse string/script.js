//Write a JavaScript function that reverses a string and returns it.
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function(){
       var text = document.getElementById('inputText').value,
           result = document.getElementById('result');

       function reversString(str){
           return str.split('')
               .reverse()
               .join('');
       }

       result.innerHTML = reversString(text);
   })
});