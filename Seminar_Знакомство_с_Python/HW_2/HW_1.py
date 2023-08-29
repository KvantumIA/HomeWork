# Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. 
# Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты 
# вверх одной и той же стороной. Выведите минимальное количество монет, которые нужно перевернуть


import random

n = int(input('Введите число монеток: '))

count_zero = 0
count_one = 0
for _ in range(n):
    moneta = random.randrange(0, 2)
    if moneta == 0:
        count_zero += 1
    else:
        count_one += 1
    print(moneta)
if count_one > count_zero:
    print(f'Надо перевернуть: {count_zero}')
else:
    print(f'Надо перевернуть: {count_one}')