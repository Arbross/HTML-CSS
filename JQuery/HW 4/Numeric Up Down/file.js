const text = document.getElementById("text");
const up = document.getElementById("up");
const down = document.getElementById("down");

let count = 0;

up.addEventListener("click", () => {
    const p = document.createElement("p");
    p.innerHTML = count++;
    text.innerHTML = "";
    text.appendChild(p);
});

down.addEventListener("click", () => {
    const p = document.createElement("p");
    p.innerHTML = count--;
    text.innerHTML = "";
    text.appendChild(p);
});