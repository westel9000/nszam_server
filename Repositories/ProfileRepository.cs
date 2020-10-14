using System;
using System.Collections.Generic;
using System.IO;
using ImageWebApp.Models;

namespace ImageWebApp.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private Profile _profile = new Profile();

        public ProfileRepository()
        {
            _profile.images = new List<Image>();
            _profile.images.Add(new Image { Id = 0, Content = File.ReadAllText("assets/im1"), Created = DateTime.Now, Owner = "User 1"});
            _profile.images.Add(new Image { Id = 1, Content = File.ReadAllText("assets/im1"), Created = DateTime.Now, Owner = "User 1"});
            _profile.images.Add(new Image { Id = 2, Content = File.ReadAllText("assets/im2"), Created = DateTime.Now, Owner = "User 1"});
            _profile.images.Add(new Image { Id = 3, Content = File.ReadAllText("assets/im3"), Created = DateTime.Now, Owner = "User 1"});
            _profile.Bio =
                "Pick any number. Multiply it by two. Now add 12 to it. Divide it by 3. Now change it to 10. That’s how many seconds you just wasted.";
        }

        public Profile Get()
        {
            return _profile;
        }
    }
}