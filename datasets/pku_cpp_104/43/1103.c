//***************************
//???????????? ?cpp4?
//??????
//???1300012712
//???2013?10?23?
//***************************
int main ()
{
	int m, x, i, j;           // m???????? x?????? i j??????
	cin >> m;
	for (x = 3; x <= m/2; x = x + 2)    // ?????? ???????????m/??
	{
		for (i = 2; i <= sqrt(x); i++)   // ?2?x??????x?????
		{
			if (x % i == 0)
				break;    // ??x?????i?? ????
		}
		if (i > sqrt(x))   // ????????? ?x???
		{
			for (j = 2; j <= sqrt(m-x); j++)  // ??m-x?????
			{
				if (((m - x) % j) == 0) 
					break;  // ??m-x?????j?? ????
			}
			if (j > sqrt(m - x))  // ?????????? m-x????
				cout << x << " " << m - x << endl;  // m?m-x??????????
		}
	}
	return 0;
}