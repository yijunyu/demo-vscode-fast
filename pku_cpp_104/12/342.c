/**
* ???1000012725
* ??: ??
* ???1134 ??
* ?????????2?15????????????????
* ??????????????????????????
**/

int main()
{
	
	int i , j , f = 0;                      //??i?j??????f???????????
	while(f == 0)                           //?f?0??????????
	{
		int a[16] , count = 0;              //????a[16]?????count???????????????0
		for (i = 0; ; i ++)      
		{
			cin >> a[i];                    //????a[i]??
			if (a[i] == 0)                  //??a[i]???0
			{
				cout << count << endl;      //??count?????
				break;
			}
			else if (a[i] == -1)            //?a[i]?-1????????f??1????????
			{
				f = 1;
				break;
			}
			else                            //????????
			{
				for (j = 0; j < i; j ++)
				{
					if ((a[i] == a[j] * 2) || (a[j] == a[i] * 2))  //?????????????????1
					count ++;
				}
			}
		}
	}
	return 0;
}
