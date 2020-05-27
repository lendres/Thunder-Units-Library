# Thunder-Units-Library
A library for converting units of measurement (physics or engineering units).  For example, it will convert meters to kilometers or Fahrenheit to Celsius.

The conversion factors are all held in an XML file.  Adding new units or creating a customized set of available units is as simple as editing the file.

## How it Works
Each set of related units (units that can be converted from one to another) as specified as a "UnitGroup."  For example, the "Temperature" UnitGroup contains Fahrenheit, Celsius, Kelvin, et cetera and the "Length" UnitGroup contains kilometers, meters, miles, feet, et cetera.

Each UnitGroup contains a base unit.  To convert from one unit to another, the "from" unit is first converted to the base unit and then converted to the "to" unit.  By doing this, it is not necessary to define every possible combination of units.  One must only specify the relationship between each unit and the base unit.  See the "units.xml" file for additional details.

## About the Library
### Github Page
https://github.com/lendres/Thunder-Units-Library

### Original Post
The original post for the library was at the location below.  It seems this page no longer exists.
http://www.codeproject.com/KB/cs/Thunder.aspx

## Authors
Original author:
* **Robert Harwood**

Minor modifications, additions, and bug fixes have been made by:
* **Lance A. Endres** - [lendres](https://github.com/lendres)

## License

See the included **License.txt** file.

## Examples
### Test Application
An example use is provided in the source code.  This example parses an input string to separate the units in the string from the value.

### Alternate Use
Rather parsing a string containing both value and units, it is often useful to separate these two.  In that case, a use like below may be more suitable.

```csharp
// Initialize library.
Thor.Units.UnitConverter _unitsConverter;
_unitsConverter =  (Thor.Units.UnitConverter)Thor.Units.InterfaceFactory.CreateUnitConverter();
_unitsConverter.OnError += new Thor.Units.UnitEventHandler(Converter_OnError);
_unitsConverter.LoadUnitsFile(unitsFilePath);

// Use conversion feature.
double output = 0;
_unitsConverter.ConvertUnits(value, fromUnit, toUnit, out output);
```

