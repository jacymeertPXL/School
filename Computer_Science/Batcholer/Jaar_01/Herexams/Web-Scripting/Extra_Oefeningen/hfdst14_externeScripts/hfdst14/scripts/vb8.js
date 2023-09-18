'use strict'
let paras = document.body.getElementsByTagName("p");
for (let para of paras) {
    if (para.getAttribute("data-classified") == "secret") {
        para.remove();
    }
}