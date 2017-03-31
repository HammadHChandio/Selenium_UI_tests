Feature: SearchBar
	In order to search for Multiple items on amazon 
	As a customer 
	I want to be able to search for specific item 

Background: 
Given Amazon site is available

@Search 
Scenario: Searching for Items
	Given Search bar is available 
	And I want to search for "Thinkpad" 
	When I press search 
	Then I should see result for thinkpads
