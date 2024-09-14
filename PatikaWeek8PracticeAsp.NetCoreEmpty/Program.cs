

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Controller ve View kullanmak için gerekli servisleri çaðýrýyoruz.

var app = builder.Build();

app.UseStaticFiles(); // wwwroot klasöründe kullanýlacak Static dosyalar için bu konfigürasyon yapýlmasý gerekir. 

app.UseRouting(); // Routing konfigürasyonu

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Default Routing konfigürasyonu

app.Run();


// Controller: Kullanýcýdan alýnan Http isteklerini iþleyen ve Model ile View arasýndaki baðlantýyý saðlayan yapýdýr.
// Action: Controller içerisinde yer alan ve kullanýcýdan gelen istekleri iþleyen metottur.
// Model: Verilerin tutulduðu ve iþ mantýðýnýn oluþturulduðu yerdir.
// View: Modelden alýnan verilerin kullanýcýya gösterildiði arayüzdür.
// Razor: ASP.NET Core'da dinamik HTML içerik oluþturmak için kullanýlan bir iþaretleme dilidir. Razor sayesinde C# kodu doðrudan HTML dosyalarý içerisinde yazýlabilir.
// RazorView: Razor motoru kullanarak oluþturulan ve kullanýcýya sunulan sayfadýr. Bu sayfalar .cshtml dosyalarýyla oluþturulur ve dinamik olarak C# kodu içerir.
// wwwroot: ASP.NET Core projelerinde statik dosyalarýn (CSS, JavaScript, resimler gibi) bulunduðu klasördür, tarayacý tarafýndan doðrudan eriþilebilir.
// builder.Build() metodu: ASP.NET Core uygulamasýný yapýlandýrmak için kullanýlýr. Uygulamanýn servislerinin ve baðýmlýlýklarýnýn konfigüre edilip baþlatýldýðý bir adým olarak düþünebiliriz.
// app.Run() metodu: ASP.NET Core uygulamasýnýn çalýþmasýný baþlatýr. Genellikle uygulamanýn son middleware (ara yazýlým) katmaný olarak kullanýlýr ve uygulamayý çalýþtýrýr.