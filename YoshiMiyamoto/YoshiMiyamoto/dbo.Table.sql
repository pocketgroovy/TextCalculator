CREATE TABLE [dbo].[Calculation]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Numbers] CHAR(10) NOT NULL, 
    [Operations] CHAR(10) NOT NULL, 
    [Result] FLOAT NOT NULL, 
    [Timestamp] TIMESTAMP NOT NULL
)
