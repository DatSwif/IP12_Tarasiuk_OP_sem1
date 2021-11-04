num = int(input())
binary = 0
while num > 0: 
    binary *= 10
    binary += num % 2
    num //= 2
power = 0
res = 0
while binary > 0:
    if binary % 2 != 0:
        res += 2 ** power
    power += 1
    binary //= 10
print(res)
