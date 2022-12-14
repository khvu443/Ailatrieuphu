USE [master]
GO
/****** Object:  Database [WhoWantToBeAMillionaire]    Script Date: 11/12/2022 9:25:54 AM ******/
CREATE DATABASE [WhoWantToBeAMillionaire]
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WhoWantToBeAMillionaire].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET ARITHABORT OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET RECOVERY FULL 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET  MULTI_USER 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WhoWantToBeAMillionaire', N'ON'
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET QUERY_STORE = OFF
GO
USE [WhoWantToBeAMillionaire]
GO
/****** Object:  Table [dbo].[answer]    Script Date: 11/12/2022 9:25:55 AM ******/
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
/****** Object:  Table [dbo].[question]    Script Date: 11/12/2022 9:25:55 AM ******/
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
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q1', N'A', N'2023', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q10', N'A', N'Qatar', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q11', N'A', N'Quảng Bình', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q12', N'A', N'Văn Lang', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q13', N'A', N'Vitamin A', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q14', N'A', N'Sông Nhật Lệ', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q15', N'A', N'Sát thủ', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q2', N'A', N'Vàng', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q3', N'A', N'Đủ', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q4', N'A', N'4', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q5', N'A', N'2030', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q6', N'A', N'N', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q7', N'A', N'Voi', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q8', N'A', N'Cua', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q9', N'A', N'0.2', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q1', N'B', N'Không bao giờ vô địch', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q10', N'B', N'Hàn Quốc', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q11', N'B', N'Quảng Ninh', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q12', N'B', N'Âu Lạc', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q13', N'B', N'Vitamin D', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q14', N'B', N'Sông Gianh', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q15', N'B', N'Bác sĩ', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q2', N'B', N'Bằng Nhau', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q3', N'B', N'Nhiều', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q4', N'B', N'5', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q5', N'B', N'2222', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q6', N'B', N'S', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q7', N'B', N'Trâu', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q8', N'B', N'Ghẹ', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q9', N'B', N'0.5', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q1', N'C', N'2002', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q10', N'C', N'Nhật Bản', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q11', N'C', N' Quảng Trị', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q12', N'C', N'Vạn Xuân', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q13', N'C', N'Vitamin E', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q14', N'C', N'Sông Long Đạ', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q15', N'C', N'Sát sinh', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q2', N'C', N'Bông', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q3', N'C', N'No', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q4', N'C', N'6', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q5', N'C', N'2999', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q6', N'C', N'A', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q7', N'C', N'Dê', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q8', N'C', N'Ngỗng', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q9', N'C', N'0.4', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q1', N'D', N'9999', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q10', N'D', N'Iraq', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q11', N'D', N'Quảng Ngãi', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q12', N'D', N'Đại Việt', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q13', N'D', N'Vitamin K', 1)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q14', N'D', N'Sông Kiến Giang', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q15', N'D', N' Thái Đa tình', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q2', N'D', N'Sắt', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q3', N'D', N'Đói', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q4', N'D', N'7', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q5', N'D', N'2023', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q6', N'D', N'W', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q7', N'D', N'Tê Giác', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q8', N'D', N'Ngược', 0)
INSERT [dbo].[answer] ([QID], [AID], [answerQuestion], [isCorrect]) VALUES (N'Q9', N'D', N'0.3', 1)
GO
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q1', N'Khi nào MU Vô địch cúp C1?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q10', N'AFC Asian Cup 2011 được tổ chức tại quốc gia?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q11', N'Sông Bến Hải và sông Thạch Hãn nằm ở tỉnh nào?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q12', N'Các vua Hùng đặt quốc hiệu nước ta?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q13', N'Основная роль какого витамина заключается в обеспечении правильного свертывания крови и ограничении объема кровопотери при травмах?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q14', N'Tượng đài Mẹ Suốt nằm bên cạnh con sông nào?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q15', N'Cái gì có 2 lỗ đ** mà giết người?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q2', N'1 kg vàng, 1kg sắt, 1kg bông cái nào nặng nhất?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q3', N'Ăn chưa ... lo chưa tới?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q4', N'Hà Nội xưa có mấy cửa ô?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q5', N'Khi nào MU Vô địch cúp C2?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q6', N'Bản đồ đất nước Việt Nam hình chữ gì?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q7', N'Con vật nào sau đây có ngà?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q8', N'Người ta thường nói ngang như...?')
INSERT [dbo].[question] ([QID], [Question]) VALUES (N'Q9', N'Một quần thể thực vật có thành phần kiểu gen: 0,2 AA : 0,2Aa : 0,6aa. Theo lí thuyết, tần số alen A của quần thể này là?')
GO
ALTER TABLE [dbo].[answer]  WITH CHECK ADD  CONSTRAINT [FK_answer_question] FOREIGN KEY([QID])
REFERENCES [dbo].[question] ([QID])
GO
ALTER TABLE [dbo].[answer] CHECK CONSTRAINT [FK_answer_question]
GO
USE [master]
GO
ALTER DATABASE [WhoWantToBeAMillionaire] SET  READ_WRITE 
GO
