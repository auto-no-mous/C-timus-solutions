# https://acm.timus.ru/problem.aspx?space=1&num=1010

n = int(input())
points = [0] * n
best_pair = (0, 0, 0)

for i in range(n):
    x = int(input())
    points[i] = x
    if i == 0:
        continue
    else:
        length = abs(x - points[i - 1])
        if best_pair[2] < length:
            best_pair = i - 1, i, length

print(str(best_pair[0] + 1) + ' ' + str(best_pair[1] + 1))
