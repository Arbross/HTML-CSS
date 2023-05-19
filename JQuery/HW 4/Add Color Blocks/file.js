const btn = document.getElementById("color-block");
const colors = document.getElementById("blocks");

btn.addEventListener("click", () => {
    let div = document.createElement("div");

    div.style.backgroundColor = random_bg_color();
    div.style.width = 50;
    div.style.height = 50;
    div.style.color = div.style.backgroundColor;
    div.style.display = "inline-flex";

    div.innerHTML = "qqqq<br>qqqq";
    colors.appendChild(div);
});

colors.addEventListener("click", (event) => {
    colors.removeChild(event.target);
})

function random_bg_color() {
    let x = Math.floor(Math.random() * 256);
    let y = Math.floor(Math.random() * 256);
    let z = Math.floor(Math.random() * 256);
    
    return "rgb(" + x + "," + y + "," + z + ")";
}