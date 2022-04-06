# https://acm.timus.ru/problem.aspx?space=1&num=2142

a, b, c = tuple(map(int, input().split()))
x, y, z = tuple(map(int, input().split()))
heap = 0
if (a - x) > 0:
    heap += a - x
else:
    c += a - x
if (b - y) > 0:
    heap += b - y
else:
    c += b - y
if (c + heap) >= z and (c >= 0):
    print('It is a kind of magic')
else:
    print('There are no miracles in life')
