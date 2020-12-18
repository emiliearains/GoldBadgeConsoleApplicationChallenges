using ChallengeThreeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChallengeThreeUnitTest
{
    [TestClass]
    public class ChallengeThreeUnitTest
    {
        private BadgeRepository _badgeRepo;
        private Badge _badge;

        [TestInitialize]
        public void Arrange()
        {
            _badgeRepo = new BadgeRepository();
            _badge = new Badge(61, new List<string>() { "D2", "D4", "D6" });
            _badgeRepo.AddBadge(_badge);
        }
        [TestMethod]
        public void SubMenuAddBadge_ShouldGetNotNull()
        {
            Badge testBadge = new Badge(62, new List<string>() { "D2", "D4", "D6" });
            _badgeRepo.AddBadge(testBadge);
            Badge badgeTomato = _badgeRepo.GetBadgesByBadgeID(62);

            Assert.IsNotNull(badgeTomato);
        }
        [TestMethod]
        public void SubMenuUpdateBadge_ShouldReturnTrue()
        {
            Badge updatedBadge = _badgeRepo.GetBadgesByBadgeID(61);
            updatedBadge.DoorNames = new List<string>() { "D44" };
            Assert.IsTrue(_badgeRepo.UpdateBadge(updatedBadge));
        }
    }
}
