interface Dog {
    void hit(Cat cat);
}

interface Cat {
    void hitBy(PitBull pitBull);
    void hitBy(Golden golden);
}

class PitBull implements Dog {
    public void hit(Cat cat) {
        System.out.println("Grrhhh! Pit Bull!!!");
        cat.hitBy(this);
    }
}

class Golden implements Dog {
    public void hit(Cat cat) {
        System.out.println("Gaw Gaw! Golden!!!");
        cat.hitBy(this);
    }
}

class Sphynx implements Cat {
    public void hitBy(PitBull pitBull) {
        damaged(100);
    }

    public void hitBy(Golden golden) {
        damaged(10);
    }

    public void damaged(int hp){
        System.out.println("Meo meo Sphynx!!! - " + hp + " hp ~");
    }
}

class Munchkin implements Cat {
    public void hitBy(PitBull pitBull) {
        damaged(25);
    }

    public void hitBy(Golden golden) {
        damaged(50);
    }

    public void damaged(int hp){
        System.out.println("Meo meo Munchkin!!! - " + hp + " hp ~");
    }
}

public class DemoJava {
    public static void main(String[] args) {

        Dog pitBull = new PitBull();
        Dog golden = new Golden();

        Cat sphynx = new Sphynx();
        Cat munchkin = new Munchkin();

        pitBull.hit(sphynx);
        golden.hit(sphynx);

        System.out.println("\nChange turn!!!\n");

        pitBull.hit(munchkin);
        golden.hit(munchkin);
    }
}

