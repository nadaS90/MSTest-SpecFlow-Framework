Feature: Register Feature

@smoke

  Scenario: user could register with valid data successfully
    Given user navigates to register page
    And user select gender
    When enter first name and last name
    And user enter email
        | Email     |
        | <Email>   |
    And user fills Password fields
        | Password   |
        | <Password> | 
    Then user could register successfully