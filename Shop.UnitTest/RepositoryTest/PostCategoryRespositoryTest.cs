using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Data.Infastructure;
using Shop.Data.Repositories;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UnitTest.RepositoryTest
{
    [TestClass] //Chỉ ra các test key
    public class PostCategoryRespositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize] // Thuộc tính chạy lần đầu tien khi ứng dụng chạy
        public void Initialize()
        {
            // Khai báo dùng inteface, khởi tạo dùng contractor
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3,list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Test Category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);


        }
    }
}
