# Требуется найти в массиве list_1 самый близкий по величине элемент к заданному числу k и вывести его.

        # 0  1  2  3  4  5  6   7
list_1 = [1, 2, 3, 4, 5]
k = 6

# Введите ваше решение ниже


# for j in range(len(list_1)-1):
#         if abs(k - list_1[j-1]) < abs(k - list_1[j]) < abs(k - list_1[j+1]):
#             print(list_1[j])
#             break
#         else:
#             continue

#------------------------------------------------------------

# number = 0
# for i in range(len(list_1)):
#     if (k - list_1[i]) < k - number and k - list_1[i]>0:
#         number = i

# print(list_1[number])

#------------------------------------------------------------

b = [abs(list_1[i] - k) for i in range(len(list_1))]
print(list_1[b.index(min(b))])