let btnSearch = document.getElementById("search");
let tInput = document.getElementById("title"); 
let tType = document.getElementById("type"); 

btnSearch.addEventListener("click", (event) => {
    event.preventDefault();

    let tmp = new Film();
    tmp.Spawn();
});

class Film {
    Film(img, title, year, link, type) {
        this.img = img;
        this.title = title;
        this.year = year;
        this.link = link;
        this.type = type;
    }

    FindByTitle() {
        fetch(`http://www.omdbapi.com/?t=${tInput.value}&apikey=3e894c4a`)
            .then(response => {
                response.json().then(data => {
                    this.title = data.Title;
                    this.year = data.Year;
                    this.type = data.Type;
        });});
    }

    FindByType() {
        fetch(`http://www.omdbapi.com/?type=${tType.value}&apikey=3e894c4a`)
            .then(response => {
                response.json().then(data => {
                    this.title = data.Title;
                    this.year = data.Year;
                    this.type = data.Type;
        });});
    }

    Find() {
        fetch(`http://www.omdbapi.com/?t=${tInput.value}&?type=${tType.value}&apikey=3e894c4a`)
            .then(response => {
                response.json().then(data => {
                    this.img = data.Poster;
                    this.title = data.Title;
                    this.year = data.Year;
                    this.type = data.Type;
        });});
    }

    FindImg() {
        fetch(`http://img.omdbapi.com/?t=${tInput.value}&?type=${tType.value}&apikey=3e894c4a`)
            .then(response => {
                response.json().then(data => {
                    
                    this.year = data.Year;
                    this.type = data.Type;
                    this.link = data.Website;
        });});
    }

    Spawn() {
        const list = document.getElementById("serials");

        this.Find();
        
        setTimeout(() => {
            const div = document.createElement("div");
            div.style.textAlign = "center";
            div.innerHTML = `<img src="${this.img}" alt="">` + "<br>" + this.title + "<br>" + this.year + "<button class='border-0 form-control m-2 bg-light'>Details</button>";
            list.appendChild(div);
        }, 100);
    }   
}

