# Задача 4: Поиск уникальных элементов в списке. Напишите программу, которая создает новый список, 
# содержащий только уникальные элементы из исходного списка.


import random

def Random(num, list_old):
    for i in range(num):
        x = int(random.randint(1, 10))
        list_old.insert(i, x)
    return list_old

def Unique_list(list_return):
    unique_list = set(list_return)
    return unique_list
            



num = int(input('Введите количество элементов в списке: '))
list_old = []
list_return = Random(num, list_old)
print(f'Список: {list_return}')

print(Unique_list(list_return))