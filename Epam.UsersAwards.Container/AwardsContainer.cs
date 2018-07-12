﻿using Epam.UsersAwards.BLL.Contracts;
using Epam.UsersAwards.BLL.Logic;

namespace Epam.UsersAwards.Containers
{
    public static class AwardsContainer
    {
        public static IAwardDAO AwardDAO { get; set } = new AwardFakeDAO();

        public static IAwardLogic AwardLogic { get; set; } = new AwardLogic(AwardDAO);
    }
}
