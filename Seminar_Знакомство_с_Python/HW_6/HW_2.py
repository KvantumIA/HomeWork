# Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат 
# заданному диапазону (т.е. не меньше заданного минимума и не больше заданного максимума)

# Ввод
#   0  1  2  3   4   5  6  7   8   9  10 11  12 13 14  15  16  17  18 19
# [-5, 9, 0, 3, -1, -2, 1, 4, -2, 10, 2, 0, -9, 8, 10, -9, 0, -5, -5, 7]
# Вывод
# [1, 9, 13, 14, 19]

def Find_Range(num_range_min, num_range_max):
    list_end = []
    for i in range(len(list_1)):
        if num_range_min < list_1[i] < num_range_max:
            list_end.append(i)
    return list_end


list_1 = [-5, 9, 0, 3, -1, -2, 1, 4, -2, 10, 2, 0, -9, 8, 10, -9, 0, -5, -5, 7]

num_range_min = int(input('Введите диапазон: минимум = '))
num_range_max = int(input('Введите диапазон: максимум = '))

print(Find_Range(num_range_min, num_range_max))