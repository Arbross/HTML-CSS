const dl = document.getElementById("character");

let countries = ["Ukaine", "Cambodia", "Cameroon", "Canada", "Cape Verde"];

for (let i = 0; i < 5; i++) {
    const p = document.createElement("option");
    p.value = countries[i];
    dl.appendChild(p);
}
