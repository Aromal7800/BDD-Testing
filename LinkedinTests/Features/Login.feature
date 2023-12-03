Feature: Login

user logs in with valid credentials(username,password)
the home page will load after sucessful login

Background: 
	Given User will be on the login page

@positive
Scenario Outline: Login with Valid Credentials
	When User will enter username '<UserName>'
	And User will enter password '<Password>'
	And User will click on login button
	Then User will redirect to Homepage
Examples: 
    | UserName    | Password |
    | abc@xyz.com | 12345    |
    | def@xyz.com | 98765    |
@negative
Scenario Outline: Login with InValid Credentials
	When User will enter username '<UserName>'
	And User will enter password '<Password>'
	And User will click on login button
	Then Error message for password length should be throw
Examples: 
    | UserName    | Password |
    | aaa@xyz.com | 12345    |
    | ddd@xyz.com | 98765    |
@regression
Scenario Outline: Check for password Hidden Display
	When User will enter password '<Password>'
	And User will click on Show link in the password textbox
	Then the password characters should be shown
Examples: 
    | Password |
    | 1234     |
@regression
Scenario Outline: Check for password Show Display
	When User will enter password '<Password>'
	And User will click on Show link in the password textbox
	And User will click on Hide link in the password textbox
	Then the password characters should go back to *
Examples: 
    | Password |
    | 1234     |