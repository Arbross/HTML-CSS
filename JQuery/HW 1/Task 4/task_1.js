function getPhactorial(from, to)
{
    let result = 1;
    while (true) 
    {
        if (from == to + 1)
        {
            return result;
        }

        result *= from;
        from++;
    }
}

console.log(getPhactorial(1, 10));