//************************************************************************************
//*    name: 1.cpp                                                                   *
//*    author:??                                                                   *
//*    date: 2013-10-30                                                              *
//*    description???????????????????????????????     *
//************************************************************************************
int main ()
{
	int t ;//???????????????
	int a[16] , i ,j,k,count;
	while(cin>>t)
	{
		count = 0;
		if(t<0) return 0 ;//??-1?????
		a[0]=t ;//????????????????
		for(i=1;i<16;i++)
		{
			cin >> a[i] ;
			if(a[i]==0) break ;//???????0????
		}
		for (j=0 ;j<i;j++)//???i???????
		{
			for(k=0;k<i;k++)
			{
				if(a[k]==2*a[j]) count++ ;//????????????????????1
			}
		}
		cout << count <<endl ;
	}
}




