#https://acm.timus.ru/problem.aspx?space=1&num=1079

allInput = []
n = int(input())
while n != 0:
    allInput.append(n)
    n = int(input())
n = max(allInput)

dp = [0] * (n + 1)
dp[1] = 1
for i in range(2, n + 1):
    if i % 2 == 0:
        dp[i] = dp[i // 2]
    else:
        dp[i] = dp[i // 2] + dp[i // 2 + 1]

for x in allInput:
    print(max(dp[:x+1]))
