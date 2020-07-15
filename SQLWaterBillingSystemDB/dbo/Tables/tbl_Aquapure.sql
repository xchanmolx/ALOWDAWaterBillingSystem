﻿CREATE TABLE [dbo].[tbl_Aquapure] (
    [ID]                 INT           IDENTITY (1, 1) NOT NULL,
    [CustomerID]         VARCHAR (30)  NULL,
    [Name]               VARCHAR (50)  NULL,
    [Meter_No]           VARCHAR (50)  NULL,
    [Current_]           INT           NULL,
    [Previous]           INT           NULL,
    [Consume]            INT           NULL,
    [CurrentBill]        FLOAT (53)    NULL,
    [VAT]                FLOAT (53)    NULL,
    [TotalAmount]        FLOAT (53)    NULL,
    [MinCBM]             INT           NULL,
    [RateMinCBM]         FLOAT (53)    NULL,
    [AmountMinCBM]       FLOAT (53)    NULL,
    [ExcessCBM]          INT           NULL,
    [RateExcessCBM]      FLOAT (53)    NULL,
    [AmountExcessCBM]    FLOAT (53)    NULL,
    [PreviousBalance]    FLOAT (53)    NULL,
    [ForTheMonthOf]      VARCHAR (150) NULL,
    [Total]              FLOAT (53)    NULL,
    [PrevBalPilipinas]   FLOAT (53)    NULL,
    [TotalDue]           FLOAT (53)    NULL,
    [Balance]            FLOAT (53)    NULL,
    [AmountPaid]         FLOAT (53)    NULL,
    [DatePaid]           VARCHAR (50)  NULL,
    [CreditBalance]      FLOAT (53)    NULL,
    [Status]             VARCHAR (50)  NULL,
    [Added_Date]         DATETIME      NULL,
    [OtherInformation]   VARCHAR (250) NULL,
    [PriorityLessAmount] FLOAT (53)    NULL
);
