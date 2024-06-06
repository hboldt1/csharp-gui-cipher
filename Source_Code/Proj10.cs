// Controller

// Proj10 - Controller class
/**
* Proj10.java
* Hudson Boldt / Lab Section 02B | Thu 4:30
* 
* This class is the Controller in MVC. It creates both the view and cipher objects. Uses the view class for
* all user input and output. And uses Cipher for all the complicated encryption stuff. Then oututs all of 
* it to GUI.
* 
*/
using System;				// for Console I/O
using System.Collections;	// for ArrayLists
using System.IO;			//s for StreamWriter


public class Proj10{

    public static void Main (string [] args){

// Encrypt the message 
// Display encrypted message 
 // Decrypt the message 
 // Display encrypted message 
 // Hold the screen until user presses a key

        View view = new View();

        int key = view.GetKey();

        string message = view.GetMessage();

        Cipher cipher = new Cipher(key, message);

        
        cipher.Encrypt();
        string encryptedMessage = cipher.ToString();

        cipher.Decrypt();
        string decryptedMessage = cipher.ToString();

        view.DisplayResult("Encrypted " + encryptedMessage);

        view.DisplayResult("Decrypted " + decryptedMessage);
        
        view.EndProgram();

    }
}
