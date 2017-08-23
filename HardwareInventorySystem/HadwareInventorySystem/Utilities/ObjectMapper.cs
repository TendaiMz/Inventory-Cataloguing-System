using AutoMapper;
using HadwareInventorySystem.Core.Models;
using HadwareInventorySystem.Core.ViewModels;
using System.Collections.Generic;

namespace HadwareInventorySystem.Utilities
{
    public static class ObjectMapper
    {
        public static ComponentViewModel MapToModel(Component component)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Component, ComponentViewModel>();
                cfg.CreateMap<ComponentType, ComponentTypeViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = component;
            var _component = mapper.Map<Component, ComponentViewModel>(source);
            return _component;
        }

        public static ComponentTypeViewModel MapToModel(ComponentType componentType)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ComponentType, ComponentTypeViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = componentType;
            var _componentType = mapper.Map<ComponentType, ComponentTypeViewModel>(source);
            return _componentType;
        }


        public static IEnumerable<ComponentViewModel> MapToModelList(List<Component> components)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Component, ComponentViewModel>();
                cfg.CreateMap<ComponentType, ComponentTypeViewModel>();
                
            });

            IMapper mapper = config.CreateMapper();
            var source = components;
            var componentsList = mapper.Map<List<Component>, List<ComponentViewModel>>(source);
            return componentsList;
        }

        public static IEnumerable<ComponentTypeViewModel> MapToModelList(List<ComponentType> componentTypes)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<ComponentType, ComponentTypeViewModel>();

            });

            IMapper mapper = config.CreateMapper();
            var source = componentTypes;
            var componentTypeList = mapper.Map<List<ComponentType>, List<ComponentTypeViewModel>>(source);
            return componentTypeList;
        }


    }
}