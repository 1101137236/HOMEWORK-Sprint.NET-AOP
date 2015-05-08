
CREATE DATABASE [KuasCourse]
GO

USE [KUAS]
GO

CREATE TABLE [dbo].[Course](
	[CourseID]   [nvarchar](20) NOT NULL,
	[CourseName] [nvarchar](200) NOT NULL,
	[CourseDescription] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N'math'  , N'微積分', N'圓錐體G');
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N'csharp'  , N'C夏普', N'MVCCC');
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N'aspnet'  , N'A欸斯批打內特', N'ADOSPRING');
