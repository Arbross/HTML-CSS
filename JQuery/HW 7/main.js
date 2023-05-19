let current_symbol = null;
let img_list = ["circle.png", "square.png", "triangle.png"];

$('.start').click(() => {
   $('main div').css("color", "burlywood"); 
   $('main div').css("background-color", "burlywood"); 
});

$('.symbol').click(() => {
    if (current_symbol == null)
    {
        current_symbol = $(this).text();
        console.log(current_symbol);
        $(this).css("color", "black"); 
        $(this).prev().css("background-color", "white"); 
    }
    else {
        if (current_symbol == $(this).text)
        {
            $(this).css("color", "black"); 
            $(this).prev().css("background-color", "white"); 
            current_symbol = null;
        }
    }
});

$('.symbol div img').each($(this).attr("src", "images/" + img_list[0 + Math.floor(Math.random() * 3)]));

