# https://acm.timus.ru/problem.aspx?space=1&num=1086
# solution with sieve of Eratosthenes algorithm

def easy_numbers(n):
    global lst
    lst = []
    # first of all, get all possible numbers
    for i in range(n + 1):
        lst.append(i)
    # 0 and 1 is not an easy numbers, so set them with zero
    lst[1] = 0
    # start with 2
    i = 2
    while i <= n:
        if lst[i] != 0:
            j = i + i
            while j <= n:
                lst[j] = 0
                j = j + i
        i += 1
    # convert list to the set, to remove duplicate values
    lst = set(lst)
    # remove last zero
    lst.remove(0)
    return (lst)

n = []
k = int(input())
for i in range (k):
    n.append(int(input()))

numbers = list(easy_numbers(170000))
numbers.sort()
for i in n:
    print(numbers[i-1])