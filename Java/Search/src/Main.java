import Logic.LinearSearch1;
import Logic.LinearSearch2;
import Logic.LinearSearch3;
import Logic.LogicSearch;

public class Main {
	public static void main(String[] args) {
		final int SEARCH_COUNT = 3;
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
		
		for(int i = 0; i < index; i++) {
			if(search[i] == null) {
				continue;
			}
			search[i].Search();
		}
	}
}
