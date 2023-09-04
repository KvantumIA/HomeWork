# Задача 30:  Заполните массив элементами арифметической прогрессии. Её первый элемент, 
# разность и количество элементов нужно ввести с клавиатуры. 
# Формула для получения n-го члена прогрессии: an = a1 + (n-1) * d.
# Каждое число вводится с новой строки.

# Ввод
# 7 2 5
# Вывод
# 7 9 11 13 15


# an = Num_first + (Num_count-1) * Num_step.

def Ariphmetic_Progress(Num_first, Num_step, Num_count):
    Num_list = [Num_first]
    for i in range(1, Num_count):
        if Num_count == 0:
            print(Num_first)
        else:
            Num_first += Num_step
            Num_list.insert(i, Num_first)
    return Num_list
    

Num_first = int(input('Введите число начала последовательности: '))
Num_step = int(input('Введите шаг для последовательности чисел: '))
Num_count = int(input('Введите количество чисел в последовательности: '))


print(Ariphmetic_Progress(Num_first, Num_step, Num_count))