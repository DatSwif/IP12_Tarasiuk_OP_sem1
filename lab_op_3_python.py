import math
x = 1
num = float(input('number:'))
p = float(input('root:'))
prec = float (input('precision:'))
mark = num ** (1/p)
while abs(x - mark) > prec:
    x = 1/p*math.floor((p-1)*x+num/(x**(p-1)))
    print(x)
print('calculated with iterations:', x)
print('the actual value', mark)
