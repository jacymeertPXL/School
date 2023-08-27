'use strict'
const handleLoad = () => {
    let help = document.querySelector("#help");
    let fields = document.querySelectorAll("input");
    for (let field of Array.from(fields)) {
        for (let field of Array.from(fields)) {
            let textNodeData;
            field.addEventListener("focus", event => {
                let text = event.target.getAttribute("data-help");
                textNodeData = document.createTextNode(text);
                help.appendChild(textNodeData);
            });
            field.addEventListener("blur", event => {
                help.replaceChild(document.createTextNode(""), textNodeData);

            });
        }

    }
}


window.addEventListener("load", handleLoad);