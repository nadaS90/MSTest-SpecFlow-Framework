Feature: F06_FollowUs Feature

@smoke
 Scenario: User opens facebook link
    Given user clicks on facebook
    Then user navigates to facebook "http://www.facebook.com/nopCommerce"

@smoke
  Scenario: User opens Twitter link
    Given user clicks on twitter
    Then user navigates to twitter "https://twitter.com/nopCommerce"

@smoke
  Scenario: User opens youtube link
    Given user clicks on youtube
    Then user navigates to youtube "https://www.youtube.com/user/nopCommerce"
