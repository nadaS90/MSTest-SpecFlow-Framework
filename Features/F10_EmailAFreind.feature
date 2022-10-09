Feature: F10_Send to friend Feature

@smoke
 Scenario: User send product to a friend 
 Given user login with valid email and password
 And User search for a product
 When User Add a friend e-mail and send
 Then successful Msg appears
   
