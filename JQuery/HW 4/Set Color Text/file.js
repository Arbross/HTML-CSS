const sec1 = document.getElementById("sec-1");
const sec2 = document.getElementById("sec-2");
const sec3 = document.getElementById("sec-3");
const text = document.getElementById("text");

sec1.addEventListener("click", (event) => {
    text.style.color = "blue";
});

sec2.addEventListener("click", (event) => {
    text.style.color = "red";
});

sec3.addEventListener("click", (event) => {
    text.style.color = "yellow";
});