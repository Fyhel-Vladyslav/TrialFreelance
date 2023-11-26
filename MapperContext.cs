using AutoMapper;
using TrialFreelance.Models;
using TrialFreelance.ViewModels;

namespace TrialFreelance
{
    public class MapperContext : Profile
    {
        public MapperContext()
        {
            CreateMap<Order, PreOrderViewModel>();
            CreateMap<OrderSolution, OrderSolutionViewModel>();
            CreateMap<Message, MessageViewModel>();

        }
    }
}
