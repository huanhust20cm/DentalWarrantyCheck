import Link from "next/link";
import React from "react";

export default function feature() {
  return (
    <section className="feature-section pt_120 pb_90">
      <div className="auto-container">
        <div className="row clearfix grid-mobile">
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <img src="assets/images/icons/01.png" alt="" />
                </div>
                <h3>
                  <Link href="/#">Cam kết bảo hành chính hãng</Link>
                </h3>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <img src="assets/images/icons/02.png" alt="" />
                </div>
                <h3>
                  <Link href="/#">Trắng, trong, bền đẹp trọn đời</Link>
                </h3>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <img src="assets/images/icons/03.png" alt="" />
                </div>
                <h3>
                  <Link href="/#">Không đau, không viêm sau làm</Link>
                </h3>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-6 col-sm-12 feature-block">
            <div className="feature-block-one">
              <div className="inner-box">
                <div className="icon-box">
                  <img src="assets/images/icons/04.png" alt="" />
                </div>
                <h3>
                  <Link href="/#">Bảo tồn tối đa răng gốc</Link>
                </h3>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
