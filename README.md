Rainfall API Enhancement Testing

The task explanations :
-The following API is a public API used to report rainfall from measurement stations around the UK
-Rainfall API reference
-THERE ARE A NUMBER OF DOCUMENTED ENDPOINTS, 
-BUT YOU SHOULD ONLY NEED TO CONSUME ONE OF THEM FOR THIS PART OF THE EXERCISE. -WE RECOMMEND RETURNING TO THE DOCUMENTATION ONCE YOU’VE UNDERSTOOD THE REQUIREMENTS.
-2 new features have recently been added by the development team:
• A request for rainfall measurements for an individual station can now include a limit parameter which limits the amount of rainfall measurements that are returned (Rainfall API reference )
• Rainfall measurements for an individual station can now be requested for a specific date Using .net and Specflow, create automated tests that validate this new functionality works as expected.

According to this requirements,the task had been done using 
-Rider IDE
-C# as a programming language
-RestSharp as REST Api testing library
-NUnit framework for assetion
-Newtonsoft.Json.Ling for Json parsing
-Unit test runner

This task needs some improvement like hook class and ConfigFile to store configuration key and values.
This fetures needs more negative scenarios and comprehensive positive tests for sufficient test covarage.
