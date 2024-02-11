import Logic.BinarySearch1;
import Logic.BinarySearch2;
import Logic.LinearSearch1;
import Logic.LinearSearch2;
import Logic.LinearSearch3;
import Logic.LogicSearch;
import Logic.TsuruKameZanBinarySearch;

public class Main {
	public static void main(String[] args) {
		final int SEARCH_COUNT = 6;
		int index = 0;

		LogicSearch[] search = new LogicSearch[SEARCH_COUNT];

		// 線形探索法（リニアサーチ）
		search[index] = new LinearSearch1();
		index++;
		// 線形探索法（番兵をたてる）
		search[index] = new LinearSearch2();
		index++;
		// 線形探索法（break版）
		search[index] = new LinearSearch3();
		index++;
		// 2分探索法（バイナリサーチ）_1
		search[index] = new BinarySearch1();
		index++;
		// 2分探索法（バーなリサーチ）_2
		search[index] = new BinarySearch2();
		index++;
		// 鶴亀算を2分探索法で解く
		search[index] = new TsuruKameZanBinarySearch();
		index++;

		for (int i = 0; i < index; i++) {
			if (search[i] == null) {
				continue;
			}
			search[i].Search();
		}
	}
}
