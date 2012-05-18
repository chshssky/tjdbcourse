SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[config]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[config](
	[config_key] [nvarchar](50) NOT NULL,
	[config_value] [nvarchar](50) NULL,
 CONSTRAINT [pk_config] PRIMARY KEY CLUSTERED 
(
	[config_key] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[library]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[library](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_library_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[group]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[group](
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_group] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[reader]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[reader](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[gender] [char](3) NOT NULL,
	[group_id] [int] NOT NULL,
 CONSTRAINT [pk_reader] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_reader_group]') AND parent_object_id = OBJECT_ID(N'[dbo].[reader]'))
ALTER TABLE [dbo].[reader]  WITH CHECK ADD  CONSTRAINT [fk_reader_group] FOREIGN KEY([group_id])
REFERENCES [dbo].[group] ([id])
GO
ALTER TABLE [dbo].[reader] CHECK CONSTRAINT [fk_reader_group]
