# https://ru.wikipedia.org/wiki/Гипотеза_Эйлера
import timeit
start = timeit.default_timer()
for a in range (1, 151):
    for b in range (a, 151):
        for c in range(b, 151):
            for d in range (c, 151):
                x = a**5 + b**5 + c**5 + d**5
                if int(x**0.2) == round(x**0.2, 9):
                    print(a,b,c,d, int(x**0.2), sum((a,b,c,d, int(x**0.2))))
                    print('Done with {:.2f} sec.'.format(timeit.default_timer() - start))
                    exit(0)
    print('{:.2f} % processed'.format(a/151*100))