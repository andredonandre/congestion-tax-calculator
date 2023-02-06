# Execution Approach
Goal: Ensure software behaviour is normal, create usable entry point,Set up groundwork for next steps.
- First focus was to understand the code written and how it was organised in relation to the expected behaviour of the program.
- I then Identified testable units of the code.
- Wrote tests based on the requirements. This helped to identify parts of the program that were not working as expected.
- Fixed bugs that I could Identify from the tests.
- Created a blazor project as entry point to the program. This served as a UI for testing purposes as well.
- Created a c# class library project that holds the data access implmentation for Building the CMS.

# Questions

1 - how will users be interating with the calculator?

2 - Will the calculator be communicating with another system?

3 - Should the calculator be limited to One country(Sweden)?

4 - Should the data be modelled with Global scalability in mind?

5 - Are the types of rules limited to the ones stated or should we consider the posibility of new rules?

7 - Are the vehicle exceptions based on the type of vehicle or the classification of the vehicle?

8 - What data should be editable in the CMS?

**Are the dates test cases?

# Assumptions made:
- The application will not be communicating with other systems
- For now, the focus of the calculator is Sweden
- Only official Public holidays for the year 2013 in Sweden are valid
- Unique identification of vehicles is not necessary for this use case


# Additional work/ Improvements
- The methods functions in calculator can be simplified(refactored).
- The Data model for the CMS and Project can be conceptualized more extensively with all use cases in mind
- Data Is currently being stored on a local database but could be moved to a more accessible remote location(cloud). 
- Times and their respective taxes should be stored outside of the logic.
- The classification of vehicles can be improved i.e Vehicle types and Classifications should be differentiated 

# Note: Project is now targeting .net 7
