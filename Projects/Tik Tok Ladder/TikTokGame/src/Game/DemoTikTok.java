package Game;

import java.util.*;

public class DemoTikTok {
	public static void main(String[] args) {
		Board b = new Board();
		Scanner sc = new Scanner(System.in);
		while (true) {
			System.out.println("Player 1 turn");
			int a = sc.nextInt();
			int c = sc.nextInt();
			b.Player1(a, c);
			if(b.Winner()) 
			{
				System.out.println("Player 1 Won");
				break;
			}
			System.out.println("Player 2 turn");
			int m = sc.nextInt();
			int n = sc.nextInt();
			b.Player2(m, n);
			if(b.Winner()) 
			{
				System.out.println("Player 2 Won");
				break;
			}

		}
	}

}
