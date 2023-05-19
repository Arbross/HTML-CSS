function Style(name, style)
{
    this.name = name;
    this.style = style;
}

let styles = [new Style("text-center", "text-align: center;"), new Style("color-blue", "color: blue;")];

function getStyles(styles)
{
    let str = "";
    styles.forEach(elem => {
        str += elem.style + " ";
    });

    return str;
}

document.write(`<p style="${getStyles(styles)}">Hello world!</p>`);