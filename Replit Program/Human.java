public class Human extends CharacterCreater {

  private String classType; // Ex: Fighter, wizard, etc.
  
  // Constructors
  public Human() { // Default
    super();
    this.classType = "deprived";
  }
  public Human(String classType) { // Default with Class
    super();
    this.classType = classType;
  }
  public Human(String name, String classType) { // Default with Name and Class
    super(name, 5, 2, 2);
    this.classType = classType;
  }
  public Human(String name, int intell, int str, int endur, String classType) {
    super(name, intell, str, endur);
    this.classType = classType;
  }



  // Read/Write Variables
  // Class
  public String getClassType() {return this.classType;}
  public void setClassType(String classType) {this.classType = classType;}

  

  @Override
  public String quote() {
    switch(classType.toLowerCase()) {
      case "kight":
        return "\t\tHello, my name is " + name + ", praise the empire.";
      case "wizzard":
        return "\t\tMy name is " + name + ", keep your hands to your self!";
      case "theif":
        return "\t\t'Ello, I'm " + name + ", what'cha got in your pockets?";
      case "noble":
        return "\t\tHello, my name is " + name + ". Do you need something?";
      case "merchant":
        return "\t\tHello, my name is " + name + ", I've got new things on sale, Stranger.";
      default:
        return "\t\tHello, my name is " + name + ", please show me mercy...";
    } // END of switch
  } // END of quote
} // END of class