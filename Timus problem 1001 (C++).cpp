#include <iostream>
#include <list>
#include <cmath>

using namespace std;

int main()
{ 
	long long n;
	list<long long> arr;
	while (scanf_s("%lld", &n) != EOF)
	{
		arr.push_front(n);
	}

	for (long long j: arr)
		printf("%.4f\n", sqrt(j));
	return 0;
}
