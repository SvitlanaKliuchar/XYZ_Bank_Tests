Feature: XYZ_Bank
Sort by Post Code


@xyz_bank
Scenario: Perfom sorting by Post Code
	Given the user opens the website
	And clicks Bank Manager Login button
	And clicks Customers button
	When clicks on the post code header
	Then the customers are sorted by Post Code