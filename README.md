# COP-2010-P2-cash-register
create a cash register style form in visual C#
COP2010 Project #2 50 pts – Due by start of class on 10/6 
 
You are going to create a point of sale application for a restaurant.  The application will have six buttons to select the products, radio buttons to select a discount, combo box to select drinks, and it will calculate subtotal, taxes, and total.       
Objectives: 
•	Understanding decision structures (if-else, switch ) 
•	Use of functions 
•	Use of radio boxes, group boxes, combo boxes 
Requirements 
Read the projects and assignments requirements pdf in the course documents section of canvas.  You need to follow all of the guidelines for this project.    
1.	Pick your own type of restaurant and products.  The image provided is just a sample. 
2.	Have at least 6 items on your menu.     
a.	All of items will be buttons with a picture of the item. 
b.	When you click on the button/picture it will add the item to the order.  
c.	You can have any items and prices but one item must $10 with another $5. 
d.	All items must be formatted with dollar signs and two decimals, e.g. $2.00 
3.	Output for selected menu items will be to a list box. 
4.	Output for subtotal, taxes, and total will be to text boxes. 
5.	Use a group box with radio buttons to select the discount rate.  When a discount is selected it will discount the next item(s) selected and display the discounted item rate in the list box. 
a.	Use a method outside of the event handler to set the discount rate. 
b.	Use an if-else to set the discount rate based on which radio button is selected. 
c.	Set discounts as: Military-15%, Senior-10%, Student-5%, and default as None-0%. 
6.	Use a ComboBox for drinks 
a.	When you select a drink from the menu it adds it to the list box 
b.	Have at least 4 different types of drinks 
c.	Use a switch statement to select and display the drink to the list box 
d.	Dinks are free and only need to be added to the list box when selected.  You do not need to add them to subtotal, taxes, or total - no calculations are required.     
7.	Use a constant variable to set the tax rate at 7% (remember to declare as all upper case) 
8.	Calculate and output subtotal, taxes, and total price.  
9.	Have a clear button to clear needed boxes and variables so you can start a new order. 
10.	Have an exit button to exit the application.   
Notes: Use as many variables as you like but all must be named using camel case and with the required naming convention.     
You must use a method outside of the event handler for setting the discount rate.  You  can use methods for other parts of the project but they are not required. 
Example form: not required to match layout, but must have all text boxes, buttons, labels, etc.   
  
Grading Rubric (possible 50 pints): 
A submitted project must compile and run or it will be graded with zero points 
Description 	Itemized Value 	Total 
Possible 	Total Earned 
Correct output for items to list box for both regular or discount price 	2 pts each box 	12 	  
Correct output for subtotal, Taxes, and Total(discount or regular price) 	3 pts each box 	9 	  
Use of combo box with switch statement for drinks with correct output to list box 	All or nothing 	5 	  
Use method with if-else to set discount percent 	All or nothing 	10 	 
Correct naming of all event handlers and variables 	All or nothing 	5 	 
Proper comments and documentation 	NA 	5 	 
Text boxes and variables clear 	All or nothing 	2 	 
Exit button closes application 	All or nothing 	2 	 
 
