# Viaje - C# Travel Program

This is a C# console program that manages travel records and calculates costs based on distance and a minimum mileage. 

## Project Structure

- `CViaje.cs`: Contains the `CViaje` class which handles travel information such as distance, cost per kilometer, and methods to calculate total cost.
- `CEjecutora.cs`: Contains the `Main` method to interact with the user, input travel data, and display results.

## Features

1. Set the cost per kilometer and minimum mileage.
2. Record multiple travels with domain (license plate) and distance traveled.
3. Determine which travel has the highest distance.
4. Calculate total cost for each travel.
5. Simple validation for numeric input.

## How to Run

1. Open the project in Visual Studio or any C# IDE.
2. Compile the project.
3. Run the console application.
4. Follow the prompts to input travel data.
5. Enter `Fin` as the domain to finish the input and see the travel with the highest distance.

## Example

Enter cost per kilometer: 10
Enter minimum mileage: 50
Enter domain (for finish type 'Fin'): AAA111
Enter distance traveled: 70
Enter domain (for finish type 'Fin'): BBB222
Enter distance traveled: 30
Enter domain (for finish type 'Fin'): Fin

TRAVEL WITH HIGHEST DISTANCE:
Domain: AAA111 - Distance: 70 km - Cost per km: 10 - Total cost: 700

