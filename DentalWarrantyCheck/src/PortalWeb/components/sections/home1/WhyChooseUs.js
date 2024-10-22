
export default function chooseus() {
  return (
    <section className="chooseus-section">
      <div
        className="bg-layer"
        style={{
          backgroundImage: "url(assets/images/background/chooseus-bg.jpg)",
        }}
      ></div>
      <div
        className="pattern-layer"
        style={{ backgroundImage: "url(assets/images/shape/shape-12.png)" }}
      ></div>
      <div className="auto-container">
        <div className="row clearfix">
          <div className="col-lg-8 col-md-12 col-sm-12 content-column">
            <div className="content-box">
              <div className="sec-title light mb_50">
                <span className="sub-title"> Ưu điểm</span>
                <h2>
                  Vượt trội của răng sứ <br />
                  Cerconia
                </h2>
              </div>
              <div className="row clearfix">
                <div className="col-lg-6 col-md-6 col-sm-12 chooseus-block">
                  <div className="chooseus-block-one">
                    <div className="inner-box">
                      <div className="icon-box">
                        <i className="icon-18"></i>
                      </div>
                      <h3>Thẩm mỹ hoàn hảo</h3>
                      <p>
                        Độ trong mờ cao (49%), màu sắc trung thực, tự nhiên nhờ
                        công nghệ True Color.
                      </p>
                    </div>
                  </div>
                </div>
                <div className="col-lg-6 col-md-6 col-sm-12 chooseus-block">
                  <div className="chooseus-block-one">
                    <div className="inner-box">
                      <div className="icon-box">
                        <i className="icon-21"></i>
                      </div>
                      <h3>Bền bỉ vượt trội</h3>
                      <p>
                        Độ chịu lực đến 2200 Mpa và độ bền lực uốn cong lên tới
                        1200 Mpa - Đạt tiêu chuẩn ISO 6782
                      </p>
                    </div>
                  </div>
                </div>
                <div className="col-lg-6 col-md-6 col-sm-12 chooseus-block">
                  <div className="chooseus-block-one">
                    <div className="inner-box">
                      <div className="icon-box">
                        <i className="icon-19"></i>
                      </div>
                      <h3>Bảo tồn răng thật</h3>
                      <p>
                        Thành phục hình chỉ khoảng 0,5 mm cho phép mài ít mô
                        răng hơn
                      </p>
                    </div>
                  </div>
                </div>
                <div className="col-lg-6 col-md-6 col-sm-12 chooseus-block">
                  <div className="chooseus-block-one">
                    <div className="inner-box">
                      <div className="icon-box">
                        <i className="icon-20"></i>
                      </div>
                      <h3>Hoàn toàn lành tính</h3>
                      <p>
                        Tương thích sinh học tốt, không gây đen viền nướu, nhiễm
                        màu sau thời gian dài.
                      </p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
