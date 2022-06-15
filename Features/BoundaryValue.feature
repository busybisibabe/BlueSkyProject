Feature: Boundary Value Analysis
	as a user of Coding for kids website
	I want to navigate to the website
	so I can complete the registration form

@BVA
Scenario: Valid Registration using 5-18years
	Given the user navigates to "https://codingbyk.com/"
	And the user clicks Accept cookies
	When the user clicks Application/Registration
	And the user enter Student full name'<Student fullname>'
	And the user selects student age from the drop-down menu '<Age>'
	And the user enter Parent/Guardian name '<Guardian name>'
	And the user enter email address '<Email address>'
	And the user enter Parent phone with country code '<Phone number>'
	And the user enter street address '<Street>'
	And the user enter Apartment '<Apartment>'
	And the user enter City '<City>'
	And the user enter Street/Province '<Province>'
	And the user enter Zip/Postal Code '<Zip Code>'
	And the user select Country from the country drop-down menu '<Country>'
	And the user click on one Course 
	And the user enter their experience in coding in the text box '<Experience>'
	And the user enter Motivation in the text box '<Motivation>'
	When the user clicks Send Message button
	Then the message "Thank you for registering with us, please join our Telegram Group here: https://t.me/codingforkidsbykids to get future notifications" should be displayed


	Examples:
	| Student fullname | Age | Guardian name | Email address     | Phone number   | Street           | Apartment | City   | Province | Zip Code | Country    | Experience          | Motivation          | Result |
	| Tola kinley      | 4   | Lola Lee      | lolalee@aol.com   | +2337017567740 | 22 Adkan road    | G         | Surjah | Barjah   | GZ2 123  | Uzbekistan | learning new things | Pass                | Fail   |
	| Debbie kinley    | 5   | Debra Lee     | deblee@aol.com    | +2337016767740 | 22 Adkan road    | G         | Surjah | Barjah   | WZ2 123  | Uzbekistan | basic               | learning new things | Pass   |
	| Agnes Akiney     | 6   | John Brown    | bronlew@aol.com   | +2337016927140 | 32 Joeban street | E         | Surjah | Barjah   | EN2 T10  | Uzbekistan | none                | Gaming              | Pass   |
	| Goa Sajid        | 17  | Memora Zee    | memora@yahoo.com  | +2337016887040 | 34 jebba road    | F         | Surjah | Barjah   | SE2 D30  | Uzbekistan | moderate            | artificial          | Pass   |
	| Susan Joe        | 18  | Emmal Dee     | emma12ee@aol.com  | +2337016767740 | 56 Hagge road    | G         | Surjah | Barjah   | AB2 R23  | Uzbekistan | none                | Inquisitive         | Pass   |
	| Aduss McKiney    | 19  | Kanye Brown   | Kbronlenw@aol.com | +2337216927140 | 38 Joeban street | E         | Surjah | Barjah   | YN2 T10  | Uzbekistan | Gaming              | Newbie              | Fail   |

	@BVAInvalid
	Scenario: InValid Registration using 5-18years
	Given the user navigates to "https://codingbyk.com/"
	And the user clicks Accept cookies
	When the user clicks Application/Registration
	And the user enter Student full name'<Student fullname>'
	And the user selects student age from the drop-down menu '<Age>'
	And the user enter Parent/Guardian name '<Guardian name>'
	And the user enter email address '<Email address>'
	And the user enter Parent phone with country code '<Phone number>'
	And the user enter street address '<Street>'
	And the user enter Apartment '<Apartment>'
	And the user enter City '<City>'
	And the user enter Street/Province '<Province>'
	And the user enter Zip/Postal Code '<Zip Code>'
	And the user select Country from the country drop-down menu '<Country>'
	And the user click on one Course  
	And the user enter their experience in coding in the text box '<Experience>'
	And the user enter Motivation in the text box '<Motivation>'
	When the user clicks Send Message button
	#Then the user should get error message


	Examples:
	| Student fullname | Age | Guardian name | Email address     | Phone number    | Street           | Apartment | City   | Province | Zip Code | Country    | Experience  | Motivation          | Result |
	| Tola kinley      | 4   | Lola Lee      | lolalee@aol.com   | +2337017567740  | 22 Adkan road    | G         | Surjah | Barjah   | GZ2 123  | Uzbekistan | basic       | learning new things | Pass   |
	| Aduss McKiney    | 19  | Kanye Brown   | Kbronlenw@aol.com | +2337216927140  | 38 Joeban street | E         | Surjah | Barjah   | YN2 T10  | Uzbekistan | none        | Gaming              | Pass   |
	
	

@EP
Scenario: Valid Registration using 5-18years - EP
	Given the user navigates to "https://codingbyk.com/"
	And the user clicks Accept cookies
	When the user clicks Application/Registration
	And the user enter Student full name'<Student fullname>'
	And the user selects student age from the drop-down menu '<Age>'
	And the user enter Parent/Guardian name '<Guardian name>'
	And the user enter email address '<Email address>'
	And the user enter Parent phone with country code '<Phone number>'
	And the user enter street address '<Street>'
	And the user enter Apartment '<Apartment>'
	And the user enter City '<City>'
	And the user enter Street/Province '<Province>'
	And the user enter Zip/Postal Code '<Zip Code>'
	And the user select Country from the country drop-down menu '<Country>'
	And the user click on one Course  
	And the user enter their experience in coding in the text box '<Experience>'
	And the user enter Motivation in the text box '<Motivation>'
	When the user clicks Send Message button
	Then the message "Thank you for registering with us, please join our Telegram Group here: https://t.me/codingforkidsbykids to get future notifications" should be displayed


	Examples:
	| Student fullname | Age | Guardian name | Email address   | Phone number   | Street          | Apartment | City   | Province | Zip Code | Country    | Experience | Motivation          | Result |
	| Benbie kinler    | 8   | Ora Lewis     | omaee@aol.com   | +2337016767743 | 2 Adkan road    | G         | Surjah | Barjah   | WT2 123  | Uzbekistan | basic      | learning new things | Pass   |
	| Bange kiney      | 14  | Jott Brownby  | bronwer@aol.com | +2337016927147 | 6 Joeban street | E         | Surjah | Barjah   | WN2 T10  | Uzbekistan | none       | Gaming              | Pass   |
	


@EPInvalid
Scenario: InValid Registration using 5-18years - EP
	Given the user navigates to "https://codingbyk.com/"
	And the user clicks Accept cookies
	When the user clicks Application/Registration
	And the user enter Student full name'<Student fullname>'
	And the user selects student age from the drop-down menu '<Age>'
	And the user enter Parent/Guardian name '<Guardian name>'
	And the user enter email address '<Email address>'
	And the user enter Parent phone with country code '<Phone number>'
	And the user enter street address '<Street>'
	And the user enter Apartment '<Apartment>'
	And the user enter City '<City>'
	And the user enter Street/Province '<Province>'
	And the user enter Zip/Postal Code '<Zip Code>'
	And the user select Country from the country drop-down menu '<Country>'
	And the user click on one Course  
	And the user enter their experience in coding in the text box '<Experience>'
	And the user enter Motivation in the text box '<Motivation>'
	When the user clicks Send Message button
	#Then user should not be able to send message.

	Examples:
	| Student fullname | Age | Guardian name | Email address   | Phone number   | Street          | Apartment | City   | Province | Zip Code | Country    | Experience | Motivation | Result |
	| Olaby tey        | 38  | John Yoyo     | yronlew@aol.com | +2337016927143 | 21 oeban street | E         | Surjah | Barjah   | EN2 T10  | Uzbekistan | none       | Gaming     | Pass   |
	