USE [WhoWantToBeAMillionaire]
GO
/****** Object:  Table [dbo].[answer]    Script Date: 11/11/2022 11:48:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[answer](
	[QID] [nvarchar](50) NOT NULL,
	[AID] [nvarchar](50) NOT NULL,
	[answerQuestion] [nvarchar](50) NULL,
	[isCorrect] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[AID] ASC,
	[QID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[question]    Script Date: 11/11/2022 11:48:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[question](
	[QID] [nvarchar](50) NOT NULL,
	[Question] [nvarchar](max) NULL,
 CONSTRAINT [PK__question__CAB147CBDF79D3EE] PRIMARY KEY CLUSTERED 
(
	[QID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[answer]  WITH CHECK ADD  CONSTRAINT [FK_answer_question] FOREIGN KEY([QID])
REFERENCES [dbo].[question] ([QID])
GO
ALTER TABLE [dbo].[answer] CHECK CONSTRAINT [FK_answer_question]
GO
