package Logic;

/**
 * 2分探索法（バイナリサーチ）_1
 */
public class BinarySearch1 extends LogicSearch {
	public void Search() {
		int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		int dataCount = data.length;
		int keyData = 10;
		int low = 0, high = dataCount - 1;

		boolean flgSearch = false;

		while (low <= high) {
			int index = (low + high) / 2;
			if (data[index] == keyData) {
				System.out.println(data[index] + "は" + index + "番目にありました。");
				flgSearch = true;
				break;
			}

			if (data[index] < keyData) {
				low = index + 1;
			} else {
				high = index - 1;
			}
		}

		if (!flgSearch) {
			System.out.println("見つかりませんでした。");
		}
	}
}
