/**
 * Created by Pineda on 6/5/2015.
 */
function findPalindromes(){
    var arrayText = document.getElementById('inputText').value.replace(/[.,?!]/g,'').split(' ');
    //var reverseArray = document.getElementById('inputText').value.replace(',', '.','?','!').split(' ').reverse();
    for(var i = 0; i < arrayText.length;i+=1){
        if(arrayText[i].toLowerCase() === arrayText[i].toLowerCase().split('').reverse().join('')){
            console.log(arrayText[i]);
        }
    }
}