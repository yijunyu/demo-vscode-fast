
int main()
{
 	int num[16] = {0}, sum = 0; //num???????sum?????? 
 	int i = 0; //i????? 
 	
 	while ( 1 )
 	{
        i = 0;   //???????????? 
        sum = 0;
    
  	 	while ( 1 )
		{
		  cin >> num[i]; //???? 
		  
  	 	  if ( num[i] == -1 ) //??????-1?????? 
  	 	  	 return 0;
  	 	  if ( num[i] == 0 )  //??????0?????? 
			 break;
		  i++;	 //i?? 
	    }
		
		for ( int j = 0; j < i - 1; j++ )  //j?????? 
		{
		 	for ( int k = j + 1; k < i; k++ ) //k?????? 
		 	{
 	  		 	if ( num[j] == 2 * num[k] || num[k] == 2 * num[j] )
 	  		 	   sum++;		//???????????sum?1 
	   		} 	
	 	}
		 
		cout << sum << endl;  
   	
  	}
  	
  	return 0;
}