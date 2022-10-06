Feature: Send to friend Feature

@smoke
 Scenario: User send product to a friend 
 Given User Register to the system
 Then User search for a product
 When User Add a friend e-mail and send
 Then successful Msg appears
   
