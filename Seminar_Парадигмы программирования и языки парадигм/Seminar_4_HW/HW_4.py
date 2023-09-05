# Замыкание: Создайте функцию, которая принимает некоторое число n и возвращает функцию, которая 
# прибавляет n к своему аргументу. Продемонстрируйте использование этой функции-замыкания.

def Closing(x):
    def fastening(y):
        return x + y
    return fastening

num = Closing(10)
result = num(7)
print(result)