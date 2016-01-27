/**
 * Created by Pineda on 6/4/2015.
 */
function parseUrlToJSON(str) {
    var regexParser = /(https?|ftp):\/\/([^\/]+)\/(.*)/i;
    var result = str.match(regexParser);
    return {
        protocol: result[1],
        server: result[2],
        resource: result[3]};
}
function printJSON(jsonResult) {
    for (var prop in jsonResult) {
        console.log(prop + ": " + jsonResult[prop]);
    }
}
function readInput() {
    var input = document.getElementById('textInput').value;
    var jsonResult = parseUrlToJSON(input);
    printJSON(jsonResult);
}