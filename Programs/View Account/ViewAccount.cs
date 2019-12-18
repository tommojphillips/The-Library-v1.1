using System;
using System.Threading.Tasks;
using TM_Db_Lib.Account;
using TM_Db_Lib.Media;

namespace View_Account
{
    public class ViewAccount
    {
        // Written, 09.12.2019

        public User user 
        {
            get;
            private set;
        }
        public IdResultObject[] favoritedMovies
        {
            get;
            set;
        }
        public IdResultObject[] favoritedTvSeries
        {
            get;
            set;
        }

        public ViewAccount(User inUser) 
        {
            // Written, 09.12.2019

            if (inUser == null) 
                throw new NullReferenceException("User cannot be null. invaild argument.");
            this.user = inUser;
            Task.Run(this.retrieveFavoritedMedia);
        }
        internal async Task retrieveFavoriteMovies()
        {
            // Written, 17.12.2019

            this.favoritedMovies = await this.user.getFavoriteMovies();
        }
        internal async Task retrieveFavoriteTvSeries()
        {
            // Written, 17.12.2019

            this.favoritedTvSeries = await this.user.getFavoriteTvSeries();
        }
        internal async Task retrieveFavoritedMedia() 
        {
            // Written, 17.12.2019

            await this.retrieveFavoriteMovies();
            await this.retrieveFavoriteTvSeries();
        }
    }
}
