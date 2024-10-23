import React from "react";
import Link from "next/link";
export default function subscribe() {
  return (
    <section className="subscribe-section bg-color-1">
      <div className="auto-container">
        <div className="inner-container">
          <div className="row align-items-center">
            <div className="col-lg-6 col-md-12 col-sm-12 text-column">
              <div className="text-box">
                <h2>
                  <span>Tra cứu</span> bảo hành răng sứ Cerconia
                </h2>
              </div>
            </div>
            <div className="col-lg-6 col-md-12 col-sm-12 form-column">
              <div className="form-inner">
                <form method="post">
                  <div className="form-group">
                    <input
                      type="input"
                      name="email"
                      placeholder="Mã số thẻ"
                      required
                    />
                    <button type="submit" className="theme-btn btn-one">
                      <span>Tra cứu bảo hành</span>
                    </button>
                  </div>
                  <div className="form-group">
                    <div className="check-box">
                      <input className="check" type="checkbox" id="checkbox1" />
                      <label htmlFor="checkbox1">
                        Tôi đồng ý với{" "}
                        <Link href="/#">chính sách bảo mật.</Link>
                      </label>
                    </div>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}
