# Introduction to Classes Exercises

Introduction to Classes contains a series of exercises which require you to define and use classes of increasing difficulty. The series is grouped into three sets: Easy, Medium, and Difficult.

A starter Visual Studio Solution containing all class and test source files you'll need has been created for you.

## Easier

### **Product**

**Class Variables**

| Variable Name | Data Type | Description |
|---------------|-----------|-------------|
| name | string | Holds the name of the product. |
| price | decimal | Holds the price of the product. |
| weightInOunces | double | Holds the weight (in ounces) of the product. |



### **Company**

**Class Variables**

| Variable Name | Data Type | Description |
|---------------|-----------|-------------|
| name | string | Holds the name of the company. |
| numberOfEmployees | int | Holds the number of employees. |
| revenue | decimal | Holds the company revenue. |
| expenses | decimal | Holds the company expenses. |


**Methods**

| Method Name | Return Type | Description |
|---------------|-----------|-------------|
| GetCompanySize() | string | A company is "small" if less than 50 employees, "medium" if between 51 and 250 employees, "large" if greater than 250 employees |
| GetProfit() | decimal | Calculated by subtracting expenses from revenue. |

### **Person**

**Class Variables**

| Variable Name | Data Type | Description |
|---------------|-----------|-------------|
| firstName | string | Holds the first name of the person. |
| lastName | string | Holds the last name of the person. |
| age | int | Holds the age of the person. |


**Methods**

| Method Name | Return Type | Description |
|---------------|-----------|-------------|
| GetFullName() | string | Returns the First Name + Last Name of the Person. |
| IsAdult() | bool | Returns `true` if the person is 18 or older. |


## Medium Difficulty

### **Dog**

**Class Variables**

| Variable Name | Data Type | Description |
|---------------|-----------|-------------|
| isSleeping | bool | `TRUE` if the dog is asleep. `FALSE` if not. **All new dogs are awake by default** |

**Methods**

| Method Name | Return Type | Description |
|---------------|-----------|-------------|
| MakeSound() | string | Returns `"Zzzzz..."` if the dog is asleep. Returns `"woof!"` if the dog is awake.  |
| Sleep() | void | Sets `isSleeping` to `true`.  |
| WakeUp() | void | Sets `isSleeping` to `false`.  |

### **Shopping Cart**

**Class Variables**

| Variable Name | Data Type | Description |
|---------------|-----------|-------------|
| totalNumberOfItems | int | The number of items in the shopping cart. **All shopping carts have 0 items by default** |
| totalAmountOwed | double | The total for the shopping cart. **All shopping carts have 0.0 owed by default** |

**Methods**

| Method Name | Return Type | Description |
|---------------|-----------|-------------|
| GetAveragePricePerItem() | double | Returns the `totalAmountOwed / totalNumberOfItems`.  |
| AddItems(int numberOfItems, double pricePerItem) | void | Updates `totalNumberOfItems` and increases `totalAmountOwed` by `(pricePerItem * numberOfItems)`  |
| Empty() | void | Returns `totalNumberOfItems` and `totalAmountOwed` to 0.  |

## Difficult

### **Calculator**
 
**Class Variables**

| Variable Name | Data Type | Description |
|---------------|-----------|-------------|
| result | int | Current value of the calculator |

 
**Constructors**

| Signature | Description |
|---------------|-------------|
| Calculator(int startingResult)| Starting value of the calculator |

**Methods**

| Method Name | Return Type | Description |
|---------------|-----------|-------------|
| Add(int addend) | int | Adds `addend` to `result` and returns the current value of `result`.  |
| Subtract(int subtrahend) | int | Subtracts `subtrahend` from the current value of `result` and returns the current value of `result`.  |
| Multipy(int multiplier) | int | Multiplies current result by `multiplier` and returns the current value of `result`.  |
| Power(int exponent) | int | Raises `result` to power of `exponent`. Negative exponents should use the absoluve value. Returns the current value of `result`  |
| Reset() | void | Resets `result` to 0.  |