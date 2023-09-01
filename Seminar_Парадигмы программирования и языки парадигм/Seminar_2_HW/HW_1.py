# **Структурное программирование:

# Трассировка пути в лабиринте:**
# __
# Задание: Создайте функцию, которая принимает двумерный массив (лабиринт) и начальную и 
# конечную точки. Функция должна возвращать путь от начальной до конечной точки или сообщение, 
# что путь невозможен.

# Входные данные:
#   Двумерный массив размера MxN, где '0' - это проход, а '1' - это стена.
#   Координаты начальной и конечной точки.
# Выходные данные:
#   Массив координат пути или сообщение об ошибке.

def FindExit(list):
    listExit = []
    for i in range(len(list)):
        for j in range(len(list[i])):
            if list[i][j] == 0:
                listExit.append(i)
                listExit.append(j)
            else:
                continue
    return listExit

def Slices(listExit):   
    result = [listExit[i:i+2] for i in range(0, len(listExit), 2)]
    print(f'Путь прохода: {result}')




list = [[1, 0, 1, 1], 
        [1, 0, 0, 1], 
        [1, 1, 0, 0],
        [1, 1, 1, 0]]

print('Двухмерный массив - лабиринт')
for i in list:
    print(i)
print()
listExit = FindExit(list)
Slices(listExit)