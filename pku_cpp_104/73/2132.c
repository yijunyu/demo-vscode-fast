int main()
{
	//********************************?????????0?n-1
	int a[6][6],b[6][6],c[6][6];//???????????,?????????
	int i=1,j=1,temp1=0,temp2=0;
	for (i=1;i<=5;i++)
	{
		for (j=1;j<=5;j++)
		{
			cin>>a[i][j];
			c[i][j]=b[i][j]=a[i][j];
		}
	}
	
	//**********************i?????5
	for (i=1;i<=5;i++)//????????????????????????
	{
		//****************************????for????????
		for(int k=1;k<=4;k++)
		{
			for (j=1;j<=5-k;j++)
			{
				if (a[i][j]>a[i][j+1])
				{
					temp1=a[i][j];
					a[i][j]=a[i][j+1];
					a[i][j+1]=temp1;
				}
			}
		}
	}//???,???a[i][j]?,?????????????a[i][5]????
	
	//**********************j?????5
	for (j=1;j<=5;j++)//???????????????????????
	{
		//****************************??
		for(int k=1;k<=4;k++)
		{
			for (i=1;i<=5-k;i++)
			{
				if (b[i][j]>b[i+1][j])
				{
					temp2=b[i][j];
					b[i][j]=b[i+1][j];
					b[i+1][j]=temp2;
				}
			}
		}
	}//???,???b[i][j]?,?????????????b[5][j]????
	
	
	int flag=0;
	for (i=1;i<=5;i++)//?c[i][j]??????????
	{
		for (j=1;j<=5;j++)
		{
			if (c[i][j]==a[i][5]&&c[i][j]==b[1][j])//?????c[i][j]			
			{
				cout<<i<<" "<<j<<" "<<c[i][j]<<endl;
				flag++;
			}
		}
	}
	
	if (flag==0)
		cout<<"not found"<<endl;
	return 0;
}