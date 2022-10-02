Feature: Register Feature

 @smoke

  Scenario: user register with valid data
    Given user directed to register page
    And user select the gender
    When user enter first name and last name
    And user enter valid email
    And user fills required Password fields
    Then user register successfully