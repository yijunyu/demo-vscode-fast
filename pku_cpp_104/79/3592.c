

int main()
{
	int n,m,i,j,a[301],x;
	while(cin>>n>>m,(n!=0)&&(m!=0))//????????//
	{
		a[0]=0;
		for(i=1;i<=n;i++)//???????????????1//
			a[i]=1;
		for(x=1,i=0;i<n-1;i++)//????n-1????????n-1?//
		{
			for(j=0;j<m;x++)
			{
				if(x>n)
					x=x%n;//??x??n//
				if(a[x]==1)
					j++;//???????1???j?1.j??????????????m?????????//
			}
			a[x-1]=0;//????????//
		}
		for(i=1;i<=n;i++)
			if(a[i]==1)
				cout<<i<<endl;//??????//
	}
	return 0;}