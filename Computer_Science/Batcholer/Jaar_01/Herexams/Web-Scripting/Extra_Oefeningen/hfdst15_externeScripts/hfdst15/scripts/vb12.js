'use strict'
const handleLoad = () => {
    let button = document.querySelector("button");
    button.addEventListener("click", handleClick);
}

const handleClick = (event) => {
    console.log(event.target.firstChild.nodeValue);
}


window.addEventListener("load", handleLoad);