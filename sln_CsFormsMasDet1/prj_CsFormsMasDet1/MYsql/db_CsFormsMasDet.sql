USE CsFormsMasDet;
GO

CREATE TABLE dbo.Categories
( 
  CatId      INT                NOT NULL IDENTITY, 
  CatName    NVARCHAR(30)           NULL, 

  CONSTRAINT PK_dbo_Categories  PRIMARY KEY (CatId ASC) 
); 
GO

CREATE TABLE dbo.Products
( 
  ProdId     INT                NOT NULL IDENTITY, 
  ProdName   NVARCHAR(30)           NULL, 
  CatId      INT                NOT NULL, 

  CONSTRAINT PK_dbo_Products    PRIMARY KEY (ProdId ASC) 
); 
GO

CREATE INDEX IX_dbo_Products_CatId ON dbo.Products(CatId);
GO

ALTER TABLE dbo.Products
  ADD CONSTRAINT FK_dbo_Products_CatId_dbo_Categories_CatId
    FOREIGN KEY (CatId) REFERENCES dbo.Categories (CatId)
    ON DELETE CASCADE;
GO

USE CsFormsMasDet;
GO

SET IDENTITY_INSERT dbo.Categories ON;    --allow manual insertions of identity values
GO

INSERT INTO dbo.Categories
  ( CatId, CatName )
VALUES
  (  1, N'Fruits'     ),
  (  2, N'Vegetables' ),
  (  3, N'Meats'      ),
  (  4, N'Seafood'    ),
  (  5, N'Snacks'     ),
  (  6, N'Drinks'     ),
  (  7, N'Bakery'     ),
  (  8, N'Takeout'    ),
  (  9, N'Vitamins'   ),
  ( 10, N'Stationery' ),
  ( 11, N'Plants'     );
GO

SET IDENTITY_INSERT dbo.Categories OFF;   --prevent manual insertions of identity values
GO

INSERT INTO dbo.Products
  ( ProdName, CatId )
VALUES
  ( N'Apples',    1 ),
  ( N'Oranges',   1 ),
  ( N'Bananas',   1 ),
  ( N'Spinach',   2 ),
  ( N'Lettuce',   2 ),
  ( N'Tomato',    2 ),
  ( N'Beef',      3 ),
  ( N'Chicken',   3 ),
  ( N'Turkey',    3 ),
  ( N'Tuna',      4 ),
  ( N'Salmon',    4 ),
  ( N'Shrimp',    4 ),
  ( N'Chips',     5 ),
  ( N'Pretzels',  5 ),
  ( N'Nuts',      5 ),
  ( N'Water',     6 ),
  ( N'Iced Tea',  6 ),
  ( N'Juice',     6 ),
  ( N'Cake',      7 ),
  ( N'Pie',       7 ),
  ( N'Muffin',    7 ),
  ( N'Casserole', 8 ),
  ( N'TV Dinner', 8 ),
  ( N'Chinese',   8 ),
  ( N'Mega C',    9 ),
  ( N'Super B12', 9 ),
  ( N'Potent D',  9 ),
  ( N'Paper',    10 ),
  ( N'Pens',     10 ),
  ( N'Ruler',    10 ),
  ( N'Rose',     11 ),
  ( N'Lilac',    11 ),
  ( N'Gardenia', 11 );
GO