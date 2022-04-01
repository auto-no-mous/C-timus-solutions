# https://acm.timus.ru/problem.aspx?space=1&num=1014

n = int(input())
used = []
if n == 0:
    print(10)
    exit(0)
elif n == 1:
    print(1)
    exit(0)

while n > 1:
    for i in range(9, 1, -1):
        if n % i == 0:
            used.append(i)
            n //=i
            break
    if i == 2:
        break

if n > 1:
    print(-1)
else:
    used = list(map(str, used))
    used.sort()
    print(''.join(used))
