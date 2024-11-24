namespace Lab12.Models;

public sealed class NumberModel
{
  public int FirstNumber { get; set; }
  public int SecondNumber { get; set; }

  public int? Result { get; set; }

  public Operations Operation { get; set; }

  public int? Calculate()
  {
    switch (Operation)
    {
      case Operations.ADD:
        Result = FirstNumber + SecondNumber;
        break;
      case Operations.SUBTRACT:
        Result = FirstNumber - SecondNumber;
        break;
      case Operations.DIVIDE:
        Result = FirstNumber / SecondNumber;
        break;
      case Operations.MULTIPLY:
        Result = FirstNumber * SecondNumber;
        break;
      default:
        Result = null;
        break;
    }
    return Result;
  }
}