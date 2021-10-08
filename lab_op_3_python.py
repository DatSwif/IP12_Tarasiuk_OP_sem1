num = float(input('number: '))
p = int(input('root: '))
eps = 10 ** (-1*int(input('10^(-eps), eps=precision: ')))

def ceil_pos(a, p, num):
    if ((a-1) ** p < num) and (a ** p >= num):
        return None #just right
    elif (a-1) ** p >= num:
        return True #too big
    else:
        return False #too small

def mult(p, n):
    res = 1
    for i in range(0, n):
        res *= (1/p-i)
    return res

def fact (n):
    res = 1.0
    for i in range(1,n+1):
        res *= i
    return res
    
def add (a, p, b, n):
    power = (b/a**p)**n
    other = mult(p, n)/fact(n)
    return power*other

p2 = -1
a = 0
while ceil_pos(a, p, num) == False:
    p2 += 1
    a = 2 ** p2
while ceil_pos(a, p, num) != None:
    if ceil_pos(a, p, num) == True:
        p2 -= 1
        a -= 2 ** p2
    elif ceil_pos(a, p, num) == False:
        p2 -= 1
        a += 2 ** p2

b = num - a**p
n = 1
ans = 1
while abs(add(a, p, b, n)) >= eps:
    ans += add(a, p, b, n)
    n += 1
print('approximation:', ans*a)
