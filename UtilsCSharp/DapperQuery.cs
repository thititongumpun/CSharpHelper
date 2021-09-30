// using System.Collections.Generic;
// using System.Data;
// // using DapperQueryBuilder;
// namespace UtilsCSharp
// {
//     public class DapperQuery
//     {
//         public static IEnumerable<int> DapperQ()
//         {
//             using (IDbConnection conn = new SqlConnection("Server=localhost;Database=CustomerOrderViewer;Trusted_Connection=True;"))
//             {
//                 conn.Open();
//                 try
//                 {
//                     var query = conn.QueryBuilder($@"SELECT * FROM Customer c 
//                                                   LEFT JOIN CustomerOrder co
//                                                   ON co.CustomerId = C.CustomerId
//                                                   LEFT JOIN Item i
//                                                     ON i.ItemId = co.itemId
//                                                     /**where**/");
//                     //query.Where($"CustomerId = {customerId}");
//                     query.Where($"co.CustomerId > 1");
//                     query.Where($"c.Age = 55");
//                     var res = query.Query<Customer>();
//                     return res;
//                 }
//                 catch
//                 {
//                     throw;
//                 }
//             }
//         }

//         private class Customer
//         {
//             public int Id {get;set;}
//         }
//     }
// }