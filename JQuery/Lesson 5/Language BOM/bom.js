const ul = document.getElementById("ul");
const okay = document.getElementById("okay");

let languages = navigator.languages;
let language = navigator.language;

okay.addEventListener("click", () => {
    renderProduct();
});

function renderProduct() {
    const list = document.getElementById("ul");
    const li = document.createElement("li");
  
    languages.forEach(el => {
        if (el == language)
        {
            li.innerHTML += `<li><strong>${el}</strong></li>`;
        }
        else {
            li.innerHTML += `<li>${el}</li>`;
        }

        list.appendChild(li);
    });
}