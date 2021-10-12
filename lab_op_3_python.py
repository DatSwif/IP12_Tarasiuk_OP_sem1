a = int(input("Number: "))
p = int(input("Root: "))
eps = 10 ** ((-1) * int(input("Precision: ")))
x = 1
n = 0
xprev = 10 ** 15
while abs(xprev - x) > eps:
    n += 1
    xprev = x
    x = 1/p*((p-1)*xprev+a/xprev**(p-1))
print("Result:", x, "Iterations:", n)
