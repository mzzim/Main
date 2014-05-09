//Name: Md Zuhaer Zim
//Student Number: 20517010
using System;
using System.IO; //Needed to write into a text file
using System.Text; //Needed for ASCII code conversion

class RSA
{
	static void Main()
	{
		//Variable Declaration
		StreamWriter sw = new StreamWriter("20517010.txt");
		ulong stuID = 20517010;
		ulong p = 48991;
		ulong q = 50417;
		ulong e = 1048577;
		ulong n, phi;
		ulong d;
		ulong e_prof = 52741219;
		ulong n_prof = 3125033603;
		
		//Set the phi and n values
		n = p*q;
		phi = (p - 1)*(q-1);
		
		//------------------------------------
		//Part One - Perform Euclidean Algorithm
		//------------------------------------
		//Perform Extended Euclidean Algorithm
		//Store solution into the value for d, which is what we are looking for
		d = ExtendedEuclideanAlgorithm(e, phi);
		
		//------------------------------------
		//Part Two - PlainText Creation
		//------------------------------------ 
		//Create a plain text using our student number and the values for p and q
		string strP = p.ToString();
		string strQ = q.ToString();
		string strStuID = stuID.ToString();
		string plainText = "Hello D.E.A.R. I am student " + strStuID + ". This is my little secret: " + strP + " and " + strQ + ". ";
		plainText = plainText + "So, this semester, I had 6 courses, and one of them was ECE103. This course is also known as discrete math";
		plainText = plainText + "and this course can be considered to be real mathematics. So, this brings me to the question, what have I been learning for the past"; 
		plainText = plainText + "few years? Was it actually math, or was it just a joke? I don't know whether I should question my life, because I have been told a lie my entire life."; 
		plainText = plainText + "Calculus is not real math, linear algebra is not real math, but discrete math IS real math."; 
		plainText = plainText + "I'm confused. So this brought me to another point. What if the physics I'm learning is actually not real physics. And the circuits I'm learning is not";
		plainText = plainText + " real circuits? What if everything I'm learning is fake? What if I'm actually fake, and I actually do not know that? This is a scary idea I have come upon.";
		plainText = plainText + " This could become the defining moment of the new world.(Y)";
		
		//------------------------------------
		//Part Two - PlainText Creation
		//------------------------------------ 
		//This is before encoding the text
		//Here, we convert the plaintext into a number version using ASCII code
		string[] splitPlainText = StringSplitter_Length( plainText, 4 );
		ulong[] plainTextSplit = new ulong[splitPlainText.Length];
		
		//Converting the plaintext splits into ASCII code
		for( int i = 0; i < splitPlainText.Length; i++ )
		{
			byte[] asciiBytes = Encoding.ASCII.GetBytes(splitPlainText[i]); //ASCII code conversion
			plainTextSplit[i] = (ulong)(asciiBytes[0]*Math.Pow(256, 3) + asciiBytes[1]*Math.Pow(256, 2) + 
				asciiBytes[2]*Math.Pow(256, 1) + asciiBytes[3]);
			Console.WriteLine(plainTextSplit[i]);
		}
		
		//------------------------------------
		//Part Three - First Encryption
		//------------------------------------ 
		//This part is to encrypt the 4-words using my digital signature
		ulong[] encryptText = new ulong[ plainTextSplit.Length ];

		for ( int i = 0; i < encryptText.Length; i++ )
		{
			encryptText[i] = repeatedSquaring( plainTextSplit[i], d, n );
		}
		
		//------------------------------------
		//Part Four - Second Encryption
		//------------------------------------ 
		//This part is to encrypt the previously encrypted array using the professors public key
		//The same double squaring algorithm is used in this part
		ulong[] cipherText = new ulong[ encryptText.Length ];
		
		for ( int i = 0; i < cipherText.Length; i++ )
		{
			cipherText[i] = repeatedSquaring( encryptText[i], e_prof, n_prof );
		}
		
		//------------------------------------
		//Part Five - File Output
		//------------------------------------
		//This part takes the output and writes it to a file
		sw.Write("{0} ", n);
		sw.Write("{0} ", e);
		sw.Write("{0} ", cipherText.Length);
		
		for (int i = 0; i < cipherText.Length; i++)
		{
			sw.Write("{0} ", cipherText[i]);
		}
		
		sw.Close();
	}
	
	//Function for the Extended Euclidean Algorithm which returns a value for d from the linear congruence
	//The output shall look like: d = e*d + phi*y, where d is the gcd of the two numbers
	//Given that phi and e are coprime, d should be equal to 1
	public static ulong ExtendedEuclideanAlgorithm( ulong e, ulong phi)
	{
		ulong d = 0;
		ulong GCD, y, c1, c2, temp;
		ulong d1 = 0;
		ulong d2 = 1; 
		ulong x1 = 1;
		ulong x2 = 0;
		
		if ( e > phi ) //This is to fix the values in the incident that e is greater than phi of n
		{
			temp = phi;
			phi = e;
			e = temp;
			d1 = 1;
			d2 = 0;
			x1 = 0;
			x2 = 1;
		}
		while ( phi != 0 )
		{
			c1 = phi / e;
			phi = phi % e;
			//Last line, aka, end of the EEA algorithm
			if ( phi == 0 )
			{
				GCD = e;
				d = d2;
				y = x2;
				break;
			}
			c2 = e / phi;
			e = e%phi;
			d1 = d1 - c1*d2;
			x1 = x1 - c1*x2;
			d2 = d2 - c2*d1;
			x2 = x2 - c2*x1;
			//Last line, aka, the end of the EEA algorithm
			if ( e == 0 )
			{
				GCD = phi;
				d = d1;
				y = x1;
				break;
			}
		}
		
		//This is the end of the Euclidean Algorithm function and returns the value for d so it can be used for later 
		return d;
	}
	
	//Method to split the parameter string into strings of equal length
	//Here punctuation and spaces are also considered characters
	public static string[] StringSplitter_Length( string splittingString, double length )
	{
		string[] splitSent = new string[0];
		string[] temp;
		
		while(!String.IsNullOrEmpty(splittingString)) //As long as the sentence is not a null string
		{
			//Algorithm to add items to an empty array
			//The item that is added to the array is the first four characters of the plain text
			//The those for letters are then removed from the plain text so the next four letters can be added to the string array
			temp = new string[splitSent.Length];
			for ( int i = 0; i < temp.Length; i++)
			{
				temp[i] = splitSent[i];
			}

			splitSent = new string[splitSent.Length + 1];
			
			for ( int i = 0; i < temp.Length; i++ )
			{
				splitSent[i] = temp[i];
			}
			
			splitSent[splitSent.Length - 1] = splittingString.Substring(0, 4);
			splittingString = splittingString.Remove(0, 4);
		}
		
		return splitSent;
	}
	
	//Algorithm for the method of repeated squaring
	//An array of ASCII encoded plaintext is passed in, and then is encrypted using my public key using repeated squaring
	//The output of this function is an array of encrypted plain text, also known as the cipertext
	public static ulong repeatedSquaring( ulong plainText, ulong d, ulong n )
	{
		if  ( d == 0 ) { return 1; }
		ulong a = repeatedSquaring( (plainText), d/2, n);
		ulong encrypted = (a*a) % n;
		if ( d % 2 == 1)
		{
			encrypted = (encrypted*(plainText))%n;
		}
		return encrypted;
	}
}