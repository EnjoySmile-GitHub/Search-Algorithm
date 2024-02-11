package Logic;

/**
 * 2分探索法（バイナリサーチ）_2
 */
public class BinarySearch2 extends LogicSearch {
	public void Search() {
		int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		int dataCount = data.length;
		int keyData =5;
		int low = 0, high = dataCount - 1;
		int index = 0;

		while (low <= high) {
			index = (low + high) / 2;

			if (data[index] <= keyData) {
				low = index + 1;
			}
			
			if (keyData <= data[index]) {
				high = index - 1;
			}
		}

		if (low == (high + 2)) {
			System.out.println(data[index] + "は" + index + "番目にあります。");
		} else {
			System.out.println("見つかりませんでした。");
		}
	}
}
