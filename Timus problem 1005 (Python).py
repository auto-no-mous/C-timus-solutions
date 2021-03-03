# https://acm.timus.ru/problem.aspx?space=1&num=1005
# solution with itertools

import itertools

n = int(input())
heap = list(map(int, input().split()))

limit = n // 2 if n % 2 == 0 else n // 2 + 1
total = sum(heap)
diff = total

for i in range(1, limit+1):
    for j in itertools.combinations(heap, i):
        current = abs(total - sum(j)*2)
        if current < diff:
            diff = current
print(diff)


# some test
# 20
# 101 51 51 3 2 2 40 23 895 345 4 38 678 97 12 234 55 8054 26 108
# answer is 5289