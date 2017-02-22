//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CrowdfundingPlatform.BAL.Unit_of_Work
//{
//   public class IUnitofWork : IDisposable
//    {

//        IRepository<User> UserRepository { get; set; }
//        IRepository<UserFunding> UserFundingRepository { get; set; }
//        IRepository<Project> ProjectRepository { get; set; }
//        IRepository<ProjectCategory> ProjectCategoryRepository { get; set; }
//        IRepository<FundingPackage> FundingPackageRepository { get; set; }
//        IRepository<ProjectComment> ProjectCommentreRepository { get; set; }
//        IRepository<ProjectUpdate> ProjectUpdateRepository { get; set; }
//        IRepository<ProjectStat> ProjectStatRepository { get; set; }
//        IRepository<ProjectExternalShare> ProjectExternalShareRepository { get; set; }
//        IRepository<Attachment> AttachmentRepository { get; set; }
//        IRepository<AttachmentSet> AttachmentSetRepository { get; set; }

//        VivaWalletEntities dbContext { get; set; }

//        void SaveChanges(bool save = true);
//        Task SaveChangesAsync(bool save = true);

//    }
//}
