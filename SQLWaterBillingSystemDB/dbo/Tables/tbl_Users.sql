CREATE TABLE [dbo].[tbl_Users] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [First_Name] VARCHAR (50)  NULL,
    [Last_Name]  VARCHAR (50)  NULL,
    [Email]      VARCHAR (250) NULL,
    [Username]   VARCHAR (50)  NULL,
    [Password]   VARCHAR (50)  NULL,
    [Contact]    VARCHAR (15)  NULL,
    [Address]    VARCHAR (250) NULL,
    [Gender]     VARCHAR (20)  NULL,
    [Added_Date] DATETIME      NULL
);

