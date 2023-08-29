# Задача 3: Вычисление факториала числа. Напишите программу, которая находит факториал заданного числа N 
# с использованием рекурсии или встроенных функций.

# 1*2*3*4*5 = 120

def Factorial(Num):
    if (Num == 1 or Num == 1):
        return 1
    else:
        return Num*Factorial(Num-1)



Num = int(input('Введите число: '))
print(Factorial(Num))