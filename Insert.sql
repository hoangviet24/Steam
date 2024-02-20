USE [SteamNextGen]
GO

INSERT INTO [dbo].[Product]
           ([Name]
           ,[ImageUrl]
           ,[Detail]
           ,[Price]
           ,[isTrendingProduct]
           ,[isTopSaleProduct]
           ,[isTopPlayProduct])
     VALUES
           ('Son of Nunu'
           ,'https://scontent.fdad3-4.fna.fbcdn.net/v/t39.30808-6/423160636_1837787406671484_2699512143389249299_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=3635dc&_nc_ohc=n4KVW9FnQjEAX9fbY6g&_nc_ht=scontent.fdad3-4.fna&oh=00_AfAtcmuiZI7APKL7b18bsqWmLd1HsRrmP8MAm5Wui0E7VQ&oe=65D94C90'
           ,N'Game của nhà làm game 200 năm kinh nghiệm nhưng lại tính phí'
           ,300000
           ,0
		   ,1
           ,1)
GO
INSERT INTO [dbo].[Product]
           ([Name]
           ,[ImageUrl]
           ,[Detail]
           ,[Price]
           ,[isTrendingProduct]
           ,[isTopSaleProduct]
           ,[isTopPlayProduct])
     VALUES
           ('Honkai Impact 3'
           ,'https://scontent.fdad3-5.fna.fbcdn.net/v/t39.30808-6/423134131_1837787673338124_3394606830261788604_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=3635dc&_nc_ohc=-rlSLU3i8pgAX_mqajL&_nc_ht=scontent.fdad3-5.fna&oh=00_AfCXOXfY7-Tb9DgNXmIpeG51rBiip8CAty3dR-uZCGcUug&oe=65D98409'
           ,N'Game của nhà Mihoyo'
           ,0
           ,0
		   ,0
           ,1)
GO



