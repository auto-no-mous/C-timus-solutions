# https://acm.timus.ru/problem.aspx?space=1&num=1263
NM=input().split()
N=int(NM[0])
M=int(NM[1])
q=[0]*N
for x in range(M):
    q[int(input())-1] += 1
for x in q:
    print('{:.2f}%'.format(x/M*100))
