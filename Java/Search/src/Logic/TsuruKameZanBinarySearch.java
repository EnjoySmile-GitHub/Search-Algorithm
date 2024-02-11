package Logic;

/**
 * 鶴亀算を2分探索法で解く
 */
public class TsuruKameZanBinarySearch extends LogicSearch {
	public void Search() {
		int low = 0, high = 100;
		int legs = 0;
		int kame = 0;

		while (legs != 274) {
			kame = (low + high) / 2;
			legs = kame * 4 + (100 - kame) * 2;
			if (274 < legs) {
				high = kame - 1;
			} else {
				low = kame + 1;
			}
		}

		System.out.println("亀が" + kame + "鶴が" + (100 - kame));
	}
}
