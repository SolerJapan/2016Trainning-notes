USE testerProject;
GO

CREATE TABLE dbo.Tester
( 
  QId        INT                NOT NULL IDENTITY, 
  Question   NVARCHAR(100)      Not NULL,
  askAns1    NVARCHAR(30)           NULL,
  askAns2    NVARCHAR(30)           NULL,
  askAns3    NVARCHAR(30)           NULL,
  askAns4    NVARCHAR(30)           NULL,
  TAns       NVARCHAR(30)       Not NULL, 

  CONSTRAINT PK_dbo_Tester  PRIMARY KEY (QId ASC) 
); 
GO

USE testerProject;
GO

SET IDENTITY_INSERT dbo.Tester ON;    --allow manual insertions of identity values
GO

INSERT INTO dbo.Tester
  ( QId, Question, askAns1,askAns2,askAns3,askAns4,TAns )
VALUES
  (  1, N'What is 1+1','2','3','4','1','2'),
  (  2, N'How would you not describe America','Entertaining','Dangerous','Politically Correct','Peaceful','Peaceful' ),
  (  3, N'How would you Describe Computers', 'Helpful','fun','Useless','Dangerous','Helpful');
GO

SET IDENTITY_INSERT dbo.Tester OFF;   --prevent manual insertions of identity values
GO

---code end---