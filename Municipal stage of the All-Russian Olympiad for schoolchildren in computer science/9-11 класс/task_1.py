# problem 1

first = list(map(int, input().split()))
second = list(map(int, input().split()))
f_advantage, s_advantage = 0, 0
for i in range(3):
    if first[i] > second[i]:
        f_advantage += 1
    elif second[i] > first[i]:
        s_advantage += 1
if f_advantage >= 2:
    print(1)
elif s_advantage >= 2:
    print(2)
else:
    print(0)
