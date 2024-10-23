import Link from "next/link";

export default function Footer1() {
  return (
    <>
      <footer className="main-footer" id="footer">
        <div className="pattern-layer">
          <div
            className="pattern-1"
            style={{ backgroundImage: "url(assets/images/shape/shape-23.png)" }}
          ></div>
          <div
            className="pattern-2"
            style={{ backgroundImage: "url(assets/images/shape/shape-24.png)" }}
          ></div>
          <div
            className="pattern-3"
            style={{ backgroundImage: "url(assets/images/shape/shape-25.png)" }}
          ></div>
          <div className="pattern-4"></div>
        </div>
        <div className="widget-section pt_120 pb_100">
          <div className="auto-container">
            <div className="row clearfix">
              <div className="col-lg-3 col-md-6 col-sm-12 footer-column">
                <div className="footer-widget logo-widget">
                  <figure className="footer-logo">
                    <Link href="/">
                      <img src="assets/images/logo-2.png" alt="" />
                    </Link>
                  </figure>
                  <p>
                    Dòng sứ cao cấp cứng nhất thế giới, đường nét tự nhiên, tính
                    tương thích sinh học tuyệt đối, tính thẩm mỹ vượt trội.
                  </p>
                </div>
              </div>
              <div className="col-lg-3 col-md-6 col-sm-12 footer-column">
                <div className="footer-widget links-widget ml_110">
                  <div className="widget-title"></div>
                  <div className="widget-content">
                    <ul className="links-list clearfix"></ul>
                  </div>
                </div>
              </div>

              <div className="col-lg-3 col-md-6 col-sm-12 footer-column">
                <div className="footer-widget contact-widget">
                  <div className="widget-title">
                    <h3>Liên hệ</h3>
                  </div>
                  <div className="widget-content">
                    <ul className="info-list">
                      <li>
                        <img src="assets/images/icons/icon-1.png" alt="" />
                        143 Vũ Tông Phan, Thanh Xuân, Hà Nội
                      </li>
                      <li>
                        <i className="icon-2"></i>
                        <Link href="tel:01989526503">0944 66 6363</Link>
                      </li>
                      <li>
                        <i className="icon-26"></i>
                        <Link href="mailto:LavieDental@gmail.com">
                          LavieDental@gmail.com
                        </Link>
                      </li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div className="footer-bottom">
          <div className="auto-container">
            <div className="bottom-inner">
              <div className="copyright">
                <p>&copy; 2024 copyright by Cercoinia</p>
              </div>
            </div>
          </div>
        </div>
      </footer>
    </>
  );
}
