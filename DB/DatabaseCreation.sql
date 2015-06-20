CREATE TABLE [dbo].Courses
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Name] VARCHAR(50) NOT NULL, 
    [AvailableSlots] INT NULL, 
    [CourseDate] DATETIME NULL, 
    [Price] FLOAT NULL
)
