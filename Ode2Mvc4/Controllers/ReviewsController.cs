using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Ode2Mvc4.Models;

namespace Ode2Mvc4.Controllers 
{
    public class ReviewsController : Controller
    {
        //
        // GET: /Reviews/
        private readonly IEnumerable<RestaurantReview> _reviews= RestaurantReview.GetReviews();

        // add attribute making this not browser addressable
        [ChildActionOnly]
        public ActionResult BestReview()
        {
            var bestReview = from r in _reviews
                orderby r.Rating descending
                select r;

            return PartialView("_Reviews", bestReview.First());

        }

        public ActionResult Index() 
        {
            //List<RestaurantReview> _reviews = RestaurantReview.GetReviews();
            //_reviews = RestaurantReview.GetReviews();
            var model =
                from r in _reviews
                orderby r.Rating
                select r;
            return View(model);
        }

        //
        // GET: /Reviews/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reviews/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews/Edit/5

        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.ID == id);
            //return View();
            return View(review);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(r => r.ID == id);
            // bind model
            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }
            // failed, give form with user to fix
            return View(review);
        }

        //
        // GET: /Reviews/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
