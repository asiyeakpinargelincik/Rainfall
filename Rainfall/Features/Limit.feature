
Feature:API Testing for Rainfall Measurements

    @limit
    Scenario: Requesting Rainfall Measurements for an Individual Station with Limit and parameter name

        When User send a GET request is made for an individual station "52203" for "rainfall" parameter with a limit parameter set to 5
        Then the response status code should be 200
        Then the API should respond with a list containing no more than 5 rainfall measurements
        And each measurement should have 5 relevant information
        
    @date
    Scenario Outline:Requesting Rainfall Measurements for an Individual Station on a Specific Date
        When User requests rainfall measurements for station ID "<stationId>" on date "<specificDate>"
        Then API should respond with status code 200
        And  Response should include the "<stationId>" on date "<specificDate>"details
        And Response should include valid JSON format
            Examples:
              | specificDate | stationId |
              | 2024-02-06   | 52203     |
              | 2024-01-31   | 4163      |
              | 2024-01-17   | 1234      |