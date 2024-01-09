VendingMachine machine = new VendingMachine();

machine.insertMoney(new Money());
machine.insertMoney(new Money());
machine.insertMoney(new Money());

Console.WriteLine(machine.totalMoney());

machine.refund();
