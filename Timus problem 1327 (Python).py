# https://acm.timus.ru/problem.aspx?space=1&num=1327
a = int(input())
b = int(input())
if (a % 2 != 0) or (b % 2 != 0):
    print((b - a)//2 + 1)
else:
    print((b - a) // 2)
