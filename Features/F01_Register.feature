Feature: F01_Register Feature

@smoke

  Scenario: user could register with valid data successfully
    Given user navigates to register page
    And user select gender
    When enter first name and last name
    And user enter email
    And user fills Password fields
    Then user could register successfully