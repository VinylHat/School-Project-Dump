import java.util.*;

class Main {
  /*
    Started: Brendan Ellison -- 1/8/2023

    Concept: Character creator for some kind of game, I guess something like DnD.

    Parent class: CharacterCreator => Subclass Race => Subclass Human
         (Warhammer 40k's because they are cooler)  => Subclass Ork
        (Destiny's roman empire esc. space rhinos)  => Subclass Cabal

    User input order: Race => History (Cabal rank/Ork tribe/... whatever for humans) =>
                              Display character to user => Ask to go again.

    DEPRICATED: Stats (Keep it simple with like 3 stat types)
                All the tools needed should be here to create this feature,
                but I felt it was overkill for the assignment.
                I spent a lot of time with functionality,
                I assume thats more important here.

    Will start with a CharacterCreator obj and downscale to the specified race. 
    The race will handle the inputs and user instructions for said inputs.

    Ideas for requirments: Allow for multiple characters to be made (recursion),
                           Add each created character to an array list. 
                           Then allow user to break the recursion if they are done,
                           or bored, and display the characters created. 
  */

  // local list of character obj
  public static ArrayList<CharacterCreater> characters = new ArrayList<>();
  public static Scanner readLine = new Scanner(System.in);
  
  public static void main(String[] args) {
    
    print("\n\t\tHello, would you like to make a new character?");
    if(getYesOrNo()) {
      createCharacter();
    } else {
      endGame();
    }
    readLine.close();
  } // END of main

  
  
  public static void createCharacter() {

    boolean playerCooperates = false; // loop boolean
  
    print("\t\tWhat race do you want to be?"
        + "\n\t\tIf you change your mind, just type \"Done\"");
    System.out.print("\t\tHuman, Ork, or Cabal?: ");
    String input = readLine.nextLine();
    print("---------------------------------------------------------------");

    while(!playerCooperates){ // Validates player input
      if(input.contentEquals("Human") || input.contentEquals("human")) {
        playerCooperates = true;
        humanBuilder();
        
      } else if(input.contentEquals("Ork") || input.contentEquals("ork")) {
        playerCooperates = true;
        orkBuilder();
        
      } else if(input.contentEquals("Cabal") || input.contentEquals("cabal")) {
        playerCooperates = true;
        cabalBuilder();
        
      } else if(input.contentEquals("Done") || input.contentEquals("done")) {
        playerCooperates = true;
        endGame();
        // Ends game
      } else {
        System.out.print("\t\tPlease type \"Human\", \"Ork\" or \"Cabal\": ");
        input = readLine.nextLine();
        // Wrong input
      }
    } // END of while loop
  } // END of method

  
  /*
    These methods below handle the inputs for the specified classes.
    They are a little repedative but all slightly different.
    Calling them as methods felt more appropriate, 
    I did not want a buch of nested statments making clutter.
  */
  public static void humanBuilder() {

    // Get Name and class
    System.out.print("\t\tWhat is your name?: ");
    String name = readLine.nextLine();
    print("\n\t\tKnown Human Classes: " + 
          "[Kight, Wizzard, Theif,\n\t\tNoble, Merchant, and Deprived]");
    System.out.print("\n\t\tWhat class do you identify with?: ");
    String classType = readLine.nextLine();
    print("---------------------------------------------------------------");

    // Display to player
    Human human = new Human(name, classType);
    print(human.quote());
    print(human.statSheet());
    print("---------------------------------------------------------------");
    characters.add(human);

    // Let player add a stat -- this is pretty much to add an exception
    print("\t\tWould you like to change your stats?");
    if(getYesOrNo()) {
      System.out.print("\t\tYour Strength: ");
      addStat(human, 1);
      System.out.print("\t\tYour Endurance: ");
      addStat(human, 2);
      System.out.print("\t\tYour Intellegence: ");
      addStat(human, 3);
      print("---------------------------------------------------------------");
      print("\t\tYour new stats look like this.");
      print(human.statSheet());
      print("---------------------------------------------------------------");
      
      showCharacters();
      print("\n\t\tWant to make another character?");
      if(getYesOrNo()) {
        createCharacter();
      } else {
        endGame();
      }
    } else {
      showCharacters();
      // ask to play again
      print("\n\t\tWant to make another character?");
      if(getYesOrNo()) {
        createCharacter();
      } else {
        endGame();
      }
    }
  } // END of Human

  
  
  public static void orkBuilder() {

    // Get Name and Klan
    System.out.print("\t\tWhat you want yous name to be?: ");
    String name = readLine.nextLine();
    print("\n\t\tKnown Ork Clans: " + 
          "[Blood Axes, Goffs, Bad Moons,\n\t\tDeathskulls, Evil Sunz, and Snakebites]");
    System.out.print("\n\t\tDo yous know what klan yous from?: ");
    String klan = readLine.nextLine();
    print("---------------------------------------------------------------");

    // Display to player
    Ork ork = new Ork(name, klan);
    print(ork.quote());
    print(ork.statSheet());
    print("---------------------------------------------------------------");
    characters.add(ork);

    // Let player add a stat -- this is pretty much to add an exception
    print("\t\tWould you like to change your stats?");
    if(getYesOrNo()) {
      System.out.print("\t\tYour Strength: ");
      addStat(ork, 1);
      System.out.print("\t\tYour Endurance: ");
      addStat(ork, 2);
      System.out.print("\t\tYour Intellegence: ");
      addStat(ork, 3);
      print("---------------------------------------------------------------");
      print("\t\tYour new stats look like this.");
      print(ork.statSheet());
      print("---------------------------------------------------------------");
      
      showCharacters();
      print("\n\t\tWant to make another character?");
      if(getYesOrNo()) {
        createCharacter();
      } else {
        endGame();
      }
    } else {
      showCharacters();
      // ask to play again
      print("\n\t\tWant to make another character?");
      if(getYesOrNo()) {
        createCharacter();
      } else {
        endGame();
      }
    }
  } // END of Ork

  
  
  public static void cabalBuilder() {

    // Get Name and rank
    System.out.print("\t\tWhat do we call you?: ");
    String name = readLine.nextLine();
    print("\n\t\tKnown Cabal Ranks: " + 
          "[Legionnaire, Bracus, Commander,\n\t\tValus, Primus, and Dominus]");
    System.out.print("\n\t\tWhat is your rank?: ");
    String rank = readLine.nextLine();
    print("---------------------------------------------------------------");

    // Display to player
    Cabal cabal = new Cabal(name, rank);
    print(cabal.quote());
    print(cabal.statSheet());
    print("---------------------------------------------------------------");
    characters.add(cabal);

    // Let player add a stat -- this is pretty much to add an exception
    print("\t\tWould you like to change your stats?");
    if(getYesOrNo()) {
      System.out.print("\t\tYour Strength: ");
      addStat(cabal, 1);
      System.out.print("\t\tYour Endurance: ");
      addStat(cabal, 2);
      System.out.print("\t\tYour Intellegence: ");
      addStat(cabal, 3);
      print("---------------------------------------------------------------");
      print("\t\tYour new stats look like this.");
      print(cabal.statSheet());
      print("---------------------------------------------------------------");
      
      showCharacters();
      print("\n\t\tWant to make another character?");
      if(getYesOrNo()) {
        createCharacter();
      } else {
        endGame();
      }
    } else {
      showCharacters();
      // ask to play again
      print("\n\t\tWant to make another character?");
      if(getYesOrNo()) {
        createCharacter();
      } else {
        endGame();
      }
    }
  } // END of Cabal
  

  
  /*
    The methods below this point are time savers. 
    There is a lot of repetition in getting
  */
  public static void endGame() { // Method for when ever player is done
    print("\t\t\t\t\t\tGoodbye!");
    print("---------------------------------------------------------------");
  } // END of endGame

  public static boolean getYesOrNo() {

    boolean output = false;
    boolean playerCooperates = false; // loop boolean
      
    System.out.print("\t\tType Yes or No: ");
    String input = readLine.nextLine();
    while(!playerCooperates){ // Validates player input
      if(input.contentEquals("yes") || input.contentEquals("Yes") 
         || input.contentEquals("y") || input.contentEquals("Y")) {
        playerCooperates = true;
        output = true;
        
      } else if(input.contentEquals("no") || input.contentEquals("No") 
         || input.contentEquals("n") || input.contentEquals("N")) {
        playerCooperates = true;
        output = false;
        
      } else {
        System.out.print("\t\tPlease type \"Yes\" or \"No\": ");
        input = readLine.nextLine();
        // Wrong input
      }
    } // END of while loop
    print("---------------------------------------------------------------");
    return output; 
  } // END of getYesOrNo

  public static void showCharacters() {

    print("\t\tCharacters made so far: ");
    for(CharacterCreater character : characters) {
      print("\t\t" + character.getName());
    }
  } // END of showCharacters


  /*
    This method has shown me so many stupid quirks with Java's scanner...
    It never clears its memory so it runs into problems with with causeing infinte loops
    It broke other methods because it would skip over the nextLine(); method due to this.

    I have no idea why you would ever use its other methods like nextInt();
    when you can simply parse the strings without causing these issues...

    Whatever, I got the exception in and it does something.
  */
  public static void addStat(CharacterCreater character, int stat) {
    // Stat input will be 1 = strength, 2 = endurance, 3 = intellegence
    int input = 0; 
    
    switch(stat) {
      case 1:
        try {
          input = readLine.nextInt();
        } catch(InputMismatchException err) { // bad input
          readLine.next(); // without this, this is an infinte loop
          System.out.print("\t\tPlease enter a real number: ");
          addStat(character, 1);
          return;
        }
        character.setStrength(input);
        readLine.nextLine(); // This is here because of a quirk with scanner and nextLine();
        break;
        
      case 2:
        try {
          input = readLine.nextInt();
        } catch(InputMismatchException err) { // bad input
          readLine.next(); // without this, this is an infinte loop
          System.out.print("\t\tPlease enter a real number: ");
          addStat(character, 2);
          return;
        }
        character.setEndurance(input);
        readLine.nextLine(); // This is here because of a quirk with scanner and nextLine();
        break;
        
      case 3:
        try {
          input = readLine.nextInt();
        } catch(InputMismatchException err) { // bad input
          readLine.next(); // without this, this is an infinte loop
          System.out.print("\t\tPlease enter a real number: ");
          addStat(character, 3);
          return;
        }
        character.setIntelligence(input);
        readLine.nextLine(); // This is here because of a quirk with scanner and nextLine();
        break;
        
      default:
        print("You should not be seeing this...");
        break;
    } // END of switch
  } // END of addStats

  // Getting very tired of typing this out every time...
  // In VS you can just hit cw and double-tap Tab 
  // and it will fill in Console.WriteLine(); for you.
  public static void print(String input) {
    System.out.println(input);
  } // END of print
}