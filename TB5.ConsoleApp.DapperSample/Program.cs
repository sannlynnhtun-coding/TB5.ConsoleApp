// See https://aka.ms/new-console-template for more information
using TB5.ConsoleApp.DapperSample.DapperSample;

Console.WriteLine("Hello, World!");

//DapperService service = new DapperService();
////service.Read();
////service.Create();
//service.Edit();

//SaleDapperService saleService = new SaleDapperService();
//saleService.Read();
//saleService.Update();
//saleService.Delete();
//saleService.Create();

ProductCategoryDapperService categoryService = new ProductCategoryDapperService();
categoryService.Create();
categoryService.Read();
categoryService.Update();
categoryService.Edit();
categoryService.Delete();

Console.ReadLine();
