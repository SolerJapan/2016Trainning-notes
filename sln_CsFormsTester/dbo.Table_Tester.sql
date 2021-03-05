CREATE TABLE [dbo].[Tester] (
    [QuestionId] INT            IDENTITY (1, 1) NOT NULL,
    [Question]   NVARCHAR (200) NOT NULL,
    [Answer1]    NVARCHAR (200) NOT NULL,
    [Answer2]    NVARCHAR (200) NOT NULL,
    [Answer3]    NVARCHAR (200) NOT NULL,
    [Answer4]    NVARCHAR (200) NOT NULL,
    [Choice]     INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([QuestionId] ASC)
);

