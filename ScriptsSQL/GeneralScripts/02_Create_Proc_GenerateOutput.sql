CREATE PROCEDURE [dbo].[GenerateOutput]
(
	@NickName VARCHAR(50),
	@MarketValue DECIMAL(15,2),
	@Type VARCHAR(25)

	-- exec [dbo].[GenerateOutput] 'Instrument1',800000, 'Stock'

)
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @OutputParameters TABLE
	(
		NickName VARCHAR(25),
		MarketValue DECIMAL(15,2),
		Type VARCHAR(25),
		CategoryCode VARCHAR(25),
		CategoryDescription VARCHAR(80)
	)

	INSERT INTO @OutputParameters
	SELECT @NickName, @MarketValue, @Type, c.Code, c.Description
	FROM Category c 
	WHERE @MarketValue > MinimumValue AND @MarketValue < MaximumValue

	SELECT o.*, GETDATE() ProcessDate FROM @OutputParameters o
	LEFT JOIN InstrumentOutput io ON io.NickName = o.NickName
	WHERE io.NickName IS NULL

END