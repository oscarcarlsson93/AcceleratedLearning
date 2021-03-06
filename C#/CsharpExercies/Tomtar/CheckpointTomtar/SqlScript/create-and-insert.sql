
USE [master]

CREATE DATABASE [GnomeDb4]
GO

USE [GnomeDb4]
GO

CREATE TABLE [dbo].[Gnome](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[HasBeard] [bit] NOT NULL,
	[IsEvil] [bit] NOT NULL,
	[Temperament] [smallint] NOT NULL,
	[RaceId] [int] NULL,
 CONSTRAINT [PK_Gnome] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GnomeRace]    Script Date: 2018-09-09 5:35:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GnomeRace](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_GnomeRace] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gnome] ON 

INSERT [dbo].[Gnome] ([Id], [Name], [HasBeard], [IsEvil], [Temperament], [RaceId]) VALUES (1, N'Grobnick', 1, 0, 5, 1)
INSERT [dbo].[Gnome] ([Id], [Name], [HasBeard], [IsEvil], [Temperament], [RaceId]) VALUES (2, N'Kazbo', 1, 1, 1, 2)
INSERT [dbo].[Gnome] ([Id], [Name], [HasBeard], [IsEvil], [Temperament], [RaceId]) VALUES (3, N'Beggra', 0, 1, 4, 2)

SET IDENTITY_INSERT [dbo].[Gnome] OFF
SET IDENTITY_INSERT [dbo].[GnomeRace] ON 

INSERT [dbo].[GnomeRace] ([Id], [Name]) VALUES (1, N'Skogstome')
INSERT [dbo].[GnomeRace] ([Id], [Name]) VALUES (2, N'Bergtomte')
INSERT [dbo].[GnomeRace] ([Id], [Name]) VALUES (3, N'Kaostomte')
SET IDENTITY_INSERT [dbo].[GnomeRace] OFF
ALTER TABLE [dbo].[Gnome] ADD  CONSTRAINT [DF_Gnome_HasBeard]  DEFAULT ((1)) FOR [HasBeard]
GO
ALTER TABLE [dbo].[Gnome] ADD  CONSTRAINT [DF_Gnome_IsEvil]  DEFAULT ((0)) FOR [IsEvil]
GO
ALTER TABLE [dbo].[Gnome] ADD  CONSTRAINT [DF_Gnome_Temperament]  DEFAULT ((3)) FOR [Temperament]
GO
ALTER TABLE [dbo].[Gnome] ADD  CONSTRAINT [DF_Gnome_RaceId]  DEFAULT ((1)) FOR [RaceId]
GO
ALTER TABLE [dbo].[Gnome]  WITH CHECK ADD  CONSTRAINT [FK_Gnome_GnomeRace] FOREIGN KEY([RaceId])
REFERENCES [dbo].[GnomeRace] ([Id])
GO
ALTER TABLE [dbo].[Gnome] CHECK CONSTRAINT [FK_Gnome_GnomeRace]
GO
USE [master]
GO
ALTER DATABASE [GnomeDb4] SET  READ_WRITE 
GO
