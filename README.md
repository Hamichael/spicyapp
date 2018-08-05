# spicyapp
Working repo for Team 5 Project C# Programming

---------------------
Development Version 2
---------------------

Class ingData is created to mirror data that will be aquired from a database. This is done to prevent direct modifications to the database.

ingData is a basic class with 2 strings, 1 int, with standard set and get methods.


The program will automatically populate data into the combo box.
This is where you read data from the text file.

If at any point the database is update outside of the program, a refresh button is provided.

The add button will add an ingredient to the text file, provided it passes validation. It also refreshes data in the combo box after adding the data.


Currently, the regex, add button, and data inside the combo box has been validated
Personally throughly tested entry of data and what actually gets put in the text file, as well as what is displayed.


Planned features will be batch processing of ingredient adding and updating.


Development Version 2.1 - 07/31/2018

Method getObjectRef() implemented. Implements references to reuse code with different objects.

Added extra display and adding ingredient lines

Add edit line [WIP]

Updated references in code

Updated ingData to include spicyness [float]

----------------------------------
Development Version 3 - 08/04/2018
----------------------------------
Updated ingData to include file [string]

writeDatabaseIngData(string fileDatabase) implemented

Title String for Messagebox validation added

Seperated database from interior data. Now all ingredient data updates in one batch.

Added file references to images

Edit line finished
