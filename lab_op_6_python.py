def distance(x,y):
    return (x*x + y*y)**0.5

def cycle(dist_near):
    for i in range(2, count + 1):
        x = float(input('x{}: '.format(i)))
        y = float(input('y{}: '.format(i)))
        dist_curr = distance(x, y)
        if dist_curr < dist_near:
            dist_near = dist_curr
            ind_near = i
    print('nearest point to (0;0) is', ind_near)

i = 1
count = int(input('how many points?:'))
x = float(input('x{}: '.format(i)))
y = float(input('y{}: '.format(i)))
dist_near = distance(x, y)
ind_near = 1
cycle(dist_near)
