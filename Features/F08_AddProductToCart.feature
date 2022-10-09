Feature: F08_Add product to cart Feature

@smoke
 Scenario: User add product to cart
 Given User search for a product
 When user add product to the cart
 And User navigates to cart and find product
 Then User can remove the product
