

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Controller ve View kullanmak i�in gerekli servisleri �a��r�yoruz.

var app = builder.Build();

app.UseStaticFiles(); // wwwroot klas�r�nde kullan�lacak Static dosyalar i�in bu konfig�rasyon yap�lmas� gerekir. 

app.UseRouting(); // Routing konfig�rasyonu

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Default Routing konfig�rasyonu

app.Run();


// Controller: Kullan�c�dan al�nan Http isteklerini i�leyen ve Model ile View aras�ndaki ba�lant�y� sa�layan yap�d�r.
// Action: Controller i�erisinde yer alan ve kullan�c�dan gelen istekleri i�leyen metottur.
// Model: Verilerin tutuldu�u ve i� mant���n�n olu�turuldu�u yerdir.
// View: Modelden al�nan verilerin kullan�c�ya g�sterildi�i aray�zd�r.
// Razor: ASP.NET Core'da dinamik HTML i�erik olu�turmak i�in kullan�lan bir i�aretleme dilidir. Razor sayesinde C# kodu do�rudan HTML dosyalar� i�erisinde yaz�labilir.
// RazorView: Razor motoru kullanarak olu�turulan ve kullan�c�ya sunulan sayfad�r. Bu sayfalar .cshtml dosyalar�yla olu�turulur ve dinamik olarak C# kodu i�erir.
// wwwroot: ASP.NET Core projelerinde statik dosyalar�n (CSS, JavaScript, resimler gibi) bulundu�u klas�rd�r, tarayac� taraf�ndan do�rudan eri�ilebilir.
// builder.Build() metodu: ASP.NET Core uygulamas�n� yap�land�rmak i�in kullan�l�r. Uygulaman�n servislerinin ve ba��ml�l�klar�n�n konfig�re edilip ba�lat�ld��� bir ad�m olarak d���nebiliriz.
// app.Run() metodu: ASP.NET Core uygulamas�n�n �al��mas�n� ba�lat�r. Genellikle uygulaman�n son middleware (ara yaz�l�m) katman� olarak kullan�l�r ve uygulamay� �al��t�r�r.