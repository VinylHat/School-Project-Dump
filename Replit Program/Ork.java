public class Ork extends CharacterCreater {

  public String klan;

  // Constructors
  public Ork(){
    super();
    this.klan = "Evil Sunz"; // Best one
  }
  public Ork(String klan) { // Default Ork
    super();
    this.klan = klan;
  }
  public Ork(String name, String klan) { // Default Named Ork
    super(name, 0, 4, 5); 
    this.klan = klan;
  }
  public Ork(String name, int intell, int str, int endur, String klan) { // main
    super(name, intell, str, endur);
    this.klan = klan;
  }



  // Read/Write Variables
  // Clan
  public String getClan() {return this.klan;}
  public void setClan(String klan) {this.klan = klan;}
  


  @Override
  public String quote() {

    switch(klan.toLowerCase()) {
      case "evil sunz":
        return "\t\tOi, I'm " + this.name + " and red is the fastest color.";
      case "goffs":
        return "\t\tOi, I'm " + this.name + ", I wunder wha you look like exploded.";
      case "blood axes":
        return "\t\tOi, I'm " + this.name + ", what you want?";
      case "bad moons":
        return "\t\tOi, I'm " + this.name + " yous gunna hav to hit harder to get me teeths.";
      case "snakebites":
        return "\t\tOi, I'm " + this.name + ", I don't need the hu shite cuz I got me fists";
      case "deathskulls":
        return "\t\tOi, I'm " + this.name + ", now gimmie your scrap.";
      default:
        return "\t\tOi, I'm " + this.name + 
               ". I gunna go smash sum moon git's skul in for sum tooth.";
        
    } // END of switch
  } // END of quote override
} // END of class