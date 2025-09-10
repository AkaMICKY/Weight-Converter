// 🏋️ Weight Converter
// --------------------------------------------------
// 📌 Description
// A simple C# console app to convert between common weight units.
// Supports kilograms, pounds, grams, and ounces with accurate conversion factors.
//
// ✅ Features
// - 🔄 Convert Kilograms ⇄ Pounds
// - 🔄 Convert Grams ⇄ Ounces
// - 🛡️ Uses TryParse for safe input validation
// - 🎯 Rounds results to 2 decimal places
// - ⚠️ Error messages for invalid input
//
// 📖 How It Works
// 1️⃣ User selects a conversion option from the menu.
// 2️⃣ Program asks for the weight input.
// 3️⃣ Input is validated with double.TryParse.
// 4️⃣ Result is calculated using the correct conversion formula.
// 5️⃣ Answer is displayed with units.
//
// 🧮 Conversion Formulas
// ⚖️ Kg → Lbs = kg * 2.20462
// ⚖️ Lbs → Kg = lbs * 0.453592
// ⚖️ G → Oz  = g * 0.035274
// ⚖️ Oz → G  = oz * 28.3495
//
// 🚀 Future Improvements
// - 🔁 Add a loop so the Program keeps running until the User exits
// - ➕ Add more units (Stone, Tonne, etc.)
// - 🖥️ Build a GUI version for easier use
// - 📜 Save past conversions in an array for history
//
// ▶️ Example Run
// Hello, Welcome To Weight Converter
// Select An Option
// 1. Kilograms(Kg) ==> Pounds(Lbs)
// 2. Pounds(Lbs) ==> Kilograms(Kg)
// 3. Grams(G) ==> Ounces(Oz)
// 4. Ounces(Oz) ==> Grams(G)
// --Option: 1
// Enter Weight in Kilogram(Kg): 10
// 10 Kilograms(Kg) is 22.05 Pounds(Lbs)

