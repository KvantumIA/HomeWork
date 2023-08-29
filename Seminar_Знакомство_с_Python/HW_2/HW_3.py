# Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.


num = int(input('Введите число: '))

count = 0
sum = 0

while sum <= num:
    if sum < num:
        sum = 2 ** count
        count += 1    
    if sum == num:
        print(sum)
        break
    if sum > num:
        break
    print(sum)