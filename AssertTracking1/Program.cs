// See https://aka.ms/new-console-template for more information
using AssertTracking1;

Asset Asset1 = new Asset();

Asset1.Type = "Computer";
Asset1.Brand = "Dell";
Asset1.Model = "5040";
Asset1.Office = "Sweden";
Asset1.DateofPurchase = 2015;
Asset1.Currency = 23000;

MyDBContext Context = new MyDBContext();

// insert values to the table
Context.assets.Add(Asset1);
Asset Asset2 = new Asset();
Asset2.Type = "Computer";
Asset2.Brand = "Dell";
Asset2.Model = "5050";
Asset2.Office = "USA";
Asset2.DateofPurchase = 2017;
Asset2.Currency = 26000;
Context.assets.Add(Asset2);

Asset Asset3 = new Asset();
Asset3.Type = "Computer";
Asset3.Brand = "Dell";
Asset3.Model = "5050";
Asset3.Office = "USA";
Asset3.DateofPurchase = 2017;
Asset3.Currency = 26000;
//Context.assets.Add(Asset3);

Asset Asset4 = new Asset();
Asset4.Type = "Computer";
Asset4.Brand = "Dell";
Asset4.Model = "5050";
Asset4.Office = "USA";
Asset4.DateofPurchase = 2017;
Asset4.Currency = 26000;
//Context.assets.Add(Asset4);


// update values in the table

//var Asset = Context.assets.SingleOrDefault(x => x.Id == 3);

//Asset.Type = "Mobile";
//Asset.Brand = "Apple";
//Asset.Model = "iphone8";
//Asset.Office = "USA";
//Asset.DateofPurchase = 2017;
//Asset.Currency = 20000;

var Asset = Context.assets.SingleOrDefault(x => x.Id == 4);

Asset.Type = "Mobile";
Asset.Brand = "Apple";
Asset.Model = "iphone13 pro";
Asset.Office = "UK";
Asset.DateofPurchase = 2021;
Asset.Currency = 20000;
Context.SaveChanges();

Asset Asset5 = new Asset();
Asset5.Type = "Computer";
Asset5.Brand = "Apple";
Asset5.Model = "Mac Book";
Asset5.Office = "USA";
Asset5.DateofPurchase = 2020;
Asset5.Currency = 30000;

Context.assets.Add(Asset5);

//orderby(x => x.Type)

Context.SaveChanges();

Console.WriteLine("Asset Tracking ");