Feature: Search for products

 @smoke

 Scenario Outline: user could search using product name
    Given user click on search field
    And user enter "<search>" to search
    Then user find the product and relative products

    Examples:
      | search |
      | book   |
      | laptop |
      | nike   |


  Scenario Outline: user could search for product using sku
    Given user click on search field
    And user enter "<search>" to search
    Then user find the product and relative products

    Examples:
      | search    |
      | SCI_FAITH |
      | APPLE_CAM |
      | SF_PRO_11 |