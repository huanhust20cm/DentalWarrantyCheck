import Link from "next/link";
import React from "react";

export default function about() {
  return (
    <section className="about-section pt_120 pb_120 bg-color-1">
      <div className="pattern-layer">
        <div
          className="pattern-1 rotate-me"
          style={{ backgroundImage: "url(assets/images/shape/shape-8.png)" }}
        ></div>
        <div
          className="pattern-2 rotate-me"
          style={{ backgroundImage: "url(assets/images/shape/shape-8.png)" }}
        ></div>
        <div
          className="pattern-3 rotate-me"
          style={{ backgroundImage: "url(assets/images/shape/shape-9.png)" }}
        ></div>
        <div
          className="pattern-4"
          style={{ backgroundImage: "url(assets/images/shape/shape-10.png)" }}
        ></div>
        <div
          className="pattern-5"
          style={{ backgroundImage: "url(assets/images/shape/shape-11.png)" }}
        ></div>
      </div>
      <div className="auto-container">
        <div className="row clearfix">
          <div className="col-lg-6 col-md-12 col-sm-12 image-column">
            <div className="image_block_one">
              <div className="image-box">
                <div
                  className="shape float-bob-x"
                  style={{
                    backgroundImage: "url(assets/images/shape/shape-7.png)",
                  }}
                ></div>
                <figure className="image">
                  <img src="assets/images/resource/about1.png" alt="" />
                </figure>
                <div className="icon-one">
                  <i className="icon-13"></i>
                </div>
                <div className="icon-two">
                  <i className="icon-14"></i>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-6 col-md-12 col-sm-12 content-column">
            <div className="content_block_one">
              <div className="content-box">
                <div className="sec-title">
                  <span className="sub-title">THÔNG SỐ SẢN PHẨM</span>
                </div>
                <div className="text-box mb_40">
                  <h6>Cerconia - Kiệt tác DÒNG SỨ ĐIÊU KHẮC VỚI SỰ HOÀN MỸ</h6>
                  <ul className="list-style-one clearfix">
                    <li>Độ cứng: 750 - 1200 MPa</li>
                    <li>Độ bền uốn: 1200 Mpa</li>
                    <li>Độ đàn hồi: 210 GPA</li>
                    <li>Độ mỏng: 0,3mm - 0,5mm</li>
                    <li>Nhiệt độ nung: 1500°C</li>
                    <li>Độ trong mờ: 49%</li>
                    <li>Màu sắc: trắng sáng, độ bóng như răng thật </li>
                    <li>
                      Hiệu ứng màu: đa dạng tông màu và gồm 16 tone màu Vita
                    </li>
                    <li>Chế độ bảo hành: 10 năm</li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
