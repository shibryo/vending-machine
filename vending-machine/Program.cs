Casher cashser = new Casher();

cashser.insert(new Cash(50));
cashser.insert(new Cash(100));
cashser.insert(new Cash(500));

Console.WriteLine(cashser.total());

cashser.refund();

Console.WriteLine(cashser.total());
