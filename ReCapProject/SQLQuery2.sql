CREATE TABLE "Car"
(
CarId "int" IDENTITY (1, 1) NOT NULL ,
BrandId "int" NOT NULL,
ColorId "int" NOT NULL,
DailyPrice "int" NOT NULL,
ModelYear "int" NOT NULL,
CarDesc "varchar"
)
CREATE TABLE "Color"
(
CarId "int" IDENTITY (1, 1) NOT NULL ,
ColorName "varchar" NOT NULL
)
CREATE TABLE "Brand"
(
BrandId "int" IDENTITY (1, 1) NOT NULL ,
BrandName "varchar" NOT NULL
)
