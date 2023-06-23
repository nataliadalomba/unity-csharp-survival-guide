[System.Serializable]
public class Weapon : Item {

    public int attackBonus;
    public int prayerBonus;
    public int strengthBonus;
    public int magicBonus;

    void MyMethod() {
        base.itemID = 4;
    }
}