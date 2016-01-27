/**
 * Created by Pineda on 6/5/2015.
 */

function testStringFormat() {
    var format = "{0}, {1}, {0} text {2}";
    console.log(stringFormat(format, 1, "Pesho", "Gosho"));
}
function stringFormat(str) {
    var strFormatArgs = arguments;

    var formatReplacer = function(match, p1) {
        return strFormatArgs[parseInt(p1) + 1] || match;
    };

    return str.replace(/{(\d+)\}/g, formatReplacer);
}