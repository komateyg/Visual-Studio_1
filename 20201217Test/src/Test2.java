import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		int hh, mm, ss;
		Scanner s = new Scanner(System.in);
		System.out.print("입력 : ");
		ss = s.nextInt();
		
		mm = ss / 60;
		hh = mm / 60;
		ss = ss % 60;
		mm = mm % 60;
		System.out.print("출력 : "+ hh+"시" +mm+"분" +ss+"초");

	}
}
