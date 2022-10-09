Feature: F05_Hover Feature

@smoke
 Scenario: guest user could hover categories successfully
    Given user hover categories
    And user select sub category
    Then user directed to the item page