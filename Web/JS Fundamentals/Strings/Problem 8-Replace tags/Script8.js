/**
 * Created by Pineda on 6/4/2015.
 */
function readInput() {
    var input = document.getElementById('tb-input').value;
    var result = replaceTags(input);
    console.log(result);
}
function replacerFunction(match, p1, p2, p3) {
    var result = match;
    result = result.replace(p1, '[URL=');
    result = result.replace(p2, ']');
    result = result.replace(p3, '[/URL]');
    return result;
}
function replaceTags(str) {
    var matchingRegex = /(<\s*a\s*href\s*=)[^>]*("\s*>)[^<]*(<\s*\/\s*a\s*>)/gi;
    return str.replace(matchingRegex, replacerFunction);
}