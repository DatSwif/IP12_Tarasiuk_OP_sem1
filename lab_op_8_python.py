import random

def form():
    array = []
    height = int(input('height: '))
    width = int(input('width: '))
    for i in range(height):
        row = []
        for j in range(width):
            row.append(random.randrange(-999,999))
        array.append(row)
    return array

def change(array):
    transposed = []
    for i in range(len(array[0])):
        row = []
        for j in range(len(array)):
            row.append(array[j][i])
        transposed.append(row)
    return transposed

def write(array):
    print()
    for row in array:
        print()
        for item in row:
            print('%5.0f' % (item), end = '')
            
array = form()
write(array)
array = change(array)
write(array)
