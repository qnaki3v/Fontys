first_num = float(input())
second_num = float(input())

operator = input()

if operator == "+":
    print(first_num + second_num)
elif operator == "-":
    print(first_num-second_num)
elif operator == "*":
    print(first_num*second_num)
else:
    print(first_num/second_num)
