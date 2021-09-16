print('a, index of a, b, index of b, how many elements')
a = int(input())
ia = int(input())
b = int(input())
ib = int(input())
n = int(input())

d = (a - b) / (ia - ib)

a1 = a - d * (ia - 1)
an = a1 + d * (n - 1)

suma = (a1 + an) * n / 2

print(int(str(suma)[:-2]))
