Feature: FollowUs Feature

@smoke
 Scenario: User selects product to add to wishist
    Given User clicks on add product wishlist
    Then Success message appears

  Scenario: user finds product in wishlist
    Given User clicks on add product wishlist
    And   User navigates to wishlist page
    Then  product found in wishlist page
