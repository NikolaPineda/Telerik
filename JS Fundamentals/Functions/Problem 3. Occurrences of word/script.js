/*Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.*/
document.addEventListener('DOMContentLoaded', function(){
   document.getElementById('btn').addEventListener('click', function (){
        var wordInput = document.getElementById('word').value,
            textInput = document.getElementById('text').value,
            result = document.getElementById('result');

       function findOccurrenceOfWord(word, text) {
           var count = 0,
               countOfWords = 0;
           for (var i = 0; i < text.length; i += 1) {
               if(text[i] === word[0]){
                   for (var j = 0; j < word.length; j += 1) {
                       if(word[j] === text[i + j]){
                           count += 1;
                       }
                       if(count === word.length){
                           countOfWords += 1;
                       }
                   }

               }
               count = 0;
           }
           console.log(countOfWords);
       }

       findOccurrenceOfWord(wordInput, textInput);
    })
});
