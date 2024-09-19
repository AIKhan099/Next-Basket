Feature: Task 01_2: Create 5 BDD test cases

A short summary of the feature


Scenario: Creation of account.
	Given I am at the home page of web application.
	When I click the Login-To-Your-Account button.
	And I click the create-new-account button.
	And I enter name, email, password and confirm password.
	And I check the agreement to the privacy policy.
	And I click the create account button.
	Then A new account is created.



Scenario: Login to the web application.
	Given I am at the home page of web application.
	When I click the Login-To-Your-Account button.
	And I enter the credentials.
	And I click the Login button
	Then I successfully loggedin.

Scenario: Adding product to wishlist.
	Given I am at the home page of web application.
	When I hover over the product and click on heart.
	And I click the wishlist button.
	Then I can find the added product in the wishlist.

Scenario: 01 Ordering the product
	Given I am at the home page of web application.
	When I click on the first product.
	And I click add to basket.
	And I click on basket and click on go to payment.
	And I enter email and click on Continue As Guest button.
	Then I enter all the details on check out page and click on confirm order.

Scenario: 02 Checking the presence of 50 percent off label from product.
	Given I am at the home page of web application.
	Then I check every product whether it has 50 percent label or not.


