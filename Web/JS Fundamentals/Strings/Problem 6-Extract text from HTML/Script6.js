/**
 * Created by Pineda on 6/4/2015.
 */
function textExtract(text){
    return text.replace(/<(.*?)>/ig, '');
}
function testExtraction(){
    var text = document.getElementById('textInput').value;
    document.getElementById('textResult').innerHTML = textExtract(text);
}