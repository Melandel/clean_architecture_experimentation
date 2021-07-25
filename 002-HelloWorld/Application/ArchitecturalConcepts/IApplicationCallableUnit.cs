namespace Application.ArchitecturalConcepts {
	public interface IApplicationCallableUnit<TAppRequest, TAppResponse>
		where TAppRequest: ApplicationInput
		where TAppResponse : ApplicationOutput
	{
		TAppResponse Process(TAppRequest request);
	}
}
