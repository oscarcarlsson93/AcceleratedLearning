--USE [Blogposts]
--GO

--CREATE TABLE [dbo].[BlogpostNEW2](
--	[BlogpostId] [int] IDENTITY(1,1) NOT NULL,
--	[Title] [nvarchar](50) NULL,
--	[Author] [nvarchar](50) NULL,
--	)

	--Select Name from Author
	--JOIN Blogpost on Author.AuthorId = Blogpost.AuthorId

	--Select Title, Text, Name FROM Comments
	--Join Blogpost on Comments.BlogpostId = Blogpost.BlogpostId
	--Join Author on Author.AuthorId = Comments.AuthorId

	--Select Text, Name FROM Comments
 --                Join Author on Author.AuthorId = Comments.AuthorId
 --                   Where BlogpostId = 2

	--				INSERT into Comments(Text) VALUES ('Sdasds')

					--Select Name from Tags Join Blogpost on Blogpost.BlogpostId = Tags.TagId

					Select Name from Tags Join Blogpost on Blogpost.BlogpostId = BlogTag.BlogpostId
					Join BlogTag on BlogTag.BlogpostId = Tags.TagId

	