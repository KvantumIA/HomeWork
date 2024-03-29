# Фибоначчи через рекурсию: Напишите рекурсивную функцию для вычисления числа 
# Фибоначчи с индексом n. Напоминаю, что последовательность Фибоначчи определяется как: 
# F(0) = 0, F(1) = 1 и F(n) = F(n-1) + F(n-2) для n > 1.

# 0 1 2 3 4 5 6 7  8 
# 0 1 1 2 3 5 8 13 21

def Fibon(num):
    if num == 0:
        return 0
    elif num == 1:
        return 1
    return Fibon(num - 1) + Fibon (num - 2)

num = 5
print(Fibon(num))