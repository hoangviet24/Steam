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
INSERT INTO [dbo].[Product]
           ([Name]
           ,[ImageUrl]
           ,[Detail]
           ,[Price]
           ,[isTrendingProduct]
           ,[isTopSaleProduct]
           ,[isTopPlayProduct])
     VALUES
           ('Warframe'
           ,'https://scontent.fsgn4-1.fna.fbcdn.net/v/t39.30808-6/425798983_1844130872703804_973563999780001148_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=3635dc&_nc_ohc=IK0lcWmMZq4AX_McADu&_nc_ht=scontent.fsgn4-1.fna&oh=00_AfDLxgzmmMqQc3QqsDy0gnAgilHhip0PYSg2fIN2yOF9wg&oe=65DAD2B1'
           ,N'Game RPG bắn súng hay nhất'
           ,0
           ,1
		   ,0
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
           ('Diablo Immortal'
           ,'https://scontent.fsgn13-2.fna.fbcdn.net/v/t39.30808-6/426920263_1845376715912553_3470706109835194956_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=3635dc&_nc_ohc=orS1JQdELLkAX-Q3XYr&_nc_ht=scontent.fsgn13-2.fna&oh=00_AfCq7t3ypU8wQ6IjTVlcqhEKKcO4_HNFT9MyzNR8X4_aLQ&oe=65DB61E1'
           ,N'Chưa chơi game này nên chưa thể cảm nhận'
           ,1000000
           ,1
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
           ('Diablo IV'
           ,'https://scontent.fsgn13-2.fna.fbcdn.net/v/t39.30808-6/426411694_1845376702579221_221871689530672809_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=3635dc&_nc_ohc=0t2a6QfPXcIAX_D3tRV&_nc_ht=scontent.fsgn13-2.fna&oh=00_AfCnS8FYwKNFY6zAZw0akZqUsYTQllLmTJlXUvAwkMvgew&oe=65DA40AE'
           ,N'Game hết hay'
           ,1000000
           ,1
		   ,0
           ,1)
GO


