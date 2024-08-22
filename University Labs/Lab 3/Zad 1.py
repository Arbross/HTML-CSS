def ciag_rekurencyjny(a1, a2):
    an = 2 * a1 + a2
    print(an)
    return ciag_rekurencyjny(a2, an)

# ciag_rekurencyjny(2, 3)

def ciag_iteracyjny():
    a1 = 2
    a2 = 3
    for n in range(10):
        an = 2 * a1 + a2
        print(an)
        a1 = a2
        a2 = an

ciag_iteracyjny()
