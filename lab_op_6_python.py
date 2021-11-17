def distance(x,y):
	return (x*x + y*y)**0.5

def getxy():
        global x, y
        print('-------------')
        x = float(input('x{}: '.format(i)))
        y = float(input('y{}: '.format(i)))

def getfirst():
        global i, x, y
        i = 1
        count = int(input('how many points?:'))
        getxy()
        
def out():
        print('-------------')
        print('nearest point to (0;0) is #', ind_near, sep = '')

def cycle():
        global dist_near, x, y, dist_curr, ind_near, i
        ind_near = 1
        for i in range(2, count + 1):
                getxy()
                dist_curr = distance(x, y)
                if dist_curr < dist_near:
                        dist_near = dist_curr
                        ind_near = i
                        
getfirst()
dist_near = distance(x, y)
cycle()            
out()
