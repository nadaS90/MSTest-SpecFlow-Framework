Feature:Login feature

@smoke

  @smoke
  Scenario: user could login with valid email and password
    Given user go to login page
    And user login with valid email and password
    Then user login to the system successfully
    When user logout the system
    But user login with invalid email and password "wrong@example.com" and "P@ssw0rd"
    Then user could not login to the system