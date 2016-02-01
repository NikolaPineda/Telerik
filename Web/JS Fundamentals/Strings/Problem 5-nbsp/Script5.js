/**
 * Created by Pineda on 6/4/2015.
 */
function replace(str){
    return str.replace(/ /g,'&nbsp');
}
function showReplace(){
    var text = document.getElementById('inputText').value;
    console.log(replace(text));
}