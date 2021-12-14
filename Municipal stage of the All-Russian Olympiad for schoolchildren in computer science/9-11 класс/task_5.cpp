// Задание № 5 муниципального этапа олимпиады школьников по информатике
// все тесты этот код не проходит, алгоритм не оптимален
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    int n;
    cin >> n;
    int x;
    vector<int> first;
    for (int i = 0; i < n; i++)
    {
        cin >> x;
        first.push_back(x);
    }
    int m;
    cin >> m;
    vector<int> second;
    for (int i = 0; i < m; i++)
    {
        cin >> x;
        second.push_back(x);
    }
    vector<int> result;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result.push_back(first[i] + second[j]);
        }
    }
    sort(result.begin(), result.end());
    int k;
    cin >> k;
    std::cout << result[k-1];
}
