CREATE TABLE [dbo].[PatientResults]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [test_name] NVARCHAR(50) NOT NULL, 
    [result] FLOAT NOT NULL, 
    [min_reference_range] FLOAT NOT NULL, 
    [max_reference_range] FLOAT NOT NULL, 
    [AspNetUsersId] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([AspNetUsersId]) REFERENCES [AspNetUsers]([Id])
)
