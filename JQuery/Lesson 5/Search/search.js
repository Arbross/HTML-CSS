const search = document.getElementById("search");
const search_field = document.getElementById("search-field");
const button = document.getElementsByClassName("btn");

function objTable(id, name, price, about, link) {
  this.id = id;
  this.name = name;
  this.price = price;
  this.about = about;
  this.link = link;
}

let objects = [
  new objTable(0, "Treu", 30, "trololo", "https://google.com"),
  new objTable(1, "False", 20, "trololo", "https://yummyanime.com"),
  new objTable(2, "Qoe", 20, "trololo", "https://animevost.org"),
  new objTable(3, "Tor", 80, "t", "https://youtube.com"),
  new objTable(4, "Sect", 20, "trololo", "https://youtube.com"),
];

search.addEventListener("click", (event) => {
  event.preventDefault();

  let str = String(search_field.value).toLowerCase();

  renderProduct(str);
  search_field.value = "";
});

button.addEventListener("click", () => {
  const tmp = document.getElementById(this.id);

  let link;
  let name = String(tmp.value);
  objects.forEach(el => {
    if (el.name.toLowerCase() == name)
    {
      link = el.link;
    }
  });

  window.open(`${link}`, '_blank', 'location=yes,height=640,width=480,scrollbars=yes,status=yes')
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
        `<button type='button' class='btn btn-dark m-2' id='${elem.name.toLowerCase()}'>Open In A New Tab</button>` + 
        "</td>";
      list.appendChild(tr);
    }
  });
}


