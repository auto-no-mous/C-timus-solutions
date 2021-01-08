# https://acm.timus.ru/problem.aspx?space=1&num=1209
# for quick search in sorted list
def binary_search(lst, element):
    start = 0
    end = len(lst) - 1
    while start <= end:
        mid = (start + end) // 2
        if element == lst[mid]:
            return mid
        elif element > lst[mid]:
            start = mid + 1
            continue
        else:
            end = mid - 1
    return -1


# get input data
n = int(input())
inp = []
for i in range(n):
    inp.append(int(input()))

# lets find all ones in sequence, other positions - zeroes
currentOne = 0
ones = []
limit = 2 ** 16
for zeroes in range(limit):
    ones.append(currentOne)
    currentOne = currentOne + 1 + zeroes

# show answer
answer = ''
for x in inp:
    if binary_search(ones, x - 1) != -1:
        answer += '1 '
    else:
        answer += '0 '
print(answer)
