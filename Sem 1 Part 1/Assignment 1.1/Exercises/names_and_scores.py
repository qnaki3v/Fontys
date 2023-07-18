first_name = input()
first_score = float(input())

second_name = input()
second_score = float(input())

if first_score > second_score:
    print(f"{first_name} is the winner!")
elif second_score > first_score:
    print(f"{second_name} is the winner!")
else:
    print("There is no winner. It's a draw!")
