# https://acm.timus.ru/problem.aspx?space=1&num=1313
# get input data
n = int(input())
matrix = []
for i in range(n):
    matrix.append(list(map(int, input().split())))
answer = ''
# build diagonals from left-side of matrix
for vertical in range(n):
    y_offset = vertical
    for x_offset in range(0, vertical + 1):
        answer += str(matrix[y_offset][x_offset]) + ' '
        y_offset -= 1
# build other diagonals from bottom of matrix
for horizontal in range(1, n):
    x_offset = horizontal
    for y_offset in range(n - 1, horizontal - 1, -1):
        answer += str(matrix[y_offset][x_offset]) + ' '
        x_offset += 1
print(answer)
