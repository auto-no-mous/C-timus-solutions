# https://acm.timus.ru/problem.aspx?space=1&num=1026

n = int(input())
arr = [0] * 5001
for i in range(n):
    arr[int(input())] += 1
# form pairs: number - count of these numbers
pairs = []
for i in range(5001):
    if arr[i] != 0:
        pairs.append([i, arr[i]])
# sort pairs
pairs.sort(key=lambda x: x[0])
# build final array
result = []
for i in pairs:
    result.extend([i[0]] * i[1])
# show answer
input()
m = int(input())
for i in range(m):
    print(result[(int(input())) - 1])
