create or alter procedure dbo.MeasurementGet(
    @MeasurementId int = 0, 
    @MeasurementType varchar(100) = '', 
    @All bit = 0, 
    @includeblank bit = 0,
    @Message varchar(500) = '' output
)
as 
begin
    select @MeasurementType = nullif(@MeasurementType, ''), @includeblank = isnull(@includeblank, 0)
    select m.MeasurementId, m.MeasurementType
    from Measurement m
    where m.MeasurementId = @MeasurementId
    or m.MeasurementType like '%' + @MeasurementType + '%'
    or @All = 1
    union select 0, ' '
    where @includeblank = 1
    order by m.MeasurementType
end
go

--exec MeasurementGet

--exec MeasurementGet @All = 1, @IncludeBlank = 1