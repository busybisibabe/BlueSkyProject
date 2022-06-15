Feature: Donation
	As a user of Coding fo kids website
	I want to give money
	so that I can donate to a great cause

@mytag
Scenario: Donating to CodingforKids
	Given the user navigates to "https://codingbyk.com/"
	And the user clicks Accept cookies
	And the user clicks Donate
	When the user clicks continue to donation
	And the user clicks enter own amount button
	When the user enter own amount '<amount>'
	#And user selects amount '<amount1>'
	#And user selects amount '<amount2>'
	#And user selects amount '<amount3>'
	#And user selects amount '<amount4>'
	#And user selects amount '<amount5>'
	And the user clicks continue button
	And user enters first name '<fname>'
	And user enter last name '<lname>'
	And user enters email address '<email>'
	#And the user click the make this an anonymous donation
	#And the user enter comment
	And the user select donate with stripe '<stripe>'
	#And the user  select donate with stripe credit '<stripeCc>'
	#And the user enter card number
	#And the uder enter CVC
	#And the user enter card holder name '<cname>'
	#And the user enter card expiry in month/year '<mm/yy>'
	#And the user select donate with Paypal '<Paypal>'
	And the user clicks Agree to term
	#And the user clicks edit donation '<edit>'
	And user click donate no button


	Examples: 
	| amount | fName | lName | email          | stripe |
	| 80     | bola  | ola   | bola@email.com | stripe |