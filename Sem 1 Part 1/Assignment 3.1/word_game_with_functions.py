import random
import re
with open('wordlist.txt', 'r') as textfile:
    word_list = [line.strip() for line in textfile]

def player_guess(hidden_word_list, used_letters, secret_word, guesses_count):
    while "*" in hidden_word_list: # while there are letters unguessed
        letter = input("Try to guess a letter.\n") # input from user
        if letter in used_letters: # has the letter been used
            print("The letter has already been used.")
            continue
        if letter in secret_word: # if the player guessed
            print("You guessed a letter!")
            for m in re.finditer(letter, secret_word): # show every guessed letter
                hidden_word_list[m.start()] = letter
            print(hidden_word_list)
        else: # if the player didnt guess and has no lifes
            if guesses_count -1 == 0:
                print(f"Sorry you ran out of lifes better luck next time. The word was \"{secret_word}\". ")
                quit()
            else: # if the player didnt guess and has lifes
                guesses_count -=1
                print(f"Wrong letter. Remaining lifes: {guesses_count}")
        used_letters.append(letter) # add used letter to the list of used letters

    print(f"Congratulations! You guessed the word \"{secret_word}\".")

secret_word = random.choice(word_list)
secret_word_list = list(secret_word)
hidden_word = '*'*len(secret_word)
hidden_word_list = list(hidden_word)
used_letters = []
guesses_count = 7
# get the secret word, a copy of it replaced with start and count of lifes

print(hidden_word)

player_guess(hidden_word_list,used_letters,secret_word,guesses_count)
