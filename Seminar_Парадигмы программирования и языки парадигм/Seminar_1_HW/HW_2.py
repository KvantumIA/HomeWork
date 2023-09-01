# Задача 2: Поиск наименьшего числа в списке. Напишите программу, которая находит наименьшее число в заданном списке с помощью цикла.

import random

def Random(n, list):
    for i in range(n):
        x = int(random.randint(1, 10))
        list.insert(i, x)
    return list

def Min(n, list_return):
    min = list_return[0]
    for i in range(n):
        if list_return[i] < min:
            min = list_return[i]
    return min




n = int(input('Введите количество элементов в списке: '))
list = []
list_return = Random(n, list)
print(f'Список: {list_return}')

num_min = Min(n, list_return)
print(f'Наименьший элемент = {num_min}')