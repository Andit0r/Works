-- task1
CREATE TABLE Promotion(
	PromotionId INT NOT NULL IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	Description NVARCHAR(200) NULL,
	DiscountAmount INT NOT NULL,
	StartDate DATE DEFAULT GetDate() NOT NULL,
	EndDate DATE NULL

	CONSTRAINT PK_PromotionId
	PRIMARY KEY(PromotionId)
);

-- task2
CREATE TABLE PromotionalItem(
	PromotionId INT,
	BookId INT,

	CONSTRAINT PK_PromotionalBookId
	PRIMARY KEY(PromotionId, BookID),

	CONSTRAINT FK_PromotionalItem_Promotion
	FOREIGN KEY(PromotionId)
	REFERENCES Promotion
	ON DELETE NO ACTION
	ON UPDATE CASCADE,

	CONSTRAINT FK_PromotionalItem_Book
	FOREIGN KEY(BookId)
	REFERENCES Book
	ON DELETE NO ACTION
	ON UPDATE CASCADE
);

-- task3
ALTER TABLE Promotion
ADD DiscountType VARCHAR(5);

--task4
ALTER TABLE Promotion
ADD CONSTRAINT DF_Promotion_DiscountType 
DEFAULT '%' FOR DiscountType;

--task5
ALTER TABLE Promotion
ADD CONSTRAINT CK_Promotion_DiscountType
CHECK (DiscountType = '%' OR DiscountType = 'руб.');

ALTER TABLE Promotion
ADD CONSTRAINT CK_Promotion_DiscountAmount
CHECK(DiscountAmount > 0);

--task6
ALTER TABLE Promotion
ADD CONSTRAINT UQ_Promotion_StartDateName
UNIQUE(Name, StartDate);

--task7
ALTER TABLE PromotionalItem
DROP CONSTRAINT FK_PromotionalItem_Promotion;

ALTER TABLE PromotionalItem
DROP CONSTRAINT FK_PromotionalItem_Book;
