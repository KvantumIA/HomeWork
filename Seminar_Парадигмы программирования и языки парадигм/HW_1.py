# Задача 1: Подсчет суммы четных чисел от 1 до N. Напишите программу, используя цикл, 
# которая находит сумму всех четных чисел в диапазоне от 1 до заданного числа N.

def Summa(num):
    summ = 0
    for i in range(num+1):
        if (i%2) == 0:
            summ = i + summ
        else: continue
    return summ


num = int(input('Введите число: '))
summa = Summa(num)
print(f'Сумма четных чисел = {summa}')