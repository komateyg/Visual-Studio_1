import java.util.Scanner;

public class Test5 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("���� �Է��ϼ��� : ");
		int a = sc.nextInt();
		switch (a) {
		case 12, 1, 2:
			System.out.println("�ܿ�");
			break;
		case 3, 4, 5:
			System.out.println("��");
			break;
		case 6, 7, 8:
			System.out.println("����");
			break;
		case 9, 10, 11:
			System.out.println("����");
			break;

		default:
			System.out.println("�߸��� �Է��Դϴ�.");
			break;
		}
	}
}
