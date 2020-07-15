CREATE TABLE [dbo].[tbl_Bojo] (
    [ID]               INT           IDENTITY (1, 1) NOT NULL,
    [CustomerID]       VARCHAR (30)  NULL,
    [Name]             VARCHAR (50)  NULL,
    [Meter_No]         VARCHAR (50)  NULL,
    [Current_]         INT           NULL,
    [Previous]         INT           NULL,
    [Consume]          DECIMAL (18)  NULL,
    [LessCBM]          INT           NULL,
    [TotalCBM]         DECIMAL (18)  NULL,
    [AmountPerCBM]     DECIMAL (18)  NULL,
    [Bill]             DECIMAL (18)  NULL,
    [PreviousBalance]  VARCHAR (50)  NULL,
    [AmountPaid]       VARCHAR (50)  NULL,
    [DatePaid]         VARCHAR (50)  NULL,
    [OR_No]            VARCHAR (50)  NULL,
    [Balance]          VARCHAR (50)  NULL,
    [Status]           VARCHAR (50)  NULL,
    [Added_Date]       DATETIME      NULL,
    [OtherInformation] VARCHAR (250) NULL
);

