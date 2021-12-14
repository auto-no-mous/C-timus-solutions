# problem 2

def is_perfect(m):
    flag = False
    rows = []
    for i in range(3):
        start = i * 3
        end = i * 3 + 3
        rows.append(sum(m[start:end]))
    if rows[0] == rows[1] and rows[1] == rows[2]:
        columns = []
        for i in range(3):
            top = i
            mid = i + 3
            bot = i + 6
            columns.append(sum((m[top], m[mid], m[bot])))
        if columns[0] == columns[1] and columns[1] == columns[2]:
            flag = True
    return flag


def show_matrix(m):
    for i in range(3):
        start = i * 3
        end = i * 3 + 3
        print(' '.join(list(map(str, m[start:end]))))


matrix = []
for i in range(3):
    matrix.extend(list(map(int, input().split())))
    original = matrix.copy()
for i in range(9):
    matrix = original.copy()
    for j in range(9):
        matrix[i], matrix[j] = matrix[j], matrix[i]
        if is_perfect(matrix):
            show_matrix(matrix)
            exit(0)
        else:
            matrix[i], matrix[j] = matrix[j], matrix[i]
