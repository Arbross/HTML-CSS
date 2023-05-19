const search = document.getElementById("search");
const search_field = document.getElementById("search-field");

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
  new objTable(4, "Sect", 20, "trololo"),
  new objTable(4, "Sect", 20, "trololo"),
];

search.addEventListener("click", (event) => {
  let str = String(search_field.value);

//   objects.forEach((elem) => {
//     if (elem.name.include(str))
//     {
//         console.log(elem.name);
//     }
//   });

  renderProduct(str);
  search_field.value = "";
});

function renderProduct(obj) {
  const list = document.getElementById("table-body-search-results");

  const tr = document.createElement("tr");
  tr.setAttribute("id", "name", "price", "about");

  objects.forEach((elem) => {
    if (elem.name == obj) {
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
