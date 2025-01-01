create or alter proc dbo.MeasurementDelete(
    @MeasurementId int
)
as 
begin
    declare @return int = 0

    select @MeasurementId = isnull(@MeasurementId, 0)

        begin try
            begin tran

                delete ri
                from RecipeIngredient ri
                where ri.MeasurementId = @MeasurementId
    
                delete m
                from Measurement m
                where m.MeasurementId = @MeasurementId
            commit
        end try
    
        begin catch
            rollback;
            throw
        end catch

    return @return
end
go