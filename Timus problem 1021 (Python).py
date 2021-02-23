# https://acm.timus.ru/problem.aspx?space=1&num=1021
import bisect


def binary_search(lst, elm):
    index = bisect.bisect_left(lst, elm)
    if index < len(lst):
        if lst[index] == elm:
            return True
    return False


n = int(input())
l1 = []
for i in range(n):
    l1.append(int(input()))

m = int(input())
l2 = []
for i in range(m):
    l2.append(int(input()))

for i in range(m):
    diff = 10000 - l2[i]
    if binary_search(l1, diff):
        print("YES")
        exit(0)
print('NO')
