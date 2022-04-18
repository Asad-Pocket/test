


using Task_2;

string connectionString = "DESKTOP-BV8KLBG\\SQLEXPRESS; Database = Exam_2; User Id = asad1; Password = asad;";
task pro = new task(connectionString);

var sql = "insert into products([Title],price,IsAvaiable,CreatedOn,AvailableQuantity) values ('err',2.23,0,'2002-21-1',1)";
pro.ExecuteCommand(sql);

var query = "select * from products";
var values = pro.ExecuteQuery(query);

foreach (var item in values)
{
    foreach (var key in item.Keys)
        Console.WriteLine($"{key} = {item[key]}");
}