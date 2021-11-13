# https://acm.timus.ru/problem.aspx?space=1&num=1011
# test input 13 14.1
import math


inp = list(map(float, input().split()))
lower_limit = inp[0] + 0.000001
upper_limit = inp[1] - 0.000001
population = 1
while True:
    P = math.ceil(population * lower_limit / 100)
    Q = math.floor(population * upper_limit / 100)
    if P <= Q:
        print(population)
        break
    else:
        population += 1
