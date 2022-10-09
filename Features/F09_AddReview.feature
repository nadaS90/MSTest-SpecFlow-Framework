Feature: F09_Add review

@smoke
 Scenario: User add review to a product
 Given user login with valid email and password
 And User search for a product
 When User add review
 Then success Meg appears

 
