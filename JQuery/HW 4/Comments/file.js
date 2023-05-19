const text = document.getElementById("text");   
const nameq = document.getElementById("name");
const comment = document.getElementById("comment");
const btn = document.getElementById("btn");

btn.addEventListener("click", () => {
    const p = document.createElement("p");
    p.innerHTML = `<b>${nameq.value}</b><br>${comment.value}`;
    text.appendChild(p);
    console.log(nameq.value)
});