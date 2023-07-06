import java.util.*;
class LibraryDemo1
{
	Scanner sc = new Scanner(System.in);
	
	Node head;
	
	static class Node
	{
		Node next;
		int id;
	    String name;
	    String author;
	    String publisher;
		
		Node()
		{
			
		}
		Node(int id,String name,String author,String publisher)
		{
			this.id = id;
			this.name = name;
			this.author = author;
			this.publisher = publisher;
		    next =  null;
		}
	}
	
	public void insert()
	{
		int id=0;
		String name="";
		String author="";
		String publisher="";
		System.out.println("Enter Book ID");
		try{
        id = sc.nextInt();
		Node n = head;
		
		   while( n != null )
		   {
			   if( id == n.id )
			   {
				   System.out.println("These Id is already in list try another");
				   return;
			   }
			n=n.next;
			}
       			
				   
		
	    System.out.println("Enter name of Book");
		name = sc.next();
		System.out.println("Enter name of author");
		author = sc.next();
		System.out.println("Enter publisher of Book");
		publisher = sc.next();

		}catch(InputMismatchException e){
			System.out.println("Enter Numeric Values Only");
		}
		
		Node new_node = new Node(id,name,author,publisher);
		Node n = head;
		
		if( head == null )
		{
			head = new_node;
		}
		else
		{
			while(n.next != null)
			{
				n = n.next;
			}
			n.next = new_node;
		}
		System.out.println("New Book Inserted Successfully");
			
	}
	
	public void search()
	{
		int s_id , count = 0;
		Node n = head;
		if( head == null )
		{
			System.out.println("Linked list is empty");
		}
		else
		{
		   System.out.println("Book ID ");
		   s_id = sc.nextInt();// s_id change variable name
		   while( n != null )
		   {
			   if( s_id == n.id )
			   {
				    System.out.println();	
				    System.out.println("The record has been found successfully ");	
				    System.out.println("Book id : "+n.id);
				    System.out.println("Name : "+n.name);
					System.out.println("Author : "+n.author);
					System.out.println("Publisher: "+n.publisher);
					System.out.println();	
					count++; // count cha name found kara
				}
			   n = n.next;
		   }
		   if( count == 0 ) // try  0 wa;i value
		   {
			  System.out.println("Book ID is invalid ");  
              System.out.println();			  
		   }
		}
    }
	
	public void update()
	{
		int up_id , count = 0;
		Node n = head;
		if( head == null )
		{
			System.out.println("Linked list is empty");
		}
		else
		{
		   System.out.println("Enter Book ID which have to be update");
		   
		   up_id = sc.nextInt();
		   while( n != null )
		   {
			   if( up_id == n.id )
			   {
				    System.out.println("Enter new Book ID"); // without book id change kar
					n.id = sc.nextInt();
					System.out.println("Enter new name of Book");
					n.name = sc.next();
					System.out.println("Enter new name of author");
					n.author = sc.next();
					System.out.println("Enter new publisher of Book");
				    n.publisher = sc.next();
					System.out.println();	
					count++; // count cha name found kara
					System.out.println("Update Successfully...!!");
				}
			   n = n.next;
		   }
		   if( count == 0 ) // try  0 wali value
		   {
			  System.out.println("Book ID is invalid ");  
              System.out.println();			  
		   }
		}
		
	}
	
	public void delete()
	{
		int s_id , count = 0;
		System.out.println("Book ID ");
		s_id = sc.nextInt();
		if( head == null )
		{
			System.out.println("Linked list is empty");
		}
		else
		{
					if(s_id == head.id){
						Node n = head;
						head =head.next;
						n=null;
						System.out.println("Book has been deleted successfully");
					    count++;
					}
					else
					{
						Node pre =head;
						Node n= head;
						while( n != null )
						{
							if( s_id == n.id )
							{
								pre.next=n.next;
								n=null;
								System.out.println("Book has been deleted successfully");
								count++;
								break;
								
							}
                                pre=n;
								n=n.next;
						}
					}
					if(count == 0){
						System.out.println("Book id is invalid...!!!");
					}
		}
	}
	
	public void show() // make name Display
	{
		Node n = head;
		while(n != null)
		{
			System.out.println("Book id : "+n.id);
			System.out.println("Name : "+n.name);
			System.out.println("Author : "+n.author);
			System.out.println("Publisher: "+n.publisher);
			System.out.println();
			n = n.next;
		}
	}
	
	
	void bubblesort()
		{
		System.out.println("\nBubble sort :");
		  Node curr = head;
		  Node temp = head;

		  while (curr.next != null)
		  {
			temp = curr.next;
			while (temp != null)
			{
			  if (temp.id < curr.id)
			  {
				int t = temp.id;
				temp.id = curr.id;
				curr.id = t;
			  }
			  temp = temp.next;
			}
			curr = curr.next;
		  }
		}

	
	public static void main(String args[])
	{
		System.out.println("*******************************************************");
		System.out.println("**********                                   **********");
		System.out.println("********** Library Management System Project **********");
		System.out.println("**********                                   **********");
		System.out.println("*******************************************************");
		
		boolean value= true;
		LibraryDemo1 dl1 = new LibraryDemo1();
		
		do
		{
			System.out.println("1. INSERT NEW Book RECORD");
		    System.out.println("2. SEARCH Book RECORD");
			System.out.println("3. UPDATE Book RECORD");
			System.out.println("4. DELETE Book RECORD");
			System.out.println("5. SHOW ALL Book RECORD");
			System.out.println("6. For Sort Books");
			System.out.println("7. EXIT");
			System.out.println("Enter the choice you want");
			Scanner sc = new Scanner(System.in);
			int input = 0;
			try{
		    input = sc.nextInt();
			}catch(InputMismatchException e){System.out.println("Enter Numeric Value");}
			switch(input)
			{
				case 1:
						dl1.insert();
						break;
				case 2:
						dl1.search();
						break;
				   
				case 3:
						dl1.update();
						break;
				   
				case 4:
						dl1.delete();
						break;
			       
				case 5:
				        //dl1.sort();
						dl1.show();
						break;
			
				case 6:
						value = false;
						break;
				case 7:		
				         dl1.bubblesort();
						 dl1.show();
						 break;
				default:
						System.out.println("Invalid Input....Please try again");
						break;
			}
		}while(value == true);
	}
}
		
	

