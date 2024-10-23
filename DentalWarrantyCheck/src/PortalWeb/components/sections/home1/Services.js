import Link from "next/link";
import React from "react";

export default function service() {
  return (
    <section className="service-section sec-pad">
      <div className="auto-container">
        <div className="sec-title mb_50 centred">
          <span className="sub-title">CÂU CHUYỆN SẢN PHẨM</span>
          <h2>Cerconia: Mỏng Nhẹ - Bền Đẹp - An Toàn Tuyệt Đối </h2>
        </div>
        <div className="row clearfix">
          <div className="col-lg-4 col-md-6 col-sm-12 service-block">
            <div
              className="service-block-one wow fadeInUp animated"
              data-wow-delay="00ms"
              data-wow-duration="1500ms"
            >
              <div className="inner-box">
                <div className="image-box">
                  <figure className="image">
                    <Link href="/">
                      <img src="assets/images/service/02.jpg" alt="" />
                    </Link>
                  </figure>
                  <div className="icon-box img-box">
                    <img src="assets/images/icons/whychoose.png" alt="" />
                  </div>
                </div>
                <div className="lower-content">
                  <h3>
                    <Link href="/">Cam kết nguồn gốc rõ ràng</Link>
                  </h3>
                  <p>
                    Thuộc dòng răng toàn sứ và được cấu tạo gồm hai phần, trong
                    đó kết cấu khung sườn chế tác từ Zirconium dioxit có độ dày
                    chỉ khoảng 0,5mm giúp hạn chế tối đa việc mài răng. Đồng
                    thời, sườn được làm từ Zirconia trắng nên có màu sắc giống
                    như men răng thật, mang đến độ thẩm mỹ cao cho hàm răng.{" "}
                  </p>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-4 col-md-6 col-sm-12 service-block">
            <div
              className="service-block-one wow fadeInUp animated"
              data-wow-delay="300ms"
              data-wow-duration="1500ms"
            >
              <div className="inner-box">
                <div className="image-box">
                  <figure className="image">
                    <Link href="service-details-6">
                      <img src="assets/images/service/1.jpg" alt="" />
                    </Link>
                  </figure>
                  <div className="icon-box img-box">
                    <img src="assets/images/icons/whychoose4.png" alt="" />
                  </div>
                </div>
                <div className="lower-content">
                  <h3>
                    <Link href="/">Quy trình sản xuất hiện đại</Link>
                  </h3>
                  <p>
                    Được chế tác bằng công nghệ CAD/CAM hiện đại nhất hiện nay.
                    Nhờ công nghệ này, răng sứ Cerconia đáp ứng tốt về mặt chức
                    năng ăn nhai, độ bền chắc chắn, tính thẩm mỹ cao và hoàn
                    toàn khắc phục được các khuyết điểm của răng sứ kim loại
                    như: không đen viền nướu, không đổi màu răng khi sử dụng, độ
                    tương hợp sinh học tốt không gây kích ứng nướu.
                  </p>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-4 col-md-6 col-sm-12 service-block">
            <div
              className="service-block-one wow fadeInUp animated"
              data-wow-delay="600ms"
              data-wow-duration="1500ms"
            >
              <div className="inner-box">
                <div className="image-box">
                  <figure className="image">
                    <Link href="service-details">
                      <img src="assets/images/service/3.jpg" alt="" />
                    </Link>
                  </figure>
                  <div className="icon-box img-box">
                    <img src="assets/images/icons/whychoose2.png" alt="" />
                  </div>
                </div>
                <div className="lower-content">
                  <h3>
                    <Link href="service-details">Trắng sáng với thời gian</Link>
                  </h3>
                  <p>
                    Là một dòng răng sứ vừa đảm bảo độ cứng vượt trội với độ
                    trắng sáng và độ trong mờ hoàn hảo, vừa đảm bảo tính thẩm mỹ
                    cao cấp. Răng sứ được nung liên tục ở 1500°C giúp tăng độ
                    bền cho chủ nhân. Ngoài ra, sản phẩn được làm từ Ziconia đem
                    tới hàm răng trắng sáng tự nhiên, tinh tế từng góc cạnh.
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
