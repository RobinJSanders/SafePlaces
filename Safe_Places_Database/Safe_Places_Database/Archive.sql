CREATE TABLE [dbo].[Archive] (
    [Archive_ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Employee_name]       NVARCHAR (50) NULL,
 	[Situation] NVARCHAR(50) NOT NULL, 
    [If_other] VARCHAR(50)      NULL,
    [Resolved] NVARCHAR(50) NOT NULL, 
    [Critical] VARCHAR(50) NOT NULL, 
    [Details] VARCHAR(50) NULL, 
    [Archive_Date] DATETIME2 NOT NULL, 
    [Buisness_Name] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Archive_ID] ASC)
)