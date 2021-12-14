# задача № 4 муниципального этапа олимпиады школьников
# по информатике, 7-8 классы, Крым
#
# test: 0 0 2 5 9 9
# answer = 592900
import math
import itertools


def is_square(n):
    s = math.sqrt(n)
    if s.is_integer():
        return True
    else:
        return False


cards = input().split()
squares = []
for x in itertools.permutations(cards):
    number = int(str("".join(x)))
    if is_square(number):
        squares.append(number)
filtered = itertools.filterfalse(lambda x: x < 100000, squares)
filtered = list(filtered)
filtered.sort()
print(filtered[0])
