﻿using Domain;
using Interfaces.Repositories;

namespace Interfaces.UOW
{
    public interface IUOW
    {
        //save pending changes to the data store
        void Commit();
        //void RefreshAllEntities();

        //UOW Methods, that dont fit into specific repo

        //get repository for type
        T GetRepository<T>() where T : class;

        // standard autocreated repos, since we do not have any special methods in interfaces


        IContactTypeRepository ContactTypes { get; }
        IMultiLangStringRepository MultiLangStrings { get; }
        ITranslationRepository Translations { get; }


        IPersonRepository Persons { get; }
        IContactRepository Contacts { get; }
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        IIngredientRepository Ingredients { get; }
        IProductRepository Products { get; }
        IImageRepository Images { get; }
        IOrderRepository Orders { get; }
        IOrderStatusRepository OrderStatuses { get; }
        IInvoiceRepository Invoices { get; }
        IQuestionRepository Questions { get; }

        // Identity, PK - string
        //IUserRepository Users { get; }
        //IUserRoleRepository UserRoles { get; }
        //IRoleRepository Roles { get; }
        //IUserClaimRepository UserClaims { get; }
        //IUserLoginRepository UserLogins { get; }

        // Identity, PK - int
        IUserIntRepository UsersInt { get; }
        IUserRoleIntRepository UserRolesInt { get; }
        IRoleIntRepository RolesInt { get; }
        IUserClaimIntRepository UserClaimsInt { get; }
        IUserLoginIntRepository UserLoginsInt { get; }
    }
}