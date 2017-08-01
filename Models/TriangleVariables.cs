using System;
namespace Triangle.Models
{
  public class TriangleVariables
  {
    private int _side1;
    private int _side2;
    private int _side3;

    public int GetSide1()
    {
      return _side1;
    }

    public void SetSide1(int side1)
    {
      _side1 = side1;
    }

    public int GetSide2()
    {
      return _side2;
    }

    public void SetSide2(int side2)
    {
      _side2 = side2;
    }

    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int side3)
    {
      _side3 = side3;
    }

    public string CheckTriangle()
    {
      string response = "";
      if ((_side1 > _side2 + _side3) || (_side2 > _side1 + _side3) || (_side3 > _side2 + _side1))
      {
        response = "This is not a triangle.";
      } else if (_side1 == _side2 && _side2 == _side3)
      {
        response = "This is an equilateral triangle.";
      } else if ((_side1 == _side2 && _side2 != _side3) || (_side1 == _side3 && _side3 != _side2))
      {
        response = "This is an isosceles triangle.";
      } else if (_side1 != _side2 && _side1 != _side3 && _side2 != _side3)
      {
        response = "This is a scalene triangle.";
      }
      return response;
    }
  }
}
