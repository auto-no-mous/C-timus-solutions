# problem 4

n, m = list(map(int, input().split()))
matrix = []
for i in range(n):
    matrix.append(list(map(int, input().split())))
# scan for zeroes
zeroes = []
for i in range(n):
    for j in range(m):
        if matrix[i][j] == 0:
            zeroes.append((i, j))
last_cell = matrix[n - 1][m - 1]

# calculate moving cost for every cell
# top corner line:
for i in range(1, m):
    matrix[0][i] += matrix[0][i - 1]
# left corner line:
for i in range(1, n):
    matrix[i][0] += matrix[i - 1][0]

# other matrix
for i in range(1, n):
    for j in range(1, m):
        matrix[i][j] += min(matrix[i - 1][j], matrix[i][j - 1])

# collect all available answers
answers = [matrix[n - 1][m - 1]]
for x in zeroes:
    answers.append(matrix[x[0]][x[1]] + last_cell)
print(min(answers))
