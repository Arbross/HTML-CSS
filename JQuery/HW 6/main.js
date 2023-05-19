let api_url = 'https://jsonplaceholder.typicode.com/todos/';
let tasks_grid = document.getElementById("t");

fetch(api_url)
  .then(response => response.json())
  .then(json => {
    let id = 1, userId = 0;
    console.log(json);

    let div = document.createElement("div");
    json.forEach(el => {
        if (id == 1)
        {
          div.innerHTML = `<h4>${el.userId}</h4>`;
        }

        if (el.userId != userId)
        {
          id = 0;
          div = document.createElement("div");
        }
        else {
          id = 2;
        }
        
        if (id == 0)
        {
          userId++;
          id = 1;
          div.innerHTML += `</div>`;
          tasks_grid.appendChild(div);
        }
        else if (id == 2)
        {
          div.innerHTML += `<div>
          <p>${el.title}</p>
          <div class="box-icons">
          <div class="icons">
          <div><img src="images/justify_26.png" alt="" /></div>
          <div><img src="images/checkbox_26.png" alt="" /></div>
          4/8
          <div><img src="images/attach_26.png" alt="" /></div>
          2
          <div><img src="images/comments_26.png" alt="" /></div>
          4
          </div>
          <div>${el.id} <img src="images/avatar_1.png" alt="" /></div>`;
        }        
});
});
