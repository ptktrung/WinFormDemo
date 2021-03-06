
/****** Object:  Table [dbo].[Employee]    Script Date: 11/27/2021 13:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[FName] [varchar](15) NOT NULL,
	[MInit] [varchar](1) NULL,
	[LName] [varchar](15) NOT NULL,
	[SSN] [char](9) NOT NULL,
	[BDate] [datetime] NULL,
	[Address] [varchar](30) NULL,
	[Sex] [char](1) NULL,
	[Salary] [numeric](10, 2) NULL,
	[SuperSSN] [char](9) NULL,
	[DNo] [numeric](4, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'John', N'B', N'Smith', N'123456789', CAST(0x00004E8000000000 AS DateTime), N'Houston TX', N'M', CAST(30000.00 AS Numeric(10, 2)), N'333445555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'Franklin', N'T', N'Wong', N'333445555', CAST(0x0000418900000000 AS DateTime), N'Houston TX', N'M', CAST(40000.00 AS Numeric(10, 2)), N'888665555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'Joyce', N'A', N'English', N'453453453', CAST(0x0000594800000000 AS DateTime), N'Houston TX', N'F', CAST(25000.00 AS Numeric(10, 2)), N'333445555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'Ramesh', N'K', N'Narayan', N'666884444', CAST(0x00004B3200000000 AS DateTime), N'Humble TX', N'M', CAST(38000.00 AS Numeric(10, 2)), N'333445555', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'James', N'E', N'Borg', N'888665555', CAST(0x000027BE00000000 AS DateTime), N'Houston TX', N'M', CAST(55000.00 AS Numeric(10, 2)), NULL, CAST(1 AS Numeric(4, 0)))
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'Jennifer', N'S', N'Wallace', N'987654321', CAST(0x00002CE400000000 AS DateTime), N'Bellaire TX', N'F', CAST(43000.00 AS Numeric(10, 2)), N'888665555', CAST(4 AS Numeric(4, 0)))
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'Ahmad', N'V', N'Jabbar', N'987987987', CAST(0x0000548400000000 AS DateTime), N'Houston TX', N'M', CAST(25000.00 AS Numeric(10, 2)), N'987654321', CAST(4 AS Numeric(4, 0)))
INSERT [dbo].[Employee] ([FName], [MInit], [LName], [SSN], [BDate], [Address], [Sex], [Salary], [SuperSSN], [DNo]) VALUES (N'Alicia', N'J', N'Zelaya', N'999887777', CAST(0x0000538700000000 AS DateTime), N'Spring TX', N'F', CAST(25000.00 AS Numeric(10, 2)), N'987654321', CAST(4 AS Numeric(4, 0)))
/****** Object:  Table [dbo].[Department]    Script Date: 11/27/2021 13:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[DName] [varchar](15) NOT NULL,
	[DNumber] [numeric](4, 0) NOT NULL,
	[Mgrssn] [char](9) NULL,
	[MgrStartdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[DNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Department] ([DName], [DNumber], [Mgrssn], [MgrStartdate]) VALUES (N'Headquarters', CAST(1 AS Numeric(4, 0)), N'888665555', CAST(0x000065F500000000 AS DateTime))
INSERT [dbo].[Department] ([DName], [DNumber], [Mgrssn], [MgrStartdate]) VALUES (N'Administration', CAST(4 AS Numeric(4, 0)), N'987654321', CAST(0x0000794600000000 AS DateTime))
INSERT [dbo].[Department] ([DName], [DNumber], [Mgrssn], [MgrStartdate]) VALUES (N'Research', CAST(5 AS Numeric(4, 0)), N'333445555', CAST(0x00006FD600000000 AS DateTime))
/****** Object:  Table [dbo].[Project]    Script Date: 11/27/2021 13:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[PName] [varchar](15) NOT NULL,
	[PNumber] [numeric](4, 0) NOT NULL,
	[PLocation] [varchar](15) NULL,
	[DNum] [numeric](4, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Project] ([PName], [PNumber], [PLocation], [DNum]) VALUES (N'ProductX', CAST(1 AS Numeric(4, 0)), N'Bellaire', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Project] ([PName], [PNumber], [PLocation], [DNum]) VALUES (N'ProductY', CAST(2 AS Numeric(4, 0)), N'Sugarland', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Project] ([PName], [PNumber], [PLocation], [DNum]) VALUES (N'ProductZ', CAST(3 AS Numeric(4, 0)), N'Houston', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Project] ([PName], [PNumber], [PLocation], [DNum]) VALUES (N'Computerization', CAST(10 AS Numeric(4, 0)), N'Stafford', CAST(4 AS Numeric(4, 0)))
INSERT [dbo].[Project] ([PName], [PNumber], [PLocation], [DNum]) VALUES (N'Reorganization', CAST(20 AS Numeric(4, 0)), N'Houston', CAST(1 AS Numeric(4, 0)))
INSERT [dbo].[Project] ([PName], [PNumber], [PLocation], [DNum]) VALUES (N'Newbenefits', CAST(30 AS Numeric(4, 0)), N'Stafford', CAST(4 AS Numeric(4, 0)))
/****** Object:  Table [dbo].[Works_on]    Script Date: 11/27/2021 13:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Works_on](
	[ESSN] [char](9) NOT NULL,
	[PNo] [numeric](4, 0) NOT NULL,
	[Hours] [numeric](4, 1) NULL,
PRIMARY KEY CLUSTERED 
(
	[ESSN] ASC,
	[PNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'123456789', CAST(1 AS Numeric(4, 0)), CAST(32.5 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'123456789', CAST(2 AS Numeric(4, 0)), CAST(7.5 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'333445555', CAST(2 AS Numeric(4, 0)), CAST(10.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'333445555', CAST(3 AS Numeric(4, 0)), CAST(10.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'333445555', CAST(10 AS Numeric(4, 0)), CAST(10.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'333445555', CAST(20 AS Numeric(4, 0)), CAST(10.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'453453453', CAST(1 AS Numeric(4, 0)), CAST(20.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'453453453', CAST(2 AS Numeric(4, 0)), CAST(20.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'666884444', CAST(3 AS Numeric(4, 0)), CAST(40.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'888665555', CAST(20 AS Numeric(4, 0)), NULL)
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'987654321', CAST(20 AS Numeric(4, 0)), CAST(15.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'987654321', CAST(30 AS Numeric(4, 0)), CAST(20.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'987987987', CAST(10 AS Numeric(4, 0)), CAST(35.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'987987987', CAST(30 AS Numeric(4, 0)), CAST(5.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'999887777', CAST(10 AS Numeric(4, 0)), CAST(10.0 AS Numeric(4, 1)))
INSERT [dbo].[Works_on] ([ESSN], [PNo], [Hours]) VALUES (N'999887777', CAST(30 AS Numeric(4, 0)), CAST(30.0 AS Numeric(4, 1)))
/****** Object:  Table [dbo].[Dependent]    Script Date: 11/27/2021 13:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dependent](
	[ESSN] [char](9) NOT NULL,
	[Dependent_Name] [varchar](15) NOT NULL,
	[Sex] [char](1) NULL,
	[BDate] [datetime] NULL,
	[Relationship] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[ESSN] ASC,
	[Dependent_Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Dependent] ([ESSN], [Dependent_Name], [Sex], [BDate], [Relationship]) VALUES (N'123456789', N'Alice', N'F', CAST(0x000070B500000000 AS DateTime), N'Daughter')
INSERT [dbo].[Dependent] ([ESSN], [Dependent_Name], [Sex], [BDate], [Relationship]) VALUES (N'123456789', N'Elizabeth', N'F', CAST(0x000051CF00000000 AS DateTime), N'Spouse')
INSERT [dbo].[Dependent] ([ESSN], [Dependent_Name], [Sex], [BDate], [Relationship]) VALUES (N'123456789', N'Michael', N'M', CAST(0x00006F4900000000 AS DateTime), N'Son')
INSERT [dbo].[Dependent] ([ESSN], [Dependent_Name], [Sex], [BDate], [Relationship]) VALUES (N'333445555', N'Alice', N'F', CAST(0x00006CCD00000000 AS DateTime), N'Daughter')
INSERT [dbo].[Dependent] ([ESSN], [Dependent_Name], [Sex], [BDate], [Relationship]) VALUES (N'333445555', N'Joy', N'F', CAST(0x000044F600000000 AS DateTime), N'Spouse')
INSERT [dbo].[Dependent] ([ESSN], [Dependent_Name], [Sex], [BDate], [Relationship]) VALUES (N'333445555', N'Theodore', N'M', CAST(0x0000695000000000 AS DateTime), N'Son')
INSERT [dbo].[Dependent] ([ESSN], [Dependent_Name], [Sex], [BDate], [Relationship]) VALUES (N'987654321', N'Abner', N'M', CAST(0x00002DCE00000000 AS DateTime), N'Spouse')
/****** Object:  Table [dbo].[Department_Location]    Script Date: 11/27/2021 13:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department_Location](
	[DNumber] [numeric](4, 0) NOT NULL,
	[DLocation] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DNumber] ASC,
	[DLocation] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Department_Location] ([DNumber], [DLocation]) VALUES (CAST(1 AS Numeric(4, 0)), N'Houston')
INSERT [dbo].[Department_Location] ([DNumber], [DLocation]) VALUES (CAST(4 AS Numeric(4, 0)), N'Stafford')
INSERT [dbo].[Department_Location] ([DNumber], [DLocation]) VALUES (CAST(5 AS Numeric(4, 0)), N'Bellaire')
INSERT [dbo].[Department_Location] ([DNumber], [DLocation]) VALUES (CAST(5 AS Numeric(4, 0)), N'Houston')
INSERT [dbo].[Department_Location] ([DNumber], [DLocation]) VALUES (CAST(5 AS Numeric(4, 0)), N'Sugarland')
/****** Object:  ForeignKey [FK__Departmen__Mgrss__145C0A3F]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Department]  WITH CHECK ADD FOREIGN KEY([Mgrssn])
REFERENCES [dbo].[Employee] ([SSN])
GO
/****** Object:  ForeignKey [FK__Departmen__DNumb__15502E78]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Department_Location]  WITH CHECK ADD FOREIGN KEY([DNumber])
REFERENCES [dbo].[Department] ([DNumber])
GO
/****** Object:  ForeignKey [FK__Dependent__ESSN__164452B1]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Dependent]  WITH CHECK ADD FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
GO
/****** Object:  ForeignKey [FK__Employee__SuperS__173876EA]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([SuperSSN])
REFERENCES [dbo].[Employee] ([SSN])
GO
/****** Object:  ForeignKey [FK_Employee_Dno_Department_Dnumber]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Dno_Department_Dnumber] FOREIGN KEY([DNo])
REFERENCES [dbo].[Department] ([DNumber])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Dno_Department_Dnumber]
GO
/****** Object:  ForeignKey [FK__Project__DNum__1920BF5C]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Project]  WITH CHECK ADD FOREIGN KEY([DNum])
REFERENCES [dbo].[Department] ([DNumber])
GO
/****** Object:  ForeignKey [FK__Works_on__ESSN__1A14E395]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Works_on]  WITH CHECK ADD FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
GO
/****** Object:  ForeignKey [FK__Works_on__PNo__1B0907CE]    Script Date: 11/27/2021 13:22:17 ******/
ALTER TABLE [dbo].[Works_on]  WITH CHECK ADD FOREIGN KEY([PNo])
REFERENCES [dbo].[Project] ([PNumber])
GO
