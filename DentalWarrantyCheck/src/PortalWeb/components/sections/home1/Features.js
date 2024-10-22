import Link from "next/link";
import React from "react";

export default function feature() {
  return (
    <section className="feature-section pt_120 pb_90">
      <div
        className="shape"
        style={{ backgroundImage: "url(assets/images/shape/shape-6.png)" }}
      ></div>
      <div className="auto-container">
        <div className="row clearfix">
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <i className="icon-9"></i>
                </div>
                <h3>
                  <Link href="/">Cam kết bảo hành chính hãng</Link>
                </h3>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <i className="icon-10"></i>
                </div>
                <h3>
                  <Link href="/">100% Bác sĩ giàu kinh nghiệm thực hiện</Link>
                </h3>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <i className="icon-11"></i>
                </div>
                <h3>
                  <Link href="/">Hội chuẩn đánh giá chuyên môn</Link>
                </h3>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <i className="icon-12"></i>
                </div>
                <h3>
                  <Link href="/">Quy trình an toàn không đau</Link>
                </h3>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
