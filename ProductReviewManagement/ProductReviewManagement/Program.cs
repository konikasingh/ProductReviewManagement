﻿using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 st method
            //List<ProductReview> list = new List<ProductReview>();
            //list.Add(new ProductReview() { ProductId = 1, UserId = 1, Review = "good", Rating = 17, IsLike = true });

            //2 nd method
            //Collection intializer
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ ProductId=1,UserId=1,Review="good",Rating=17,IsLike=true},
                new ProductReview(){ ProductId=2,UserId=3,Review="bad",Rating=1,IsLike=false},
                new ProductReview(){ ProductId=3,UserId=5,Review="good",Rating=20,IsLike=true},
                new ProductReview(){ ProductId=4,UserId=7,Review="average",Rating=10,IsLike=true},
                new ProductReview(){ ProductId=5,UserId=1,Review="bad",Rating=5,IsLike=false}
            };
        }
    }
}
