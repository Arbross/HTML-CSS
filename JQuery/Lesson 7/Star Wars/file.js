const next = document.getElementById("next");
const previous = document.getElementById("previous");

let api_url = 'https://swapi.dev/api/people/?page=1';
let result;

function writeInfo(result)
{
    const list = document.getElementById("table-body");
    list.innerHTML = null;

    result.results.forEach((elem) => {
        const tr = document.createElement("tr");
        tr.setAttribute("name", "height", "mass", "hair-color", "skin-color", "eye-color", "birth-year", "gender");

        tr.innerHTML =
          "<td>" +
          elem.name +
          "</td>" +
          "<td>" +
          elem.height +
          "</td>" +
          "<td>" +
          elem.mass +
          "</td>" +
          "<td>" +
          elem.hair_color +
          "</td>" +
          "<td>" +
          elem.skin_color +
          "</td>" +
          "<td>" +
          elem.eye_color +
          "</td>" +
          "<td>" +
          elem.birth_year +
          "</td>" + 
          "<td>" +
          elem.gender +
          "</td>";
        list.appendChild(tr);
    });
}

function writeError(error) {
    const text = document.getElementById("text-info");
    text.textContent = error;
}

fetch(api_url)
    .then(response => {
        response.json().then(data => {
            result = data;
            writeInfo(data);
        });
    })
    .catch(error => {
        writeError(error);
    });

next.addEventListener("click", (event) => {
    event.preventDefault();

    console.log(result);
    if (result.next != null)
    {
        console.log("sd");
        fetch(result.next)
            .then(response => {
                api_url = result.next;
                response.json().then(data => {
                    console.log(data);
                    writeInfo(data);
                });
            })
            .catch(error => {
                writeError(error);
            });   
    }
    else {

    }
});

previous.addEventListener("click", (event) => {
    event.preventDefault();

    console.log(result);
    if (result.previous != null)
    {
        console.log("sd");
        fetch(result.previous)
            .then(response => {
                api_url = result.previous;
                response.json().then(data => {
                    console.log(data);
                    writeInfo(data);
                });
            })
            .catch(error => {
                writeError(error);
            });   
    }
    else {

    }
});