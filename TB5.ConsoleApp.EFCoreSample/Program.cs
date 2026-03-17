// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using TB5.ConsoleApp.EFCoreSample.EFCoreSample;

Console.WriteLine("Hello, World!");

EFCoreService service = new EFCoreService();
service.Create();
service.Read();
service.Update();
service.Edit();
service.Delete();


Console.ReadLine();

//AppDbContext db = new AppDbContext();
//List<TblProduct> lst = db.TblProducts.ToList();

//foreach (TblProduct item in lst)
//{
//    Console.WriteLine(item.Id);
//    Console.WriteLine(item.Name);
//    Console.WriteLine(item.Price);
//}

//TblProduct product = new TblProduct()
//{
//    Name = "test",
//    Price = 10000
//};
//db.TblProducts.Add(product);
//int result = db.SaveChanges();
//string message = result > 0 ? "Product created successfully." : "Failed to create product.";
//Console.WriteLine(message);

//TblProduct? itemProduct = db.TblProducts.Where(x => x.Id == 1).FirstOrDefault();
//if (itemProduct is null)
//{
//    Console.WriteLine("Product not found.");
//    return;
//}

//itemProduct.Price = 2000;
//db.SaveChanges(); // update


//db.TblProducts.Remove(itemProduct);
//db.SaveChanges();
