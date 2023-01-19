public class Cabal extends CharacterCreater {

  private String rank;

  // Constructors
  public Cabal() {
    super();
    this.rank = "Legionnaire"; // basic cabal unit
  }
  public Cabal(String name) {
    super(name, 2, 4, 3);
    this.rank = "Legionnaire";
  }
  public Cabal(String name, String rank) {
    super(name, 2, 4, 3);
    this.rank = rank;
  }
  public Cabal(String name, int intell, int str, int endur, String rank) {
    super(name, intell, str, endur);
    this.rank = rank;
  }



  // Read/Write Variables
  // Rank
  public String getRank() {return this.rank;}
  public void setRank(String rank) {this.rank = rank;}



  @Override
  public String quote() {
    switch(rank.toLowerCase()) {
      case "dominus":
        return "\t\tI am Dominus " + name + 
                ", I have been called many names, but not \"Hero.\"";
      case "bracus":
        return "\t\tI am Bracus " + name + ", get back to work!";
      case "commander":
        return "\t\tI am " + name + ", do you have something to tell me?";
      case "valus":
        return "\t\tI am Valus " + name + ", I order you to get moving!";
      case "primus":
        return "\t\tI am Primus" + name + ", bold of you to talk to me.";
      default:
        return "\t\tI am " + name + ", praise the Empress Imperial";
    } // END of switch
  } // END of quote
}// END of Class