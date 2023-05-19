const search = document.getElementById("search");
const search_field = document.getElementById("search-field");
const button = document.getElementsByClassName("btn");
const dl = document.getElementById("character");
const add = document.getElementById("add");

function objTable(id, name, price, about) {
  this.id = id;
  this.name = name;
  this.price = price;
  this.about = about;
}

let objects = [
  new objTable(0, "Treu", 30, "trololo"),
  new objTable(1, "False", 20, "trololo"),
  new objTable(2, "Qoe", 20, "trololo"),
  new objTable(3, "Tor", 80, "t"),
  new objTable(4, "Sect", 20, "trololo",),
];


add.addEventListener("click", () => {
  const id = document.getElementById("write-id");
  const name = document.getElementById("write-name");
  const price = document.getElementById("write-price");
  const about = document.getElementById("write-about");

  objects.push(new objTable(id.value, name.value, price.value, about.value));

  dl.innerHTML = "";
  for (let i = 0; i < objects.length; i++) {
    const p = document.createElement("option");
    p.value = objects[i].name;
    dl.appendChild(p);
  }
});

dl.innerHTML = "";
for (let i = 0; i < objects.length; i++) {
  const p = document.createElement("option");
  p.value = objects[i].name;
  dl.appendChild(p);
}

search.addEventListener("click", (event) => {
  event.preventDefault();
  
  let str = String(search_field.value).toLowerCase();
  
  renderProduct(str);
  search_field.value = "";
  
  dl.innerHTML = "";
  for (let i = 0; i < objects.length; i++) {
    const p = document.createElement("option");
    p.value = objects[i].name;
    dl.appendChild(p);
  }
});

function renderProduct(obj) {
  const list = document.getElementById("table-body-search-results");

  const tr = document.createElement("tr");
  tr.setAttribute("id", "name", "price", "about");

  objects.forEach((elem) => {
    if (elem.name.toLowerCase().includes(obj)) {
      tr.innerHTML =
        "<td>" +
        elem.id +
        "</td>" +
        "<td>" +
        elem.name +
        "</td>" +
        "<td>" +
        elem.price +
        "</td>" +
        "<td>" +
        elem.about +
        "</td>";
      list.appendChild(tr);
    }
  });
}


