Feature: Task 01_3:Two bugs 

A short summary of the feature


Scenario: Login to the web application is not working.
	Given I am at the home page of web application.
	When I click the Login-To-Your-Account button.
	And I enter the credentials.
	And I click the Login button
	Then I am unable to loggedin.

Scenario: Not rendering to About Us page.
	Given I am at the home page of web application.
	When I click the About Us button.
	And it is unclickable.
