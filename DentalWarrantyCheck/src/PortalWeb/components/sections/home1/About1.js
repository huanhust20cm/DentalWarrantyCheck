import Link from "next/link";

export default function About1() {
  return (
    <section className="about-section pt_120 pb_120">
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
          <div className="col-lg-6 col-md-12 col-sm-12 content-column">
            <div className="content_block_one">
              <div className="content-box ml_30">
                <div className="sec-title mb_15">
                  <span className="sub-title">Chi tiết</span>
                  {/* <h2>Medical services & diagnostics</h2> */}
                </div>
                <div className="text-box mb_40">
                  <ul className="list-style-one clearfix">
                    <li>
                      Phục hình Cerconia được sản xuất bằng vật liệu chính hãng
                      nhập khẩu bởi Công ty TNHH Dentsply Sirona Việt Nam.
                    </li>
                    <li>
                      Khách hàng sử dụng phục hình Cerconia đúng với hướng dẫn
                      của bác sĩ điều trị.
                    </li>
                    <li>
                      Bác sĩ điều trị và Labo nha khoa chịu trách nhiệm thực
                      hiện và bảo hành 10 năm (*) để đảm bảo tính thẩm mỹ, chức
                      năng của phục hình.
                    </li>
                    <li>
                      (*) Theo nghiên cứu công bố trên tạp chí nha khoa vào năm
                      2018 đính kèm{" "}
                      <Link href="https://dentsplysirona.com.vn/nicEditor/nicImages/10-year%20randomized%20trial%20(RCT).pdf">
                        tại đây.
                      </Link>
                    </li>
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
