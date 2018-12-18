using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shop.Data.Infastructure;
using Shop.Data.Repositories;
using Shop.Model.Models;
using Shop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UnitTest.ServicesTest
{
    [TestClass]
    public class PostCategoryServicesTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categgoryServices;
        private List<PostCategory> _listCategory;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categgoryServices = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() { ID=1, Name ="DM1", Status = true },
                new PostCategory() { ID = 2, Name = "DM2", Status = true },
                new PostCategory() { ID = 3, Name = "DM3", Status = true },
            };
        }

        [TestMethod]
        public void PostCategoryService_GeatAll()
        {
            // Setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);
            //Call action
            var result = _categgoryServices.GetAll() as List<PostCategory>;
            // compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategoryService_Create()
        {
            PostCategory category = new PostCategory();
            int id = 1;
            category.Name = "Test";
            category.Alias = "Test";
            category.Status = true;

            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
            {
                p.ID = 1;
                return p;
            });
            var result = _categgoryServices.Add(category);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
