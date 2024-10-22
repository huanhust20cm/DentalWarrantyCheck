"use client";
import { Autoplay, Navigation, Pagination } from "swiper/modules";
import { Swiper, SwiperSlide } from "swiper/react";

const swiperOptions = {
  modules: [Autoplay, Pagination, Navigation],
  slidesPerView: 1,
  spaceBetween: 30,
  autoplay: {
    delay: 2500,
    disableOnInteraction: false,
  },
  loop: true,

  // Navigation
  navigation: {
    nextEl: ".h1n",
    prevEl: ".h1p",
  },

  // Pagination
  pagination: {
    el: ".swiper-pagination",
    clickable: true,
  },

  breakpoints: {
    320: {
      slidesPerView: 1,
      // spaceBetween: 30,
    },
    575: {
      slidesPerView: 1,
      // spaceBetween: 30,
    },
    767: {
      slidesPerView: 1,
      // spaceBetween: 30,
    },
    991: {
      slidesPerView: 1,
      // spaceBetween: 30,
    },
    1199: {
      slidesPerView: 1,
      // spaceBetween: 30,
    },
    1350: {
      slidesPerView: 1,
      // spaceBetween: 30,
    },
  },
};
export default function TestimonialSlider1() {
  return (
    <div>
      <Swiper
        {...swiperOptions}
        className="single-item-carousel owl-carousel owl-theme owl-dots-none owl-nav-none"
      >
        <SwiperSlide className="slide-item">
          <div className="testimonial-block-one">
            <div className="inner-box">
              <div className="icon-box">
                <i className="icon-23"></i>
              </div>
              <p>
                Từ khi làm răng sứ Cerconia xong, mình cười nhiều hơn, công việc
                làm ăn cũng hanh thông hơn.
              </p>
              <div className="author-box">
                <figure className="author-thumb">
                  <img src="assets/images/resource/KH1.jpg" alt="" />
                </figure>
                <ul className="rating clearfix">
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="far fa-star"></i>
                  </li>
                </ul>
                <h3>Vũ Trà My</h3>
                <span className="designation">Thẩm mỹ 20 răng sứ Cernia</span>
              </div>
            </div>
          </div>
        </SwiperSlide>
        <SwiperSlide className="slide-item">
          <div className="testimonial-block-one">
            <div className="inner-box">
              <div className="icon-box">
                <i className="icon-23"></i>
              </div>
              <p>
                Mình đã tìm hiểu nhiều dòng sứ khác trước khi quyết định chọn
                Cerconia. Sau khi làm xong mình rất hài lòng.
              </p>
              <div className="author-box">
                <figure className="author-thumb">
                  <img src="assets/images/resource/KH2.jpg" alt="" />
                </figure>
                <ul className="rating clearfix">
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="far fa-star"></i>
                  </li>
                </ul>
                <h3>Nguyễn Hải Phong </h3>
                <span className="designation">Thẩm mỹ 16 răng sứ Cerconia</span>
              </div>
            </div>
          </div>
        </SwiperSlide>
        <SwiperSlide className="slide-item">
          <div className="testimonial-block-one">
            <div className="inner-box">
              <div className="icon-box">
                <i className="icon-23"></i>
              </div>
              <p>
                Điều mình thích nhất ở dòng sứ Cerconia này là nó có độ cứng
                chắc vượt trội. Mình ăn cả thế giới mà không vấn đề gì cả!
              </p>
              <div className="author-box">
                <figure className="author-thumb">
                  <img src="assets/images/resource/KH3.jpg" alt="" />
                </figure>
                <ul className="rating clearfix">
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="far fa-star"></i>
                  </li>
                </ul>
                <h3>Phạm Huyền Thảo</h3>
                <span className="designation">Thẩm mỹ 24 răng sứ Cerconia</span>
              </div>
            </div>
          </div>
        </SwiperSlide>
        <SwiperSlide className="slide-item">
          <div className="testimonial-block-one">
            <div className="inner-box">
              <div className="icon-box">
                <i className="icon-23"></i>
              </div>
              <p>
                Màu sắc răng rất vừa ý mình, thực sự trông rất tự nhiên. Mình đã
                giới thiệu răng sứ Cerconia cho một số người bạn của mình.
              </p>
              <div className="author-box">
                <figure className="author-thumb">
                  <img src="assets/images/resource/KH4.jpg" alt="" />
                </figure>
                <ul className="rating clearfix">
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="far fa-star"></i>
                  </li>
                </ul>
                <h3>Nguyễn Cẩm Thu</h3>
                <span className="designation">Thẩm mỹ 18 răng sứ Cerconia</span>
              </div>
            </div>
          </div>
        </SwiperSlide>
        <SwiperSlide className="slide-item">
          <div className="testimonial-block-one">
            <div className="inner-box">
              <div className="icon-box">
                <i className="icon-23"></i>
              </div>
              <p>
                Sau khi tìm hiểu, mình tin tưởng vào chất lượng răng sứ Cerconia
                và kết quả đạt được không hề khiến tôi thất vọng.
              </p>
              <div className="author-box">
                <figure className="author-thumb">
                  <img src="assets/images/resource/KH5.jpg" alt="" />
                </figure>
                <ul className="rating clearfix">
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="fas fa-star"></i>
                  </li>
                  <li>
                    <i className="far fa-star"></i>
                  </li>
                </ul>
                <h3>Trịnh Văn Đạt </h3>
                <span className="designation">Thẩm mỹ 22 răng sứ Cerconia</span>
              </div>
            </div>
          </div>
        </SwiperSlide>
      </Swiper>
    </div>
  );
}
