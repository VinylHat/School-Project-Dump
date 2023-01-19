public abstract class CharacterCreater {

  /*
    Name and stats here will be given a default value to remove ambiguity,
    stats will be overriden by the respective race class.

    Each race will have their own defaults, 
    and the player will be given a couple to put where they want.
  */
  public String name; // does not need to be private 
  public int intelligence; // Obvious
  public int strength; // Damage (doesnt really matter)
  public int endurance; // HP

  

  // Constructors
  public CharacterCreater() { // Default
    this.name = "[No name provided]";
    this.intelligence = 3;
    this.strength = 3; 
    this.endurance = 3;
  }
  public CharacterCreater(String name) { // Default with only name
    this.name = name;
    this.intelligence = 3;
    this.strength = 3;
    this.endurance = 3;
  }
  public CharacterCreater(int intell, int str, int endure) { // Default without name
    this.name = "[No name provided]";
    this.intelligence = intell;
    this.strength = str; 
    this.endurance = endure;
  }
  public CharacterCreater(String name, int intell, int str, int endur) { // Main constructor
    this.name = name;
    this.intelligence = intell;
    this.strength = str;
    this.endurance = endur;
  }

  

  // Read/Write Variables
  // Name
  public String getName() {return this.name;}
  public void setName(String name) {this.name = name;}
  // Intelligence
  public int getIntelligence() {return this.intelligence;}
  public void setIntelligence(int intelligence) {this.intelligence = intelligence;}
  // Strength
  public int getStrength() {return this.strength;}
  public void setStrength(int strength) {this.strength = strength;}
  // Endurance
  public int getEndurance() {return this.endurance;}
  public void setEndurance(int endurance) {this.endurance = endurance;}

  

  // Methods
  public abstract String quote();

  public String statSheet() {
    return "\t\tStrength: " + strength +
          "\n\t\tEndurance: " + endurance + 
          "\n\t\tIntellegence: " + intelligence;
    
  } // END of stat sheet
} // END of class