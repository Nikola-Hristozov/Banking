CREATE TABLE [dbo].[bankers] (
    [id]       INT          IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (50) NOT NULL,
    [password] VARCHAR (50) NOT NULL,
    [name]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([username] ASC)
);
CREATE TABLE [dbo].[Creditors] (
    [Id]        INT        IDENTITY (1, 1) NOT NULL,
    [IBAN]      VARCHAR(50) NOT NULL,
    [name]      VARCHAR(50) NOT NULL,
    [lend]      FLOAT (53) NOT NULL,
    [endDate]   DATE       NOT NULL,
    [interest]  FLOAT (53) NOT NULL,
    [guarantee] FLOAT (53) NOT NULL,
    [banker_id] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([IBAN] ASC),
    CONSTRAINT [FK_Creditors_Bankers] FOREIGN KEY ([banker_id]) REFERENCES [dbo].[bankers] ([id])
);

CREATE TABLE [dbo].[Debtors] (
    [Id]          INT        IDENTITY (1, 1) NOT NULL,
    [IBAN]        VARCHAR(50) NOT NULL,
    [name]        VARCHAR(50) NOT NULL,
    [debt]        FLOAT (53) NOT NULL,
    [endDate]     DATE       NOT NULL,
    [interest]    FLOAT (53) NOT NULL,
    [installment] FLOAT (53) NOT NULL,
    [banker_id]   INT        DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([IBAN] ASC),
    CONSTRAINT [FK_Debtors_Bankers] FOREIGN KEY ([banker_id]) REFERENCES [dbo].[bankers] ([id])
);


