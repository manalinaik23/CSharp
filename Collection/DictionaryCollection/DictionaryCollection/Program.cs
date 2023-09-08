using DictionaryCollection;

Customer c1 = new Customer()
{
    Id = 100,
    Name = "Mark",
    Salary = 65000
};
Customer c2 = new Customer()
{
    Id = 110,
    Name = "Peter",
    Salary = 50000
};
Customer c3 = new Customer()
{
    Id = 200,
    Name = "Ben",
    Salary = 80000
};

//Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
//dictionaryCustomers.Add(c1.Id, c1);
//dictionaryCustomers.Add(c2.Id, c2);
//dictionaryCustomers.Add(c3.Id, c3);

//if (!dictionaryCustomers.ContainsKey(c1.Id))
//{
//    dictionaryCustomers.Add(c1.Id,c1);
//}

//foreach(Customer cust in dictionaryCustomers.Values)
//{
// Console.WriteLine("Id:{0} Name:{1} Salary:{2}", cust.Id, cust.Name, cust.Salary);
//}

//foreach(int key in dictionaryCustomers.Keys)
//{
//    Console.WriteLine("Key" + key);
//}

//foreach(KeyValuePair<int,Customer> cs in dictionaryCustomers)
//{
//    Console.WriteLine("Key"+cs.Key);
//    Customer cust = cs.Value;
//    Console.WriteLine("Id:{0} Name:{1} Salary:{2}", cust.Id, cust.Name, cust.Salary);
//    Console.WriteLine("------------------------------------------------------------");
//}

//Customer cust = dictionaryCustomers[c1.Id];
//Console.WriteLine("Id:{0} Name:{1} Salary:{2}",cust.Id,cust.Name,cust.Salary);


/*Method*/
//if(dictionaryCustomers.TryGetValue(500,out Customer cust)){
//    Console.WriteLine("Id:{0} Name:{1} Salary:{2}", cust.Id, cust.Name, cust.Salary);
//}
//else
//{
//    Console.WriteLine("key is not present");
//}

//Console.WriteLine("Count of Dictionary"+dictionaryCustomers.Count(kvp=>kvp.Value.Salary >= 65000));

//dictionaryCustomers.Remove(c1.Id); // removes the specified item
//dictionaryCustomers.Clear();//clears all items from the dictionary.

Customer[] cs = new Customer[3];
cs[0] = c1;
cs[1] = c2;
cs[2] = c3;

Dictionary<int, Customer> keyValue = cs.ToDictionary(c => c.Id, c => c);
foreach(KeyValuePair<int,Customer> kvp in keyValue)
{
    Customer cust = kvp.Value;
    Console.WriteLine("Id:{0} Name:{1} Salary:{2}", cust.Id, cust.Name, cust.Salary);
}