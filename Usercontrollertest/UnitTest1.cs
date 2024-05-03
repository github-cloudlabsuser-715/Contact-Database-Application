using NUnit.Framework;
using System.Web.Mvc;
using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CRUD_application_2.Tests.Controllers
{
    [TestFixture]

    public class UserControllerTest
    {
        private UserController _controller;
        private List<User> _users;

        [SetUp]
        public void Setup()
        {
            _users = new List<User>
            {
                new User { Id = 1, Name = "Test User 1", Email = "test1@example.com" },
                new User { Id = 2, Name = "Test User 2", Email = "test2@example.com" },
                new User { Id = 3, Name = "Test User 3", Email = "test3@example.com" }
            };

            UserController.userlist = _users;
            _controller = new UserController();
        }

        [Test]
        public void Index_ReturnsCorrectViewWithModel()
        {
            var result = _controller.Index() as ViewResult;
            var model = result.Model as List<User>;

            Assert.AreEqual("Index", result.ViewName);
            Assert.AreEqual(_users.Count, model.Count);
        }

        [Test]
        public void Details_ReturnsCorrectViewWithModel()
        {
            var result = _controller.Details(1) as ViewResult;
            var model = result.Model as User;

            Assert.AreEqual("Details", result.ViewName);
            Assert.AreEqual(_users.First().Id, model.Id);
        }

        [Test]
        public void Create_Post_AddsUserAndRedirects()
        {
            var newUser = new User { Id = 4, Name = "Test User 4", Email = "test4@example.com" };
            var result = _controller.Create(newUser) as RedirectToRouteResult;

            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.IsTrue(UserController.userlist.Contains(newUser));
        }

        [Test]
        public void Edit_Post_UpdatesUserAndRedirects()
        {
            var updatedUser = new User { Id = 1, Name = "Updated User", Email = "updated@example.com" };
            var result = _controller.Edit(1, updatedUser) as RedirectToRouteResult;
            var user = UserController.userlist.First(u => u.Id == 1);

            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual(updatedUser.Name, user.Name);
            Assert.AreEqual(updatedUser.Email, user.Email);
        }

        [Test]
        public void Delete_Post_RemovesUserAndRedirects()
        {
            var result = _controller.Delete(1, new FormCollection()) as RedirectToRouteResult;
            var user = UserController.userlist.FirstOrDefault(u => u.Id == 1);

            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.IsNull(user);
        }
    }
}
