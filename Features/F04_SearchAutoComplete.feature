Feature: F04_Search auto complete Feature

@smoke
 Scenario: User can search products using autocoplete
    Given User type part of product name
    Then  User find the product and relative products