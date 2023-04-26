Feature: ShoppingCartFeature

A simple feature with a single test on a shopping cart that 
starts out with 4 items, searches for lower price items and removes 
one item.

Scenario: Remove one item from a shopping cart of four items
	Given I add 4 random items to my cart
	When I view my cart
	Then I find total 4 items in my cart 
	When I search for lowest price item
	And I am able to remove the lowest price item from my cart
	Then I am able to verify 3 items in my cart
	
