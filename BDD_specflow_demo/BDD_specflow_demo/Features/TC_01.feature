Feature: TC_01
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@invalid
Scenario: Login with information invalid
 Given I am on LiveGuru99 site
 And I input username "abc@xyz.com" and password "123123"
 When I click Login button
 Then The error message should be display
