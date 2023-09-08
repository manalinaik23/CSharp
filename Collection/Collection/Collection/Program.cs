// See https://aka.ms/new-console-template for more information



Customer c1 = new Customer() { Id = 1, Name = "Manali", Address = "Borivali" };
Customer c2 = new Customer() { Id = 2, Name = "Sumit", Address = "Banglore" };
Customer c3 = new Customer() { Id = 1, Name = "Utkarsha", Address = "Vasai" };

//Array has fixed size and hence cannot grow dynamically.
//Collection grow dynamically even if we gave size.
List<Customer> list = new List<Customer>(2);
list.Add(c1);
list.Add(c2);
list.Insert(0, c3);

/*if (list.Exists(cust=>cust.Name.StartsWith('R')))
{
    Console.WriteLine("Object is present");
}
else
{
    Console.WriteLine("Object is not present");
}*/

/*List<Customer> customers = list.FindAll(cust => cust.Address.StartsWith('B'));
foreach(Customer cust in customers)
{
    Console.WriteLine("Id :{0} Name:{1} Address:{2}", cust.Id, cust.Name, cust.Address);
}*/

Console.WriteLine( list.FindLastIndex(cust => cust.Id == 1));
Customer[] cust = list.ToArray();
foreach(Customer c in cust)
{
    Console.WriteLine("Id :{0} Name:{1} Address:{2}", c.Id, c.Name, c.Address);
}


class Customer
{
    public int Id{ get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}