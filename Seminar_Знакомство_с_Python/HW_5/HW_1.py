# Напишите функцию f, которая на вход принимает два числа a и b, и возводит число a в целую степень b с помощью рекурсии.

# Функция не должна ничего выводить, только возвращать значение.

def Exponentation(a,b):
    if b == 0:
        return 1
    return a * Exponentation(a, b - 1)


a = 3
b = 5

print(Exponentation(a, b))