using FluentValidation;
using Project3BlogFoody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BlogFoody.BusinessLayer.ValidationRules.CategoryValidationRules
{
    public class CreateCategoryValidator : AbstractValidator<Category>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez!");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori Adı en az 5 karakter olmalı!");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori Adı en fazla 50 karakter olmalı!");
        }
    }
}
