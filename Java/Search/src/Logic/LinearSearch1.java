package Logic;

import Class.Person;
/**
 * 線形探索法（リニアサーチ）
 */
public class LinearSearch1 extends LogicSearch {
	public void Search() {
		Person[] p = new Person[6];
		p[0] = new Person("Ann", 18);
		p[1] = new Person("Rolla", 19);
		p[2] = new Person("Nancy", 16);
		p[3] = new Person("Eluza", 17);
		p[4] = new Person("Juliet", 18);
		p[5] = new Person("Machilda", 20);
		
		int count = p.length;
		String keyName = "Eluza";
		int index = 0;
		
		while(index < count && p[index].getName() != keyName) {
			index++;
		}
		
		if(index < count) {
			System.out.println(p[index].getName() + " " + p[index].getAge());
		} else {
			System.out.println("見つかりませんでした。");
		}
	}
}
