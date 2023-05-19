function countArea(a, b)
{
    if (b == 0 || b < 0)
    {
        return a * a;
    }

    if (a == 0 || a < 0)
    {
        return b * b;
    }

    return a * b;
}

alert("Area : " + countArea(5, 3) + "cm^2");