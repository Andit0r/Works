ShapeFactory shapeFactory = new();

IShape? shape1 = shapeFactory.GetShape("CIRCLE");
shape1?.Draw();

IShape? shape2 = shapeFactory.GetShape("SQUARE");
shape2?.Draw();

IShape? shape3 = shapeFactory.GetShape("RECTANGLE");
shape3?.Draw();

IShape? shape4 = shapeFactory.GetShape("TRIANGLE");
shape4?.Draw();
