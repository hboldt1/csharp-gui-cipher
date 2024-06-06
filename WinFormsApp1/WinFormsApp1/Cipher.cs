/**
* Cipher.java
* Hudson Boldt / Lab Section 02B | Thu 4:30
* 
* This class is the Model in MVC. It takes the first char, adds the key, makes sure its within the correct 
* bounds, appends it it, and returns the encrypted string. Same for decrypt except it handles spaces which
* are out of bounds for lowercase.
* 
* EXTRA CREDIT
* 
*/

using System;				// for Console I/O
using System.Text;			// for StringBuilder
/// <summary>
/// 
/// </summary>
public class Cipher {
 	private int key;
	private string message;

	// Constructor	
	/// <summary>
	/// This constructor initilizes key and message
	/// </summary>
	/// <param name="k"></param>
	/// <param name="m"></param>
	public Cipher(int k, string m) {
		key = k;
		message = m;
	} // end Constructor

	/// <summary>
	/// Encrypt string
	/// </summary>
	public void Encrypt() {

		StringBuilder sb1 = new StringBuilder();
		
		for(int i = 0; i < message.Length; i++){
			int j = message[i];


			int asciiNum = (int) j; 

			int shiftedNum = (asciiNum + this.key);


			// I dont like modulus
			while (shiftedNum > 122){
				shiftedNum -= 26;
			}

			char encryptedNum = (char) shiftedNum;

			sb1.Append(encryptedNum);

		}

		// Build a string of the replacement characters and return it

		string encryptedString = sb1.ToString();

		// Comment out the line below when you're done
		
		message = encryptedString;
	} // end encrypt()

	/// <summary>
	/// Decrypts string
	/// </summary>
	public void Decrypt() {

		StringBuilder sb2 = new StringBuilder();

		for(int i = 0; i < message.Length; i++){
			
			char j = message[i]; // C# doesnt use charat
			int asciiNum = (int)j; 
			int shiftedNum = asciiNum - this.key;


			// for the case of a space (hey that rhymes)
			if (shiftedNum != 32){

				while (shiftedNum < 97){
					shiftedNum += 26;
				}
			}

			char decryptedNum = (char)shiftedNum;

			sb2.Append(decryptedNum);

		}

		// Build a string of the replacement characters and return it

		string decryptedString = sb2.ToString();

		message = decryptedString;

	} // end decrypt()

	public override string ToString(){
		return message;
	}
	
} // end class