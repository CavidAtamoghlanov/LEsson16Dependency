using Lesson16WpfDependenctInjection.Commands;
using Lesson16WpfDependenctInjection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16WpfDependenctInjection.ViewModels
{
    public class AllProductViewModel
    {
        public AppDbContext DbContext { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public AllProductViewModel(AppDbContext dbContext)
        {
            DbContext = dbContext;
            DeleteCommand = new RelayCommand(Delete);
        }

        private void Delete(object? obj)
        {
            DbContext.RemoveProduct(obj!.ToString()!);
        }
    }
}
