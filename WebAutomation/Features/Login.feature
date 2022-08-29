
Feature: Verify Setup Action
    Scenario:1 Open Mp web
        Given Open browser
        And go to  https://mpwebdemo.mhkdevsandbox.com
        Then User should be redirected to login screen
        Scenario:2 Login to Mpweb
            When UserName "DZCPS"  Password "mp0292"
            And click on the login button
            Then the user should be logged in to MP Web
            Scenario:3 Navigate to Setup List
                Given User is on Mpweb welcome screen
                And Navigate to Windows dropdown
                And Open the Windows dropdown
                When Click on Setup in Windows dropdown
                Then user should be redirected to MP Web Setup Action screen
                Scenario:4 Navigate to Action in Setup list
                    Given I am on MP Web Setup Action screen
                    And Navigate to Setup List dropdown
                    When Select any value from the setup List
                    Then User should be redirected to Selected setup list
                    Scenario:5 Add Record
                        Given I am on MP Web Setup Action screen
                        And Click on Add button
                        And Navigate to Program dropdown
                        And Select the value from spreadsheet
                        And Navigate to Primary dropdown
                        And Select the value from spreadsheet
                        And Navigate to Secondary text field
                        And Select the value from spreadsheet
                        And Navigate to Site dropdown
                        And Select the value from spreadsheet
                        And Navigate to Product dropdown
                        And Select the value from spreadsheet
                        And Click on Save button
                        Scenario:6 Edit Record (Save)
                            Given Created record selected by default
                            And Change any value
                            When Click on Save
                            Then Value should be reset to last saved values
                            Scenario:7 Edit Record (Cancel)
                                Given Created record selected by defaults
                                And Select the value from spreadsheet                               



