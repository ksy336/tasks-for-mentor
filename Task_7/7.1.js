"use strict";

function changeString(str) {
    let letters = {};
    let result;
    let ignoreSymbols = ["?", "!", ":", ";", ",", ".", " ", "\t", "\r"];
    let words = str.toLowerCase().split(" ");

    words.forEach(function(word) {
        word.split("").forEach(function(letter, i) {
            if(!letters[letter] && ignoreSymbols.indexOf(letter) === -1 && -1 !== word.indexOf(letter, i + 1)) {
                letters[letter] = 1;
            }
        })
    })
    result = str.toLowerCase().split("").filter(item => !letters[item]).join("");

    return result;
}
const exampleStr = "У попа была собака";
const resString = changeString(exampleStr);
console.log(resString);

// У о был собк
