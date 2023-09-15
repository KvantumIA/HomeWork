# Реализовать алгоритм пирамидальной сортировки (сортировка кучей).


def heapify(my_list, n, i):
    max = i 
    left = 2 * i + 1
    right = 2 * i + 2
    
    if left < n and my_list[left] > my_list[max]:
        max = left
    
    if right < n and my_list[right] > my_list[max]:
        max = right
    
    if max != i:
        my_list[i], my_list[max] = my_list[max], my_list[i]
        heapify(my_list, n, max)


def heap_sort(my_list):
    n = len(my_list)
    
    for i in range(n // 2 - 1, -1, -1):
        heapify(my_list, n, i)
    
    for i in range(n - 1, 0, -1):
        my_list[i], my_list[0] = my_list[0], my_list[i]
        heapify(my_list, i, 0)


my_list = [12, 11, 13, 5, 6, 7]
heap_sort(my_list)
print("Отсортированный массив:")
print(my_list)