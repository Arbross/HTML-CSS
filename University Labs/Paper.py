import random

while True:
    print("0 - Papier")
    print("1 - Nozyce")
    print("2 - Kamien")

    playerChoice = int(input(""))
    if playerChoice < 0 | playerChoice > 2:
        print("Nie istnieje takiego narzedzia.")
        continue

    computerChoice = random.randint(0, 2)

    if playerChoice == computerChoice:
        print("Nikt nie wygral.")
        continue

    if playerChoice == 2 & computerChoice == 1:
        print("Wygrales!")
        break
    elif playerChoice == 0 & computerChoice == 0:
        print("Wygrales!")
        break
    elif playerChoice == 0 & computerChoice == 2:
        print("Wygrales!")
        break
    else:
        print("Komputer wygral.")
        break
