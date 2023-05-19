const Open = document.getElementById("open");
const Close = document.getElementById("close");

let tmpWindow;

Open.addEventListener("click", () => {
    tmpWindow = window.open("https://google.com", '_blank', 'location=yes,height=640,width=480,scrollbars=yes,status=yes');
});

Close.addEventListener("click", () => {
    tmpWindow.close();
});