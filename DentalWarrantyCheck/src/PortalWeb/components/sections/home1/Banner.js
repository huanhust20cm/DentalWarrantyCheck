import React from "react";
import Link from "next/link";
export default function Banner() {
  return (
    <section className="banner-section p_relative">
      <div
        className="pattern-layer wow slideInDown "
        data-wow-delay="00ms"
        data-wow-duration="1500ms"
        style={{ backgroundImage: "url(assets/images/banner/banner1.png)" }}
      ></div>
      <div className="shape">
        <div
          className="shape-3"
          style={{ backgroundImage: "url(assets/images/shape/shape-4.png)" }}
        ></div>
      </div>
      <div className="auto-container">
        <div className="row align-items-center">
          <div className="col-lg-6 col-md-12 col-sm-12 content-column">
            <div className="content-box">
              <h2>
                Răng sứ
                <br /> CERCONIA
              </h2>
              <p>
                Khả năng chịu lực gấp 10 lần răng thật, độ thẩm mỹ tối ưu với độ
                trong mờ lên đến 49%, tương thích sinh học cao
              </p>
              <div className="btn-box">
                <Link href="/tra-cuu-bao-hanh" className="theme-btn btn-two">
                  <span>Tra cứu bảo hành</span>
                </Link>
              </div>
            </div>
          </div>
          <div className="col-lg-6 col-md-12 col-sm-12 image-column">
            <div className="image-box">
              <figure className="image">
                <img src="assets/images/banner/banner2.png" alt="" />
              </figure>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
