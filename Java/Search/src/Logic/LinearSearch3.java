package Logic;

import Class.Person;

/**
 * 線形探索法（break版）
 */
public class LinearSearch3 extends LogicSearch {
	public void Search() {
		Person[] p = new Person[6];
		p[0] = new Person("Ann", 18);
		p[1] = new Person("Rolla", 19);
		p[2] = new Person("Nancy", 16);
		p[3] = new Person("Eluza", 17);
		p[4] = new Person("Juliet", 18);
		p[5] = new Person("Machilda", 20);
		
		int dataCount = p.length;
		String keyName = "Juliet";
		boolean flg = false;
		
		for(int i = 0; i < dataCount; i++) {
			if(keyName == p[i].getName()) {
				System.out.println(p[i].getName() + " " + p[i].getAge());
				flg = true;
				break;
			}
		}
		
		if(!flg) {
			System.out.println("見つかりませんでした");
		}
	}
}
