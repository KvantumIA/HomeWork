def Binar_find(arr, num):
    left, right = 0, len(arr) - 1
    
    while left <= right:
        mid = left + (right - left) // 2
        
        if arr[mid] == num:
            return mid
        elif arr[mid] < num:
            left = mid + 1
        else:
            right = mid - 1
    return -1



list = [1, 3, 5, 8, 11, 16, 21, 22, 25, 28]
num = 11
result = Binar_find(list, num)

if result != -1:
    print(f'Индекс числа {num} = {result}')
else:
    print(f'Число {num} не найдено в списке.')