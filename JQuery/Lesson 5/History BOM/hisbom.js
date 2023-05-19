const ul = document.getElementById("text");
const watch = document.getElementById("watch");

watch.addEventListener("click", () => {
    const p = document.createElement("p");
    p.innerHTML = String(history.length - 1);
    ul.appendChild(p);
});