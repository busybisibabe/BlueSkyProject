Feature: Registration

@workitem111
Scenario: Valid Registration
	Given I navigate to "https://longrichway.com/"
	When I click on register button
	And I enter First Name "Tester1"
	And I enter Last Name "Blaky"
	And I enter Email Address "allaboutu@gmail.com"
	And I enter Phone Number "12345678911"
	And I enter Password "Wonderful"
	And I enter Confirm Password "Wonderful"
	And I enter Address "22 Western Avenue"
	And I enter Town "Alekuwodo"
	And I enter State "Oyo"
	And I click on Create Account Button
	Then the message "Registration Successful, Login to your Account" is displayed on the page