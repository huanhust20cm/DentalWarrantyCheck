import React from "react";
import Link from "next/link";
export default function Banner() {
  return (
    <section className="banner-section p_relative">
      <div
        className="pattern-layer wow slideInDown "
        data-wow-delay="00ms"
        data-wow-duration="1500ms"
        style={{ backgroundImage: "url(assets/images/shape/shape-1.png)" }}
      ></div>
      <div className="shape">
        <div
          className="shape-1"
          style={{ backgroundImage: "url(assets/images/shape/shape-2.png)" }}
        ></div>
        <div
          className="shape-3"
          style={{ backgroundImage: "url(assets/images/shape/shape-4.png)" }}
        ></div>
        <div
          className="shape-4"
          style={{ backgroundImage: "url(assets/images/shape/shape-5.png)" }}
        ></div>
      </div>
      <div className="auto-container">
        <div className="row align-items-center">
          <div className="col-lg-6 col-md-12 col-sm-12 content-column">
            <div className="content-box">
              <h2>Răng sứ CERCONIA.</h2>
              <p>
                Cứng nhất thế giới, chế độ bảo hành chính hãng lên đến 10 năm.
                Độ cứng gấp 10 lần răng thật, độ trong mờ lên đến 49%
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
              <figure className="image float-bob-y">
                <img src="assets/images/banner/banner2.png" alt="" />
              </figure>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
