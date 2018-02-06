Feature: Membership
	In order provide membership
	As shop admin
	I want apply the business logic for different types of membership

@AcceptanceTest
Scenario: GivenOrderWithBookMembershipWhenActivateThenActivateBookMembership
	Given the use has placed the order with book membership
	| CustomerId | FirstName | LastName    |
	| 1          | Vijay     | Viswanathan |
	And line of Items
	| ProductID |  ProductName           |
	| 2         |  BookMemberShip        |
	When I process the order with book membership
	Then book membership should be activated

	@AcceptanceTest
Scenario: GivenOrderWithVideoMembershipWhenActivateThenActivateVideoMembership
	Given the use has placed the order with video membership
	| CustomerId | FirstName | LastName    |
	| 1          | Vijay     | Viswanathan |
	And line of Items
	| ProductID | ProductName     |
	| 2         | VideoMemberShip |
	When I process the order with video membership
	Then video membership should be activated
