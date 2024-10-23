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
    <header className={`main-header ${scroll ? "fixed-header" : ""}`}>
      {/* Header Top */}
      <div className="header-top">
        <div className="auto-container">
          <div className="top-inner">
            <ul className="info-list clearfix"></ul>
            <ul className="social-links clearfix">
              <li></li>
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
                    <img src="assets/images/logo-2.png" alt="" />
                  </Link>
                </figure>
              </div>
              <div className="menu-area">
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
                <Link
                  href="/tra-cuu-bao-hanh"
                  className="theme-btn btn-one font-size-mb"
                >
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
                  <img src="assets/images/logo-2.png" alt="" />
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
  );
}
