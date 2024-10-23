import React from "react";
import Link from "next/link";
export default function News() {
  return (
    <section className="news-section sec-pad bg-color-1">
      <div className="auto-container">
        <div className="sec-title mb_50 centred">
          <span className="sub-title">
            Vì sao nên chọn thẩm mỹ răng sứ Cerconia
          </span>
        </div>
        <div className="row clearfix">
          <div className="col-lg-4 col-md-6 col-sm-12 news-block">
            <div
              className="news-block-one wow fadeInUp animated"
              data-wow-delay="00ms"
              data-wow-duration="1500ms"
            >
              <div className="inner-box">
                <figure className="image-box">
                  <Link href="blog-details">
                    <img src="assets/images/news/protect1.jpg" alt="" />
                  </Link>
                </figure>
                <div className="lower-content">
                  <h3>
                    <Link href="/">Bảo vệ và ngăn ngừa bệnh lý răng miệng</Link>
                  </h3>
                  <p>
                    Với những trường hợp răng gốc yếu kém, hay bị ê buốt thì một
                    lớp sứ Cerconia bên ngoài cùi răng sẽ như chiếc áo giáp bảo
                    vệ răng gốc khỏi các tác động bên ngoài.
                  </p>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-4 col-md-6 col-sm-12 news-block">
            <div
              className="news-block-one wow fadeInUp animated"
              data-wow-delay="300ms"
              data-wow-duration="1500ms"
            >
              <div className="inner-box">
                <figure className="image-box">
                  <Link href="blog-details">
                    <img src="assets/images/news/protect0.jpg" alt="" />
                  </Link>
                </figure>
                <div className="lower-content">
                  <h3>
                    <Link href="/">Vệ sinh dễ dàng</Link>
                  </h3>
                  <p>
                    Khách hàng sau khi thẩm mỹ răng sứ Cerconia đều cảm thấy
                    việc vệ sinh răng miệng hàng ngày trở nên dễ dàng hơn và khi
                    ăn uống không bị bám màu thực phẩm do ngoài răng sứ luôn
                    được đáp 1 lớp màng láng bóng.
                  </p>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-4 col-md-6 col-sm-12 news-block">
            <div
              className="news-block-one wow fadeInUp animated"
              data-wow-delay="600ms"
              data-wow-duration="1500ms"
            >
              <div className="inner-box">
                <figure className="image-box">
                  <Link href="blog-details">
                    <img src="assets/images/news/protect2.jpg" alt="" />
                  </Link>
                </figure>
                <div className="lower-content">
                  <h3>
                    <Link href="/">Ăn nhai thoái mái như răng thật</Link>
                  </h3>
                  <p>
                    Sở hữu độ cứng và khả năng chịu lực vượt trội gấp 5 lần răng
                    thật, răng sứu Cerconia giúp khách hàng có thể thưởng thức
                    bất kỳ món ăn khoái khẩu một cách trọn vẹn nhất.
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
