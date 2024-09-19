
Feature: Task 01_1 : Automating two test cases

A short summary of the feature

#@tag1
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