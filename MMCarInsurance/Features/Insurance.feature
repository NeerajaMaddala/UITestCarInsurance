Feature:Insurance

@Negative
Scenario Outline: verify form level Error message
    Given I navigate to the Car Insurance
	When User selects the Terms and conditions check box
	And Click on Continue button
	Then the "<Error Message>"  should display

Examples:
     | Scenario                | Error Message          |
     |verify form error message| Please select an option|

@Positive
 Scenario: verify user fill find your car details
    Given I navigate to the Car Insurance
	Then User fills find your car details in car insurance Page