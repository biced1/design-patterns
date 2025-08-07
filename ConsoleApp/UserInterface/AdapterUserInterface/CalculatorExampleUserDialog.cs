using Adapter.CalculatorExample.Calculator;
using ConsoleHelper;

namespace ConsoleApp.UserInterface.AdapterUserInterface;

public class CalculatorExampleUserDialog : UserDialogBase
{
    public CalculatorExampleUserDialog(IConsole console, UserDialogBase previousDialog) : base(console, previousDialog)
    { }

    public override string DisplayName => "Calculator Adapter";

    public override void Run()
    {
        var userInput = new IntUserInput();
        while (!userInput.ShouldGoBack)
        {
            var options = new List<string>
            {
                "Legacy Calculator",
                "Adapter Calculator"
            };
            _console.WriteLine("Please select a service to use");
            _console.ListItems(options);
            userInput = _console.GetIntInput(1, options.Count);
            if (userInput.ShouldGoBack)
            {
                GoBack();
            }
            else
            {
                var calculatorService = new CalculatorService();
                if (userInput.UserInput == 1)
                {
                    RunLegacyCalculator(calculatorService);
                }
                else
                {
                    var areaCalculatorAdapter = new AreaCalculatorAdapter(calculatorService);
                    RunCalculatorAdapter(areaCalculatorAdapter);
                }
            }
        }
    }

    private void RunLegacyCalculator(CalculatorService calculatorService)
    {
        var shapeSelection = GetShapeSelection();
        switch (shapeSelection)
        {
            case 1:
                _console.WriteLine("Enter the radius of the circle");
                calculatorService.fa = _console.GetDoubleInput();
                calculatorService.cir_calc();
                _console.WriteLine($"The area of your circle is {calculatorService.r}");
                break;
            case 2:
                _console.WriteLine("Enter the radius of the sphere");
                calculatorService.fa = _console.GetDoubleInput();
                calculatorService.sph_calc();
                _console.WriteLine($"The area of your sphere is {calculatorService.r}");
                break;
            case 3:
                _console.WriteLine("Enter the length of the base of the triangle");
                calculatorService.fa = _console.GetDoubleInput();
                _console.WriteLine("Enter the length of the height of the triangle");
                calculatorService.fa = _console.GetDoubleInput();
                calculatorService.tri_calc();
                _console.WriteLine($"The area of your triangle is {calculatorService.r}");
                break;
            case 4:
            default:
                _console.WriteLine("Enter the length of the base of the pyramid");
                calculatorService.fa = _console.GetDoubleInput();
                _console.WriteLine("Enter the length of the width of the pyramid");
                calculatorService.fa = _console.GetDoubleInput();
                _console.WriteLine("Enter the length of the height of the pyramid");
                calculatorService.aa = [_console.GetDoubleInput()];
                calculatorService.pyr_calc();
                _console.WriteLine($"The area of your pyramid is {calculatorService.r}");
                break;
        }
    }

    private void RunCalculatorAdapter(AreaCalculatorAdapter areaCalculatorAdapter)
    {
        var shapeSelection = GetShapeSelection();
        switch (shapeSelection)
        {
            case 1:
                _console.WriteLine("Enter the radius of the circle");
                var circleRadius = areaCalculatorAdapter.CalculateCircle(_console.GetDoubleInput());
                _console.WriteLine($"The area of your circle is {circleRadius}");
                break;
            case 2:
                _console.WriteLine("Enter the radius of the sphere");
                var sphereRadius = areaCalculatorAdapter.CalculateSphere(_console.GetDoubleInput());
                _console.WriteLine($"The area of your sphere is {sphereRadius}");
                break;
            case 3:
                _console.WriteLine("Enter the length of the base of the triangle");
                var triangeBase = _console.GetDoubleInput();
                _console.WriteLine("Enter the length of the height of the triangle");
                var triangleHeight = _console.GetDoubleInput();
                var triangleRadius = areaCalculatorAdapter.CalculateTriangle(triangeBase, triangeBase);
                _console.WriteLine($"The area of your triangle is {triangleRadius}");
                break;
            case 4:
            default:
                _console.WriteLine("Enter the length of the base of the pyramid");
                var pyramidBase = _console.GetDoubleInput();
                _console.WriteLine("Enter the length of the width of the pyramid");
                var pyramidLength = _console.GetDoubleInput();
                _console.WriteLine("Enter the length of the height of the pyramid");
                var pyramidHeight = _console.GetDoubleInput();
                var pyramidRadius = areaCalculatorAdapter.CalculatePyramid(pyramidBase, pyramidLength, pyramidHeight);
                _console.WriteLine($"The area of your pyramid is {pyramidRadius}");
                break;
        }
    }

    private int GetShapeSelection()
    {
        var shapes = new List<string> { "Circle", "Sphere", "Triangle", "Pyramid" };
        _console.WriteLine("Choose a shape to calculate the area for");
        _console.ListItems(shapes, true);
        var userInput = _console.GetIntInput(1, shapes.Count, true);
        return userInput.UserInput ?? 0;
    }
}
