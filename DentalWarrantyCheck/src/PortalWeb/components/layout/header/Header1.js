"use client";
import Link from "next/link";
import Menu from "../Menu";
import MobileMenu from "../MobileMenu";

export default function Header1({
  scroll,
  isMobileMenu,
  handleMobileMenu,
  isSidebar,
  handlePopup,
  handleSidebar,
}) {
  return (
    <>
      <header className={`main-header ${scroll ? "fixed-header" : ""}`}>
        {/* Header Top */}
        <div className="header-top">
          <div className="auto-container">
            <div className="top-inner">
              <ul className="info-list clearfix">
                {/* <li>
                  <i className="icon-1"></i>Mon - Fri 8:00 - 18:00 / Sunday 8:00
                  - 14:00
                </li>
                <li>
                  <i className="icon-2"></i>Email:{" "}
                  <Link href="tel:01989526503">0198-9526503</Link>
                </li>
                <li>
                  <img src="assets/images/icons/icon-1.png" alt="" /> Kiểm tra
                  nguồn gốc
                </li> */}
              </ul>
              <ul className="social-links clearfix">
                <li>
                  <i
                    style={{ color: "white", marginRight: "10px" }}
                    className="icon-8"
                  ></i>
                  <span style={{ color: "white" }}>Kiểm tra nguồn gốc</span>
                </li>
              </ul>
            </div>
          </div>
        </div>

        {/* Header Upper */}
        <div className="header-lower">
          <div className="outer-container">
            <div className="auto-container">
              <div className="outer-box">
                <div className="logo-box">
                  <figure className="logo">
                    <Link href="/">
                      <img src="assets/images/logo.png" alt="" />
                    </Link>
                  </figure>
                </div>
                <div className="menu-area">
                  {/* <div
                    className="mobile-nav-toggler"
                    onClick={handleMobileMenu}
                  >
                    <i className="icon-bar"></i>
                    <i className="icon-bar"></i>
                    <i className="icon-bar"></i>
                  </div> */}
                  <nav className="main-menu navbar-expand-md navbar-light clearfix">
                    <div
                      className="collapse navbar-collapse show clearfix"
                      id="navbarSupportedContent"
                    >
                      <Menu />
                    </div>
                  </nav>
                </div>
                <div className="btn-box">
                  <Link href="/tra-cuu-bao-hanh" className="theme-btn btn-one font-size-mb">
                    <span>Tra cứu bảo hành</span>
                  </Link>
                </div>
              </div>
            </div>
          </div>
        </div>

        {/* Sticky Header  */}
        <div className="sticky-header">
          <div className="auto-container">
            <div className="outer-box">
              <div className="logo-box">
                <figure className="logo">
                  <Link href="/">
                    <img src="assets/images/logo.png" alt="" />
                  </Link>
                </figure>
              </div>

              <nav className="main-menu navbar-expand-md navbar-light clearfix">
                <div
                  className="collapse navbar-collapse show clearfix"
                  id="navbarSupportedContent"
                >
                  <Menu />
                </div>
              </nav>
              <ul className="menu-right-content">
                <div className="btn-box">
                  <Link href="/tra-cuu-bao-hanh" className="theme-btn btn-one">
                    <span>Tra cứu bảo hành</span>
                  </Link>
                </div>
              </ul>
            </div>
          </div>
        </div>
        {/* End Sticky Menu */}
        {/* Mobile Menu  */}

        <MobileMenu handleMobileMenu={handleMobileMenu} />
      </header>
    </>
  );
}
