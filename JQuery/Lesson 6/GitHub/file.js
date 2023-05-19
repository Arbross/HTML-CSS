const btn = document.getElementById("btn");
const xhr = new XMLHttpRequest();

btn.addEventListener("click", () => {
    const username = document.getElementById("user-login");
    const api_url = "https://api.github.com/users/" + username.value;
    
    xhr.open("GET", api_url);
    xhr.send();
});

xhr.onload = () => {
    const name = document.getElementById("name");
    const login = document.getElementById("login");
    const url_git = document.getElementById("url-git");
    const blog = document.getElementById("blog");
    const city = document.getElementById("city");
    const email = document.getElementById("email");
    const following = document.getElementById("follwing");
    const followers = document.getElementById("followers");
    const img = document.getElementById("img");

    let result = JSON.parse(xhr.responseText);
    
    img.src = result.avatar_url;
    name.textContent = result.name;
    login.textContent = result.login;
    url_git.textContent = result.html_url;
    blog.textContent = result.blog;
    city.textContent = result.location;
    email.textContent = result.email;
    following.textContent = result.following;
    followers.textContent = result.followers;  
}