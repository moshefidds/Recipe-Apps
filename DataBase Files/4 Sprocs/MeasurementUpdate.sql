create or alter proc MeasurementUpdate(
    @MeasurementId int = 0 output,
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

            select @MeasurementId = SCOPE_IDENTITY()
        end
    else 
        begin
            update Measurement
            set
            MeasurementType = @MeasurementType
        where MeasurementId = @MeasurementId 
    end
    return @return
end
go