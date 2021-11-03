res = 1
x = float(input("x:"))
valid = True
for i in range(1,7):
    if valid == True:
        if x - (2**i - 1) == 0:
            print("Division by zero")
            valid = False
        else:
            res *= (x-2**i)/(x-2**i+1)
            if i == 6:
                print("Result:", res)
