package LinkedList;
import java.util.Scanner;

class Node {
	int data;
	Node next;

	Node(int data) {
		this.data = data;
		next = null;
	}
}
public class CircularLinkedList {
	
	Node root,last;
	  
	 void createLinkedList()
	 {
	     root=last=null;
	 }
	         
	 void insertLeft(int data)
	 {
	     Node n=new Node(data);
	     if(root==null)
	     {
	         root=last=n;
	         
	     }
	     else
	     {
	         n.next=root;//1
	         root=n;//2
	         last.next=root;//3
	     }
	   }
	 void deleteLeft()
	 {    
	     if(root==null)
	     {
	         System.out.println("List Empty");
	     }
	     else
	     {
	         Node t=root;//1
	         if(root.next==root)
	         {
	             root=last=null;//single node deletion
	         }
	         else
	         {
	         root=root.next;//2
	         last.next=root;//3
	         }
	         System.out.println("Deleted:"+t.data);
	     }
	     }
	 void insertRight(int data)
	 {
	     Node n=new Node(data);
	     if(root==null)
	     {
	         root=last=n;
	         last.next=root;
	     }
	     else
	     {
	        last.next=n;//1
	        last=n;//2
	        last.next=root;//3
	     }
	   }
	 void deleteRight()
	 {
	     if(root==null)
	     {
	         System.out.println("List Empty");
	     }
	     else
	     {
	         Node t,t2;
	         t=t2=root;
	         if(root.next==root)
	         {
	             root=last=null;
	         }
	         else
	         {
	            while(t!=last)//2
	            {
	                t2=t;
	                t=t.next;
	            }
	            last=t2;
	            last.next=root;
	         }
	         System.out.println("Deleted:"+t.data);
	     }
	   }
	 void printList()
	 {
	     if(root==null)
	     {System.out.println("List Empty");
	     }
	     else
	     {
	         Node t;
	         t=root;
	         do
	         {
	             System.out.println(t.data);
	             t=t.next;
	         }  while(t!=root);//2
	     }
	   }    

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int ch, e;
		CircularLinkedList obj = new CircularLinkedList();
		Scanner in = new Scanner(System.in);
		obj.createLinkedList();
		do {

			System.out.println("1.Insert\n2.Delete\n3.Print List\n0.exit");
			ch = in.nextInt();
			switch (ch) {

			case 1:
				System.out.println("\t1.Left\n\t2.Right\n");

				int cho = in.nextInt();
				switch (cho) {

				case 1:
					System.out.println("Enter Data:");
					e = in.nextInt();
					obj.insertLeft(e);
					// System.out.println("");
					break;
				case 2:
					System.out.println("Enter Data:");
					e = in.nextInt();
					obj.insertRight(e);
					break;
				
				default:
					System.out.println("Wrong option selected");
					break;
				}
			break;

			case 2:
				System.out.println("\t1.Left\n\t2.Right\n");

				int cho2 = in.nextInt();
				switch (cho2) {

				case 1:
					obj.deleteLeft();
					break;
				case 2:
					obj.deleteRight();
					break;
				
				default:
					System.out.println("Wrong option selected");
					break;
				}
			break;
			
			case 3:
				obj.printList();
				break;
				
			case 0:
				System.out.println("Exiting...");
				break;

			default:
				System.out.println("Wrong option selected");
				break;
			}
		} while (ch != 0);
		in.close();
	}

	}


