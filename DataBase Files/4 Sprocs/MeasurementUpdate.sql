create or alter proc MeasurementUpdate(
    @MeasurementId int output,
    @MeasurementType varchar(50),
    @Message varchar(500) = ''
)
as 
begin
    declare @return int = 0

    select @MeasurementId = isnull(@MeasurementId, 0)

    if @MeasurementId = 0
        begin
            insert Measurement(MeasurementType)
            values(@MeasurementType)
        end
    else 
        begin
            update Measurement
            set
            MeasurementType = @MeasurementType
        where MeasurementId = @MeasurementId 
    end
    select @MeasurementId = SCOPE_IDENTITY()
end