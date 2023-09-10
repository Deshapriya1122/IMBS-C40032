# i) Enter student marks into an array (at least 15 elements)
student_marks = []
for i in range(15):
    mark = int(input(f"Enter the mark for student {i + 1}: "))
    student_marks.append(mark)

# ii) Find the highest mark using a simple sorting algorithm (e.g., selection sort)
def find_highest_mark(arr):
    n = len(arr)

    if n == 0:
        return None  # Handle the case when the array is empty

    for i in range(n - 1):
        max_index = i
        for j in range(i + 1, n):
            if arr[j] > arr[max_index]:
                max_index = j
        arr[i], arr[max_index] = arr[max_index], arr[i]  # Swap elements

    highest_mark = arr[0]  # The highest mark will be the first element after sorting
    return highest_mark

highest_mark = find_highest_mark(student_marks)

if highest_mark is not None:
    print(f"The highest mark is {highest_mark}.")
else:
    print("The array is empty.")
