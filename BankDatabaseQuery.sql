CREATE DATABASE [bank];
CREATE TABLE [dbo].[bankers] (
    [id]       INT          IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (50) NULL,
    [password] VARCHAR (50) NULL,
    [name]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([username] ASC)
);
CREATE TABLE [dbo].[Debtors] (
    [Id]          INT        IDENTITY (1, 1) NOT NULL,
    [IBAN]        NCHAR (20) NOT NULL,
    [name]        NCHAR (20) NOT NULL,
    [debt]        FLOAT (53) NOT NULL,
    [endDate]     DATE       NULL,
    [interest]    FLOAT (53) NOT NULL,
    [balance]     FLOAT (53) NOT NULL,
    [installment] FLOAT (53) NOT NULL,
    [banker_id]   INT        DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([name] ASC),
    UNIQUE NONCLUSTERED ([IBAN] ASC),
    CONSTRAINT [FK_Debtors_Bankers] FOREIGN KEY ([banker_id]) REFERENCES [dbo].[bankers] ([id])
);
CREATE TABLE [dbo].[Creditors] (
    [Id]        INT        IDENTITY (1, 1) NOT NULL,
    [IBAN]      NCHAR (10) NOT NULL,
    [name]      NCHAR (10) NOT NULL,
    [lend]      FLOAT (53) NOT NULL,
    [endDate]   DATE       NULL,
    [interest]  FLOAT (53) NOT NULL,
    [balance]   FLOAT (53) NOT NULL,
    [guarantee] FLOAT (53) NOT NULL,
    [banker_id] INT        DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([IBAN] ASC),
    UNIQUE NONCLUSTERED ([name] ASC),
    CONSTRAINT [FK_Creditors_Bankers] FOREIGN KEY ([banker_id]) REFERENCES [dbo].[bankers] ([id])
);


