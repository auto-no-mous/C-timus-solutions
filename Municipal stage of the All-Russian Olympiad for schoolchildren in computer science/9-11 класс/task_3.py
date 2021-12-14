# problem 3

def is_in_bounds(p, n, m):
    result = True
    if p[0] < 1 or p[0] > n:
        result = False
    if p[1] < 1 or p[1] > m:
        result = False
    return result


n, m = list(map(int, input().split()))
pos = list(map(int, input().split()))
x = int(input())
blocks = {}
for i in range(x):
    inp = input().split()
    coordinates = tuple(map(int, (inp[0], inp[1])))
    if blocks.__contains__(coordinates):
        blocks[coordinates] += inp[2]
    else:
        blocks[coordinates] = inp[2]
path = input()
success = True
for x in path:
    # check move up
    if x == "U":
        old_pos = tuple(pos)
        if blocks.__contains__(old_pos):
            if "U" in blocks[old_pos]:
                success = False
                break
        next_pos = (old_pos[0] - 1, old_pos[1])
        if blocks.__contains__(next_pos):
            if "D" in blocks[next_pos]:
                success = False
                break
        if not is_in_bounds(next_pos, n, m):
            success = False
            break
        pos = list(next_pos)
        continue
    # check move down
    if x == "D":
        old_pos = tuple(pos)
        if blocks.__contains__(old_pos):
            if "D" in blocks[old_pos]:
                success = False
                break
        next_pos = (old_pos[0] + 1, old_pos[1])
        if blocks.__contains__(next_pos):
            if "U" in blocks[next_pos]:
                success = False
                break
        if not is_in_bounds(next_pos, n, m):
            success = False
            break
        pos = list(next_pos)
        continue
    # check move left
    if x == "L":
        old_pos = tuple(pos)
        if blocks.__contains__(old_pos):
            if "L" in blocks[old_pos]:
                success = False
                break
        next_pos = (old_pos[0], old_pos[1] - 1)
        if blocks.__contains__(next_pos):
            if "R" in blocks[next_pos]:
                success = False
                break
        if not is_in_bounds(next_pos, n, m):
            success = False
            break
        pos = list(next_pos)
        continue
    # check move right
    if x == "R":
        old_pos = tuple(pos)
        if blocks.__contains__(old_pos):
            if "R" in blocks[old_pos]:
                success = False
                break
        next_pos = (old_pos[0], old_pos[1] + 1)
        if blocks.__contains__(next_pos):
            if "L" in blocks[next_pos]:
                success = False
                break
        if not is_in_bounds(next_pos, n, m):
            success = False
            break
        pos = list(next_pos)
        continue
if success:
    print("SUCCESS")
else:
    print("FAIL")
