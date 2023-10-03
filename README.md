# c-net-FutureValue
## Future Value Calculator - C#.NET WinForms Application

### Description:

This project is a simple Windows Forms application built using C#.NET, designed to calculate the future value of a monthly investment over a specified period, taking into consideration a given interest rate.

### Objectives:

1. **User Input**: Provide a user-friendly interface where users can input:
   - Monthly Investment Amount
   - Yearly Interest Rate
   - Number of Years for the investment

2. **Calculation**:
   - Convert the yearly interest rate to a monthly interest rate.
   - Using a loop, calculate the future value of the investment over the specified period.
   - Display the future value in currency format.

3. **Error Handling**:
   - Implement try-catch blocks to handle potential input errors, specifically format exceptions, and provide the user with meaningful feedback when an incorrect input is provided.

### How it's achieved:

1. **Windows Forms Controls**: Utilized standard controls like text boxes for input, buttons for triggering calculations and exiting the application, and labels to display information to the user.

2. **Event-Driven Programming**: Leveraged C#.NET's event-driven model by using click event handlers for both the calculate (`btnCalc_Click`) and exit (`btnExit_Click`) functions.

3. **For Loop for Compound Interest Calculation**: Employed a for-loop to iterate through each month, applying the monthly interest rate and adding the monthly investment to get the compound future value.

4. **Error Handling**: Implemented a try-catch block to catch `FormatException` when the input is not in the expected format. Upon catching an exception, the application displays a MessageBox informing the user about the error.

5. **Focus Management**: After performing the calculation, the focus is returned to the monthly investment input for a smooth user experience, allowing for easy modification and recalculation.

### Conclusion:

This application provides a practical use case of basic financial calculations using a C#.NET Windows Forms interface. It showcases the principles of user input validation, event-driven programming, and the power of loops in financial calculations.
