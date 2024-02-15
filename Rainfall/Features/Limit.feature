
Feature:API Testing for Rainfall Measurements

    @limit
    Scenario: Requesting Rainfall Measurements for an Individual Station with Limit and parameter name

        When User send a GET request is made for an individual station "52203" for "rainfall" parameter with a limit parameter set to 5
        Then the response status code should be 200
        Then the API should respond with a list containing no more than 5 rainfall measurements
        And each measurement should have 5 relevant information