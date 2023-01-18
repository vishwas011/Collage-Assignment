package LinkedList;

import java.util.Scanner;

/*class Dnode {
	int data;
	Dnode left, right;

	Dnode(int data) {
		this.data = data;
		left = right = null;
	}
}*/

public class DoublyCircularLinkedList {

	Dnode root, last;

	void createList() {
		root = last = null;
	}

	void insertLeft(int data) {

		Dnode n = new Dnode(data);
		if (root == null)
			root = last = n;

		else {

			n.right = root;// 1
			root.left = n;// 2
			n.left = last;// 3
			root = n;// 4
			last.right = root;// 5
		}
	}

	void insertRight(int data) {

		Dnode n = new Dnode(data);

		if (root == null)
			root = last = n;
		else {

			last.right = n;// 1
			n.left = last;// 2
			last = n;// 3
			last.right = root;// 4
			root.left = last;// 5
		}
	}

	void deleteLeft() {
		if (root == null) {
			System.out.println("List Empty");
		} else {

			Dnode t = root;
			if (root.right == root)
				root = last = null;
			else {

				root = root.right;
				root.left = last;
				last.right = root;
				System.out.println("Deleted :" + t.data);
			}
		}
	}

	void deleteRight() {

		if (root == null) {
			System.out.println("List Empty");
		} else {
			Dnode t = root;

			last = last.left;
			last.right = root;
			root.left = last;
			System.out.println("Deleted :" + t.data);

		}
	}

	void printList() {

		if(root==null)
	     {System.out.println("List Empty");
	     }
	     else
	     {
	         Dnode t;
	         t=root;
	         do
	         {
	             System.out.println(t.data);
	             t=t.right;
	         }  while(t!=root);//2
	     }
	   } 
	 void printRevList()
	 {
	     if(root==null)
	              System.out.println("List Empty");
	     else
	     {
	         Dnode t;
	         t=root;
	         while(t.right!=last)//stop at last
	         {
	            t=t.right;
	         }
	         while(t!=root)//stop when null 
	         {
	             System.out.println(t.data);
	             t=t.left;
	         }
	     }
	   }

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int ch, e;
		DoublyLinkedList obj = new DoublyLinkedList();
		Scanner in = new Scanner(System.in);
		obj.createList();
		do {

			System.out.println("1.Insert\n2.Delete\n3.Print List\n4. Print Reverse\n0.exit");
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

			case 4:
				obj.printRevList();
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
