CREATE TABLE [dbo].[Users] (
    [UserId]      INT           IDENTITY (1, 1) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL UNIQUE,
    [Name]        NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NOT NULL,
    [PhoneNumber] NVARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

CREATE TABLE [dbo].[Contacts] (
    [ContactId]   INT            IDENTITY (1, 1) NOT NULL,
    [UserId]      INT            NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Email]       NVARCHAR (50)  NULL,
    [PhoneNumber] NVARCHAR (15)  NOT NULL,
    [Description] NVARCHAR (50)  NULL,
    [PhotoPath]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ContactId] ASC),
    UNIQUE NONCLUSTERED ([PhoneNumber] ASC),
    CONSTRAINT [FK_Contacts_ToUsers] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]) On Delete cascade
);



CREATE TABLE [dbo].[Groups] (
    [GroupId]     INT            NOT NULL,
    [UserId]      INT            NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([GroupId] ASC),
    CONSTRAINT [FK_Groups_ToUsers] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

CREATE TABLE [dbo].[Groups] (
    [GroupId]     INT            IDENTITY (1, 1) NOT NULL,
    [UserId]      INT            NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([GroupId] ASC),
    CONSTRAINT [FK_Groups_ToUsers] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]) ON DELETE CASCADE
);



