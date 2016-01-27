/**
 * Created by Pineda on 6/5/2015.
 */
function findMail(){
    var text = document.getElementById('inputText').value.split(' ');
    for(var i = 0; i < text.length; i+=1){
       if(text[i].includes('@')){
           console.log(text[i]);
       }
    }

}