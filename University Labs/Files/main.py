p = open("/Users/victor/Downloads/a.txt", encoding="UTF-8")
print(p)

d = p.readlines()
print(type(d))
print(d)

for i in range(len(d)):
    d[i] = d[i].replace('\n', '')
    d[i] = d[i].split(' ')
    print(i, d[i])
print(d[5][1])

print(type(p))
