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

