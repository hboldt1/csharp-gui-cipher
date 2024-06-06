// Lab 9 - View (Console) class
/**
* View_GUI.java
* Hudson Boldt / Lab Section 02B | Thu 4:30
* 
* This class is the view in MVC. It creates a view constructor, gets the message, gets the key, and prints
* it out all using a GUI. How awesome.
* 
*/

using System; // for console io


/* No need for a constructor in c#
   Constructor - given to students	
	public View() {
		s = new Scanner(System.in);
	} // end Constructor
*/
public class View{

	public View() {
		// :P
	}

// Student creates	
	public string GetMessage(){
		Console.Write("Enter message: ");
		string message = Console.ReadLine();
		return message;
	}

// Student creates	
	public int GetKey(){

            int key;

            while (true) {
                Console.Write("Enter an integer from 0 to 25: ");
                string input = Console.ReadLine();
                try
                {
                    key = int.Parse(input);

                    if (key >= 0 && key <= 25)
                    {
                        return key; // also breaks
                    }
                    else
                    {
                        Console.WriteLine("\nERROR: KEY must be between 0 and 25 (inclusive)");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nERROR: Invalid input. KEY must be an integer");

                }
            }
     }
	public void DisplayResult(string msg){
		Console.WriteLine(msg);
	}
    public void EndProgram(){
        Console.WriteLine("*Press any key to end program...*");
        Console.ReadKey();
    }
}
