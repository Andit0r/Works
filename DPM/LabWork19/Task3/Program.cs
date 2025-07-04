﻿IShape circle = new Circle();

IShape redCircle = new RedShapeDecorator(new Circle());

IShape redRectangle = new RedShapeDecorator(new Rectangle());

IShape redCircleWithHat = new HatShapeDecorator(redCircle);

Console.WriteLine("Circle with normal border");
circle.Draw();

Console.WriteLine("\nCircle of red border");
redCircle.Draw();

Console.WriteLine("\nRectangle of red border");
redRectangle.Draw();

Console.WriteLine("\nCircle of red border with hat");
redCircleWithHat.Draw();




