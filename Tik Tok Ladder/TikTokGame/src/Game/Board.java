package Game;

public class Board 
{
	char[][] board=new char[3][3];
	public Board()
	{
		//char[][] board=new char[3][3];
//		for(int i=0;i<board.length;i++)
//			for(int j=0;j<board.length;j++)
//		{
//			board[i][j]='';
//		}
		for(int i=0;i<board.length;i++) 
		{
			for(int j=0;j<board.length;j++)
				{
					System.out.print(board[i][j]+" | ");
				}
			System.out.println();
			}
		System.out.println();
		System.out.println();
	     }
	public void Player1(int a,int b) 
	{
		int i=a,j=b;
		char p ='X';
		if(board[i][j]=='X'||board[i][j]=='O') 
		{
			System.out.println("invalid");
			return;
		}
		board[i][j]=p;
		for(int d=0;d<board.length;d++) 
		{
			for(int f=0;f<board.length;f++)
				{
					System.out.print(board[d][f]+" ");
				}
			System.out.println();
		}
	}
	public void Player2(int a,int b) 
	{
		int i=a,j=b;
		char p ='O';
		if(board[i][j]=='O'||board[i][j]=='X') 
		{
			System.out.println("invalid");
			return;
		}
		board[i][j]=p;
		for(int d=0;d<board.length;d++) 
		{
			for(int f=0;f<board.length;f++)
				{
					System.out.print(board[d][f]+" ");
				}
			System.out.println();
		}
	}
	public Boolean Winner() 
	{
		if(board[0][0]==board[0][1]&&board[0][1]==board[0][2]&&board[0][0]!='\u0000') 
		{
		return true;
		}
		else if(board[0][0]==board[1][1]&&board[1][1]==board[2][2]&&board[0][0]!='\u0000') 
		{
		return true; 
		}
		else if(board[1][0]==board[1][1]&&board[1][1]==board[1][2]&&board[1][0]!='\u0000') 
		{
			return true; 
		}
		else if(board[2][0]==board[2][1]&&board[2][1]==board[2][2]&&board[2][2]!='\u0000') 
		{
			return true; 
		}
		else if(board[0][0]==board[1][0]&&board[1][0]==board[2][0]&&board[2][0]!='\u0000')
		{
			return true; 
		}
		else if(board[0][1]==board[1][1]&&board[1][0]==board[2][1]&&board[2][1]!='\u0000') 
		{
			return true;
		} 
		else if(board[0][2]==board[1][2]&&board[1][2]==board[2][2]&&board[2][2]!='\u0000') 
		{
			return true;
		} 
		return false;
	}
}
