using NUnit.Framework;


[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;
    private CalculatorOther _calculatorOther;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
        _calculatorOther = new CalculatorOther();
    }

    [Test]
    public void Add_WhenCalled_ReturnsSumOfArguments()
    {
        int a = 5;
        int b = 10;
        int result = _calculator.Add(a, b);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void IsOdd_ReturnsTrue_WhenNumberIsOdd()
    {

        int c = 5;
        bool result = _calculatorOther.IsOdd(c);
        Assert.AreEqual(true, result);  // 5 is odd, so expected result is true
    }

    [Test]
    public void IsOdd_ReturnsFalse_WhenNumberIsEven()
    {
        int c = 4;
        bool result = _calculatorOther.IsOdd(c);
        Assert.AreEqual(false, result);  // 4 is even, so expected result is false
    }

    [Test]
    public void IsPrime_ReturnsFalse_WhenNumberIsNotPrime()
    {
        int c = 4;
        bool result = _calculatorOther.IsPrime(c);
        Assert.AreEqual(false, result);  // 4 is not prime, so expected result is false
    }

    [Test]
    public void IsPrime_ReturnsFalse_WhenNumberIsPrime()
    {
        int c = 11;
        bool result = _calculatorOther.IsPrime(c);
        Assert.AreEqual(true, result);  // 11 is prime, so expected result is true
    }

    [Test]
    [Ignore("This test is skipped for now.")]
    public void IsPrime_ReturnsFailedTest_WhenNumberIsPrime()
    {
        int c = 11;
        bool result = _calculatorOther.IsPrime(c);
        Assert.AreEqual(false, result);  // 11 is prime, so expected result is true but we have false
    }

    [Test]
    public void BubbleSort_SortsArrayCorrectly()
    {
        // Arrange: input unsorted array
        int[] inputArray = { 64, 25, 12, 22, 11 };
        // Act: sort the array
        _calculatorOther.BubbleSort(inputArray);
        // Assert: check if array is sorted
        int[] expectedArray = { 11, 12, 22, 25, 64 };
        Assert.AreEqual(expectedArray, inputArray);
    }

    // Test case: Test an already sorted array
    [Test]
    public void BubbleSort_SortedArray_DoesNotChange()
    {
        // Arrange: already sorted array
        int[] inputArray = { 11, 12, 22, 25, 64 };
        // Act: sort the array (it should remain the same)
        _calculatorOther.BubbleSort(inputArray);
        // Assert: verify the array is still sorted
        int[] expectedArray = { 11, 12, 22, 25, 64 };
        Assert.AreEqual(expectedArray, inputArray);
    }

    // Test case: Test empty array
    [Test]
    public void BubbleSort_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange: empty array
        int[] inputArray = { };

        // Act: sort the array
        _calculatorOther.BubbleSort(inputArray);

        // Assert: the result should still be an empty array
        int[] expectedArray = { };
        Assert.AreEqual(expectedArray, inputArray);
    }

        // Test case: Test single-element array
    [Test]
    public void BubbleSort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange: array with a single element
        int[] inputArray = { 42 };

        // Act: sort the array
        _calculatorOther.BubbleSort(inputArray);

        // Assert: the result should be the same array
        int[] expectedArray = { 42 };
        Assert.AreEqual(expectedArray, inputArray);
    }

    // Test case: Test array with duplicate elements
    [Test]
    public void BubbleSort_ArrayWithDuplicates_SortsCorrectly()
    {
        // Arrange: array with duplicate values
        int[] inputArray = { 64, 25, 25, 22, 11, 22, 11 };

        // Act: sort the array
        _calculatorOther.BubbleSort(inputArray);

        // Assert: check if the array is sorted
        int[] expectedArray = { 11, 11, 22, 22, 25, 25, 64 };
        Assert.AreEqual(expectedArray, inputArray);
    }

    [Test]
    public void QuickSort_SortsArrayCorrectly()
    {
        // Arrange: input unsorted array
        int[] inputArray = { 64, 25, 12, 22, 11 };
        // Act: sort the array
        _calculatorOther.QuickSort(inputArray, 0, inputArray.Length - 1);
        // Assert: check if array is sorted
        int[] expectedArray = { 11, 12, 22, 25, 64 };
        Assert.AreEqual(expectedArray, inputArray);
    }

}
