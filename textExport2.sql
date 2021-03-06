USE [Tamhmor1]
GO
/****** Object:  Table [dbo].[Chat]    Script Date: 14/4/2564 1:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chat](
	[Cid] [int] IDENTITY(1,1) NOT NULL,
	[Datetime] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Chat] PRIMARY KEY CLUSTERED 
(
	[Cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 14/4/2564 1:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[Did] [int] IDENTITY(1,1) NOT NULL,
	[Dfname] [varchar](50) NOT NULL,
	[Dlname] [varchar](50) NOT NULL,
	[Dage] [varchar](3) NOT NULL,
	[Dsex] [int] NULL,
	[Ddepartment] [varchar](max) NOT NULL,
	[Dhospital] [varchar](max) NOT NULL,
	[Dexpertise] [varchar](max) NOT NULL,
	[Dprice] [varchar](5) NOT NULL,
	[Dimage] [varchar](max) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[Did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 14/4/2564 1:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Oid] [int] IDENTITY(1,1) NOT NULL,
	[Total] [varchar](50) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14/4/2564 1:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Uid] [int] IDENTITY(1,1) NOT NULL,
	[Ufname] [varchar](50) NOT NULL,
	[Ulname] [varchar](50) NOT NULL,
	[Usex] [int] NULL,
	[Uemail] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([Did], [Dfname], [Dlname], [Dage], [Dsex], [Ddepartment], [Dhospital], [Dexpertise], [Dprice], [Dimage]) VALUES (1, N'ปลายฟ้า', N'มิตรมาตร', N'30', 1, N'ทันตกรรม', N'ศิริราช', N'ทันตกรรม', N'200', N'C:\Users\admin\source\repos\back.Tamhmor\back.Tamhmor.api\Images\ปรายฟ้า.jpg')
INSERT [dbo].[Doctor] ([Did], [Dfname], [Dlname], [Dage], [Dsex], [Ddepartment], [Dhospital], [Dexpertise], [Dprice], [Dimage]) VALUES (3, N'ดร.กมล ', N'วิทยา', N'35', 1, N'อายุรกรรม', N'ศิริราช', N'ประสบการณ์การทำงานมากกว่า 10 ปี ด้านอายุรกรรม การวินิฉัยโรคทั่วไป', N'200', N'C:\Users\admin\source\repos\back.Tamhmor\back.Tamhmor.api\Images\กมล.webp')
INSERT [dbo].[Doctor] ([Did], [Dfname], [Dlname], [Dage], [Dsex], [Ddepartment], [Dhospital], [Dexpertise], [Dprice], [Dimage]) VALUES (5, N'ภูมิภพ', N'หัตรเทพ', N'40', 0, N'ทั่วไป', N'นนทเวศ', N'การวินิฉัยโรคทั่วไป ให้คำปรึกษาโรคไตเป็นพิเศษ', N'200', N'C:\Users\admin\source\repos\back.Tamhmor\back.Tamhmor.api\Images\จงจิตร.jpg')
INSERT [dbo].[Doctor] ([Did], [Dfname], [Dlname], [Dage], [Dsex], [Ddepartment], [Dhospital], [Dexpertise], [Dprice], [Dimage]) VALUES (6, N'ดร.จงจิตร', N'วินิจ', N'50', 0, N'จิตกรรม', N'คลินิคส่วนตัว', N'ให้คำปรึกษาทางด้านจิตใจ', N'200', N'C:\Users\admin\source\repos\back.Tamhmor\back.Tamhmor.api\Images\ภูมิภพ.jpg')
INSERT [dbo].[Doctor] ([Did], [Dfname], [Dlname], [Dage], [Dsex], [Ddepartment], [Dhospital], [Dexpertise], [Dprice], [Dimage]) VALUES (7, N'วงวิทย์', N'มารถวิถี', N'44', 0, N'จิตกรรม', N'ชลประทาน', N'การรักษาทางด้านจิตใจ', N'200', N'C:\Users\admin\source\repos\back.Tamhmor\back.Tamhmor.api\Images\วงวิทย์.jpg')
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
/****** Object:  StoredProcedure [dbo].[Sp_addUsers]    Script Date: 14/4/2564 1:46:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_addUsers] 
	-- Add the parameters for the stored procedure here
	@Uid int,
	@Ufname varchar(50),
	@Ulname varchar(50),
	@Usex int,
	@Uemail varchar(50)
AS
BEGIN
	insert into Users(Uid,Ufname,Ulname,Usex,Uemail) values (@Uid,
	@Ufname ,
	@Ulname ,
	@Usex ,
	@Uemail )
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_departmentDoctor]    Script Date: 14/4/2564 1:46:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_departmentDoctor]
	
AS
BEGIN
	SELECT DISTINCT Ddepartment

	FROM [Tamhmor1].[dbo].[Doctor]
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Doctor]    Script Date: 14/4/2564 1:46:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Doctor] 
	
AS
BEGIN
	SELECT Did,Dfname,Dlname,Dage,Dsex,Ddepartment,Dexpertise,Dprice,Dhospital,Dimage

	FROM [Tamhmor1].[dbo].[Doctor]
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_SearchDoctor]    Script Date: 14/4/2564 1:46:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_SearchDoctor] 

	@searchText nvarchar
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	from Doctor
	where Dfname like @searchText
END
GO
