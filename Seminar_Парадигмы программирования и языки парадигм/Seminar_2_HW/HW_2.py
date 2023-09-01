# **Процедурное программирование:

# Разбиение массива на подмассивы:**
# __
# Задание: Напишите функцию, которая принимает массив чисел и значение X. Функция должна 
# возвращать массив подмассивов так, чтобы сумма чисел в каждом подмассиве была меньше или равна X.

# Входные данные:
#   Массив чисел длиной N.
#   Число X.
# Выходные данные:
#   Массив подмассивов.

# def Split(N, X):
#     sub_massive_new = []
#     summa = 0
#     for i in range(len(N)):
#         if (summa+N[i]) > X:
#             result = [N[i:i] for i in range(0, len(N), i)]
#         elif summa <= X:
#             summa += N[i]
#             sub_massive_new.append(N[i])
#     return result

def SlicesN(N, X):
    summa = 0
    count = 0
    for i in range(len(N)):
        if (summa+N[i]) > X:
            result = [N[j:j+i] for j in range(0, len(N), i)]
        elif summa <= X:
            summa += N[i]
            count += 1
    return result




N = [1, 2, 3, 4, 5, 6, 7, 8, 9]
X = 9
sub_massive_new = SlicesN(N, X)
print(sub_massive_new)