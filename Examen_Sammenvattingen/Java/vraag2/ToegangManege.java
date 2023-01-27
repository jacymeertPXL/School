package be.pxl.vraag2;

public class ToegangManege implements Printbaar {
	public int ToegangManege;
	private Lid[] leden;
	
	public ToegangManege(int aantal) {
		leden = new Lid[aantal];
		this.ToegangManege = aantal;
	}
	
	public void voegLidToe(Lid lid) {
		int gevonden = 0;
		int aantal = 0;
		for (int i = 0; i < leden.length; i++) {
			if (leden[i] != null) {
				aantal++;
				if (leden[i].equals(lid)) {
					gevonden++;
				}
				
			}
		}
		
		if (gevonden == 0) {
			if (aantal < ToegangManege) {
				int open = 0;
				for (int i = 0; i < this.leden.length; i++) {
					if (leden[i] == null) {
						open = i;
						i = leden.length;
					}
				}
				leden[open] = lid;
				
				if (lid instanceof Stalpersoneel) {
					System.out.println("Stalpersoneel is toegevoegd");
				} else {
					if (lid instanceof Lesgever) {
						System.out.println("Lesgever is toegevoegd");
					} else {
						if (lid instanceof Lesnemer) {
							System.out.println("Lesnemer is toegevoegd");
						}
					}
				}
				
			} else {
				System.out.println("De manège is vol");
			}
		} else {
			System.out.println("Dit lid is al toegevoegd");
		}
	}

	@Override
	public void print() {
		for (int i = 0; i < leden.length; i++) {
			if (leden[i] != null) {
			System.out.println(leden[i].getVoornaam());
			}
		}
		
	}

	@Override
	public void print(int aantal, char teken) {
		// TODO Auto-generated method stub
		
	}

}
