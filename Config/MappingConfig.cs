using AutoMapper;
using WebApiTutorial.Data.ValueObjects;
using WebApiTutorial.Model;

namespace WebApiTutorial.Config;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ProdutoVO, Produto>();
            config.CreateMap<Produto, ProdutoVO>();
            config.CreateMap<ProdutoRequestVO, Produto>();
            config.CreateMap<Produto, ProdutoRequestVO>();
        });
        return mappingConfig;
    }
}
