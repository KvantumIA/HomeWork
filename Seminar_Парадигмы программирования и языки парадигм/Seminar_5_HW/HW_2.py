# Задача 2: Напишите программу, которая сортирует список чисел методом сортировки слиянием.

# Сортировка слиянием - это эффективный алгоритм сортировки, который разбивает список на две половины, 
# сортирует их отдельно, а затем объединяет в отсортированный список. Задача состоит в том, 
# чтобы написать программу, которая будет сортировать список чисел методом сортировки слиянием.

# Пример решения:

# Программа принимает на вход список чисел, который нужно отсортировать.
# Если список состоит из одного элемента или пуст, он считается уже отсортированным.
# В противном случае список разделяется на две половины.
# Рекурсивно вызывается сортировка слиянием для каждой половины.
# Затем отсортированные половины сливаются в один отсортированный список.
# Конечный отсортированный список возвращается.


def merge_sort(nums):
	if len(nums) > 1:
		mid = len(nums) // 2
		left = nums[:mid]
		right = nums[mid:]
		merge_sort(left)
		merge_sort(right)
		i = j = k = 0
		while i < len(left) and j < len(right):
			if left[i] < right[j]:
				nums[k] = left[i]
				i += 1
			else:
				nums[k] = right[j]
				j += 1
			k += 1
		while i < len(left):
			nums[k] = left[i]
			i += 1
			k += 1
		while j < len(right):
			nums[k] = right[j]
			j += 1
			k += 1



nums = [1, 5, 6, 7, 11, 2, 3, 4, 6, 9, 12, 15]

merge_sort(nums)
print(nums)