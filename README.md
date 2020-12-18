# GoldBadgeConsoleApplicationChallenges
Challenge One - completed first
Komodo cafe is getting a new menu. The manager wants to be able to create new menu items, update menu items, delete menu items, and receive a list of all items on the cafe's menu. She needs a console app.

 

The Menu Items:
A meal number, so customers can say "I'll have the #5"
A meal name
A description
A list of ingredients,
A price
 

Your Task:
Create a Menu Class with properties, constructors, and fields.
Create a MenuRepository Class that has methods needed.
Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.

----------------------------------------------------------------------------
Challenge Six - completed second
Green Plan - Gas, Electric, Hybrid Cars
Komodo Green Plan
Komodo Insurance is trying to add a Green Plan for their customers that provides incentives for owning an Electric or Hybrid car. Before they are able to configure any pricing or deals, they want to collect general information on Electric, Hybrid, and Gas cars so that they can do various comparisons.

The purpose of the app on this sprint will be to:
collect, read, delete, and update data on gas, electric, and hybrid cars.

To be more specific, they want to create an app that allows a Komodo Agent to do full CRUD + List on those three types of cars.

For example:
a KI employee can go on and create a Tesla, add it to an Electric Car list, update it, see the details for the car, and delete it from the Electric Car list.

 

They could also see a full list of Electric cars that have been added. They can do the same thing for Gas Cars and Hybrid Cars with the eventual hope that the collected data will help with various comparisons.

----------------------------------------------------------------------------
Challenge Three - completed third
Komodo Insurance Badge System

Komodo Insurance
Komodo Insurance is fixing their badging system.

Here's what they need:
An app that maintains a dictionary of details about employee badge information. (Hint: A dictionary is a collection type in C#. You'll want to use that.)

Essentially, a badge will have a badge number that gives access to a specific list of doors. For instance, a developer might have access to Door A1 & A5. A claims agent might have access to B2 & B4.

 

Create a Badge class with the following properties:
A BadgeID (int)
A List of door names (strings).
 

Create a badge repository:
Create a dictionary of badges.
The key for the dictionary will be the BadgeID.
The value for the dictionary will be the List of Door Names.
 

The Program will allow a security staff member to do the following:
create a new badge
update doors on an existing badge.
delete all doors from an existing badge.
show a list with all badge numbers and door access
Note: Make sure to keep the responsibilities of your UI, your repo, and your tests separate.
Only your UI class should ever take input from the user.

 

Here are some example views:
Menu

Hello Security Admin, What would you like to do?

Add a badge
Edit a badge.
List all Badges
#1 Add a badge
What is the number on the badge: 12345

List a door that it needs access to: A5

Any other doors(y/n)? y

List a door that it needs access to: A7

Any other doors(y/n)? n

(Return to main menu.)

#2 Update a badge
What is the badge number to update? 12345

12345 has access to doors A5 & A7.

What would you like to do?

Remove a door
Add a door
> 1

Which door would you like to remove? A5

Door removed.

12345 has access to door A7.

 

#3 List all badges view
Badge #	Door Access
12345	A7
22345	A1, A4, B1, B2
32345	A4, A5
 

Out of scope:
You do not need to consider tying an individual badge to a particular user. Just the Badge # will do.

Be sure to Unit Test your Repository methods.






