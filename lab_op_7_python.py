import random

def form():
    array = []
    size = int(input('size of array: '))
    for i in range(size):
        array.append(random.randint(-999,999))
    return array

def small(array):
    small = array[0]
    for i in range(1, len(array)):
        if array[i] < small:
            small = array[i]
    return small

def big(array):
    big = array[0]
    for i in range(1, len(array)):
        if array[i] > big:
            big = array[i]
    return big

def change_the_array(array, diff):
    for i in range((len(array) + 1) // 2):
        array[i*2] = diff

def write(array):
    string = ''
    for i in range(len(array)):
        string += str(array[i]) + ' '
    print(string)

array = form()
write(array)
diff = big(array) - small(array)
print(diff)
change_the_array(array, diff)
write(array)
