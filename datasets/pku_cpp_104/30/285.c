/**
* @file 1000010424_3.cpp
* @author ???
* @date 2010?10?13
* @description
* ??????: ?7???????
*/



int main()
{
	int n, i, j, number = 0, sum = 0;							//???????n?????i??????j?????number???0????sum?	

	cin >> n;													//?????

	for(j = 0; number <= n; j++)								//????0???
		for(i = 0; ; i++)										//????0???
		{	
			if(i == 10) break;									//?????????j?

			number = j * 10 + i;								//?number???

			if(number > n) break;								//??????break?

			if(number % 7 == 0 || i == 7 || j == 7) continue;	//???7???????

			sum += number * number;								//??????
		}

	cout << sum << endl;										//?????

	return 0;
}