using HelloWorld;


Rectangle rect1 = new Rectangle(5, 10);

Console.WriteLine(rect1.Width);
Console.WriteLine(rect1.GetArea());

rect1.Width = 60;
rect1.Height = 50;

Console.WriteLine(rect1.GetArea());