IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE TABLE [Categories] (
        [Id] varchar(36) NOT NULL,
        [Name] varchar(50) NOT NULL,
        [Image] varchar(550) NOT NULL,
        [Description] nvarchar(255) NULL,
        [CreatedAt] datetime NOT NULL,
        [IsDeleted] bit NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE TABLE [Orders] (
        [Id] varchar(36) NOT NULL,
        [TotalPrice] decimal(8,2) NOT NULL,
        [OrderDate] varchar(20) NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE TABLE [Users] (
        [Id] varchar(36) NOT NULL,
        [UserName] varchar(50) NOT NULL,
        [Image] nvarchar(550) NOT NULL,
        [Role] int NOT NULL,
        [Contact] varchar(15) NOT NULL,
        [Password] varchar(50) NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE TABLE [Products] (
        [Id] varchar(36) NOT NULL,
        [Code] varchar(20) NOT NULL,
        [Name] varchar(50) NOT NULL,
        [Price] decimal(8,2) NOT NULL,
        [Qty] int NULL,
        [Image] nvarchar(550) NOT NULL,
        [Cost] decimal(8,2) NOT NULL,
        [CategoryId] varchar(36) NOT NULL,
        [Description] varchar(100) NULL,
        [CreatedAt] datetime NOT NULL,
        [IsDeleted] bit NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE TABLE [OrderDetails] (
        [Id] varchar(36) NOT NULL,
        [ProductId] varchar(36) NOT NULL,
        [OrderId] varchar(36) NOT NULL,
        [Qty] int NOT NULL,
        [Price] decimal(8,2) NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([Id]),
        CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE TABLE [PriceHistories] (
        [Id] varchar(36) NOT NULL,
        [ProductId] varchar(36) NOT NULL,
        [OldPrice] decimal(8,2) NOT NULL,
        [CurrentPrice] decimal(8,2) NOT NULL,
        [UpdateDate] datetime NOT NULL,
        CONSTRAINT [PK_PriceHistories] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_PriceHistories_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE TABLE [Stockings] (
        [Id] varchar(36) NOT NULL,
        [ProductId] varchar(36) NOT NULL,
        [Status] int NOT NULL,
        [Qty] int NOT NULL,
        [TransactionDate] datetime NOT NULL,
        CONSTRAINT [PK_Stockings] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Stockings_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE UNIQUE INDEX [IX_Categories_Name] ON [Categories] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE INDEX [IX_OrderDetails_OrderId] ON [OrderDetails] ([OrderId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE INDEX [IX_OrderDetails_ProductId] ON [OrderDetails] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE INDEX [IX_PriceHistories_ProductId] ON [PriceHistories] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE UNIQUE INDEX [IX_Products_Code] ON [Products] ([Code]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE INDEX [IX_Stockings_ProductId] ON [Stockings] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    CREATE UNIQUE INDEX [IX_Users_UserName] ON [Users] ([UserName]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105127_Migration-1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231202105127_Migration-1', N'7.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105510_Migration-2')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'Image', N'Description', N'CreatedAt', N'IsDeleted') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    EXEC(N'INSERT INTO [Categories] ([Id], [Name], [Image], [Description], [CreatedAt], [IsDeleted])
    VALUES (''d350f0c2-33a4-4f63-bf61-7582b88bb9d1'', ''Sneaker'', ''https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNDOsp3KV0Q98keEmRNJ-DKkYpJ64LgK8bng&usqp=CAU'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''fae1c6b8-2547-4651-bf1c-789f8d437e01'', ''BEER'', ''https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBVm97ffff3JtR09e4xkkjys5SXrlPv3coTQ&usqp=CAU'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''8a83a4a0-5f18-4ed0-8b4a-4f56b23f7a53'', ''Coffee'', ''https://images.squarespace-cdn.com/content/v1/541e22dde4b0fcd826d4d5a1/1526672830446-8MWSDEWIS8GDRNC2Y3RE/HolyKombucha_Hero_3_WEB.jpg'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''c0a76be4-8f1a-40f2-9d15-2c1a0745c16e'', ''Drink'', ''https://www.coca-colastore.com/media/wysiwyg/COKE-684_new-bottle-blocks-feature_step-3_customized_pattern-trio_v2.png'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''63c9840b-e57d-4852-9c90-6a8f4e71f74f'', ''Shampoo'', ''https://static.spacecrafted.com/dbe4e3ceec5049d281a85658fae6e3e7/i/bd417b71101b4618b3288e5a715fd9f3/1/4SoifmQp45JMgBnHp7ed2/Loreal%20Pro%20Blondie%20Serie%20Expert%201.png'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'Image', N'Description', N'CreatedAt', N'IsDeleted') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105510_Migration-2')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'Name', N'Price', N'Qty', N'Image', N'Cost', N'CategoryId', N'Description', N'CreatedAt', N'IsDeleted') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    EXEC(N'INSERT INTO [Products] ([Id], [Code], [Name], [Price], [Qty], [Image], [Cost], [CategoryId], [Description], [CreatedAt], [IsDeleted])
    VALUES (''424b8067-718d-4008-b75f-dbbeaef4d49e'', ''SMTH001'', ''Smoth Shampoo'', 9.99, 34, N''https://www.thebeautybasket.ie/cdn/shop/products/smoothshampoofront_800x800_crop_center@2x.jpg?v=1631621734'', 5.99, ''63c9840b-e57d-4852-9c90-6a8f4e71f74f'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''195fb8b1-7923-4dd8-8ef9-e1e375981196'', ''CC001'', ''Coca Cola'', 1.99, 20, N''https://www.luckystore.in/cdn/shop/products/CocaColaOriginal250ML_imported.png?v=1670837210'', 0.99, ''c0a76be4-8f1a-40f2-9d15-2c1a0745c16e'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''ef4a76ac-0c3e-4265-956b-7cd595ad4cd1'', ''NES001'', ''NesCafe Pack 190g'', 7.49, 0, N''https://m.media-amazon.com/images/I/81h3AcrJ6pL.jpg'', 4.99, ''8a83a4a0-5f18-4ed0-8b4a-4f56b23f7a53'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''0c2e9b78-7be8-4782-b866-a57fefd84bdd'', ''NES002'', ''NesCafe Gold 7 sachets'', 5.99, 10, N''https://fengany.com/cdn/shop/products/NescafeGoldIcedSaltedCaramelLatte-7sachets.jpg?v=1627739262&width=1080'', 3.99, ''8a83a4a0-5f18-4ed0-8b4a-4f56b23f7a53'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''75a25866-499f-480a-b967-e6bd95dfbd7d'', ''HAN001'', ''Hanuman Berr Bottle'', 3.99, 0, N''https://cdn.s-liquor.com.kh/wp-content/uploads/2022/07/Hanuman-Lager.jpg?strip=all&lossy=1&webp=90&avif=50&resize=300%2C300&ssl=1'', 2.99, ''fae1c6b8-2547-4651-bf1c-789f8d437e01'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''1ed7d30b-411c-4180-9e57-d572a791c7f4'', ''HAN002'', ''Hanuman Beer Black'', 4.99, 0, N''https://cdn.s-liquor.com.kh/wp-content/uploads/2022/02/Hanuman-Black-01.jpg'', 3.49, ''fae1c6b8-2547-4651-bf1c-789f8d437e01'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''07af13cf-8c15-46cd-b38b-82f40dd13103'', ''GF001'', ''Schar Gluten Free Crackers 210g'', 3.99, 50, N''https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT885cxlgzOFHZzztvIO0uxPh368p29bgmzNw&usqp=CAU'', 2.49, ''d350f0c2-33a4-4f63-bf61-7582b88bb9d1'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit)),
    (''6ea58f12-3f72-4c3a-9579-173f2a365ff7'', ''MC001'', ''Munchy''''s Crackers'', 2.49, 22, N''https://media.nedigital.sg/fairprice/fpol/media/images/product/XL/13035079_XL1_20210218.jpg?w=1200&q=70'', 1.49, ''d350f0c2-33a4-4f63-bf61-7582b88bb9d1'', NULL, ''2023-12-04T15:00:48.895'', CAST(0 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'Name', N'Price', N'Qty', N'Image', N'Cost', N'CategoryId', N'Description', N'CreatedAt', N'IsDeleted') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105510_Migration-2')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'UserName', N'Role', N'Image', N'Contact', N'Password') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] ON;
    EXEC(N'INSERT INTO [Users] ([Id], [UserName], [Role], [Image], [Contact], [Password])
    VALUES (''5e25cc94-424f-4b29-8729-cbc55c09e5a3'', ''Admin'', 1, N''https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlvcJSJgrLlqVEQ1XNM3GzT0qGSyBX5jg1nd5Xn7_krVmMVL3gXR5u6TaU1q8xS4FNV6k&usqp=CAU'', ''015558811'', ''Admin@123''),
    (''d675e5a1-c86c-46af-a926-e4e8e49f8690'', ''Sellman'', 2, N''https://www.shutterstock.com/image-vector/avatar-girls-icon-vector-woman-260nw-433429546.jpg'', ''098885558'', ''Sell@123'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'UserName', N'Role', N'Image', N'Contact', N'Password') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105510_Migration-2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231202105510_Migration-2', N'7.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202105843_Migration-3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231202105843_Migration-3', N'7.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231203110323_Migration-4')
BEGIN
    ALTER TABLE [Stockings] ADD [Note] varchar(255) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231203110323_Migration-4')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231203110323_Migration-4', N'7.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231204073259_YourMigrationName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231204073259_YourMigrationName', N'7.0.13');
END;
GO

COMMIT;
GO

