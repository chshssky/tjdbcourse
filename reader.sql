SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Group]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Group](
	[group_ID] [int] IDENTITY(1,1) NOT NULL,
	[group_name] [varchar](20) NOT NULL,
	[timelimit] [int] NOT NULL,
	[max_Borrow] [int] NOT NULL,
	[appointment] [binary](1) NOT NULL,
	[payment] [float] NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[group_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reader]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Reader](
	[reader_ID] [int] IDENTITY(1,1) NOT NULL,
	[reader_name] [varchar](20) NOT NULL,
	[sex] [varchar](2) NOT NULL,
	[birthday] [datetime] NOT NULL,
	[type_dentitycard] [varchar](10) NOT NULL,
	[identity_number] [varchar](20) NOT NULL,
	[telephone] [varchar](15) NOT NULL,
	[register_time] [datetime] NOT NULL,
	[effective_date] [datetime] NOT NULL,
	[loss_report] [int] NULL,
	[times_of_borrows] [int] NULL,
	[remarks] [varchar](50) NULL,
	[group_divide] [int] NOT NULL,
 CONSTRAINT [PK_STUINFO_STUN] PRIMARY KEY CLUSTERED 
(
	[reader_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Group_Group]') AND parent_object_id = OBJECT_ID(N'[dbo].[Group]'))
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Group] FOREIGN KEY([group_ID])
REFERENCES [dbo].[Group] ([group_ID])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Group]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Reader_Group]') AND parent_object_id = OBJECT_ID(N'[dbo].[Reader]'))
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [FK_Reader_Group] FOREIGN KEY([group_divide])
REFERENCES [dbo].[Group] ([group_ID])
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [FK_Reader_Group]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_STUINFO_SEX]') AND parent_object_id = OBJECT_ID(N'[dbo].[Reader]'))
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [CK_STUINFO_SEX] CHECK  (([sex]='boy' OR [sex]='girl'))
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [CK_STUINFO_SEX]
