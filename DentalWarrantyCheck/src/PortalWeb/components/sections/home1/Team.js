import React from "react";
import Link from "next/link";
export default function Team() {
  const teamMembers = [
    {
      id: 1,
      name: "Duy nhất: Miễn phí thiết kế nụ cười Digital Smile Design",
      role: "Là công nghệ chophép tạo hình nụ cười một cách toàn diện, từ hình thể của răng đến màu sắc răng, tương quan giữa răng - xương hàm - môi và nướu. ",
      image: "assets/images/team/01.jpg",
    },
    {
      id: 2,
      name: "Duy nhất: Tặng bộ chăm sóc răng miệng 5.000.000 VNĐ",
      role: "Cho khách hàng khibọc răng sứ Cerconia. Bên cạnh đó, khách hàng sẽ được miễn phí chăm sóc răng miệng cho cả gia đình trong 3 năm. ",
      image: "assets/images/team/02.jpg",
    },
    {
      id: 3,
      name: "Duy nhất: Thẻ bảo hành răng sứ Cerconia chính hãng 10 năm từ nhà sản xuất",
      role: "Đảm bảo quyền lợi cho khách hàng trong trường hợp gặp sự cố với mão sứ do lỗi kỹ thuật trong quá trình thực hiện hoặc chất lượng sản phẩm.",
      image: "assets/images/team/03.jpg",
    },
    {
      id: 4,
      name: "Duy nhất: Miễn phí thăm khám",
      role: "Với bác sĩ chuyên khoa Răng - Hàm - Mặt trên 10 năm kinh nghiệm giúp bạn được gặp gỡ và trò chuyện với Bác sĩ để thảo luận về tình trạng răng miệng và nhận được sự tư vấn chuyên nghiệp.",
      image: "assets/images/team/04.jpg",
    },
  ];

  return (
    <section className="team-section sec-pad centred">
      <div className="pattern-layer">
        <div
          className="pattern-1"
          style={{ backgroundImage: "url(assets/images/shape/shape-13.png)" }}
        ></div>
        <div
          className="pattern-2"
          style={{ backgroundImage: "url(assets/images/shape/shape-14.png)" }}
        ></div>
      </div>
      <div className="shape">
        <div
          className="shape-1 float-bob-y"
          style={{ backgroundImage: "url(assets/images/shape/shape-15.png)" }}
        ></div>
        <div className="shape-2"></div>
        <div
          className="shape-3 float-bob-x"
          style={{ backgroundImage: "url(assets/images/shape/shape-16.png)" }}
        ></div>
      </div>
      <div className="auto-container">
        <div className="sec-title mb_50">
          <h2 style={{ fontSize: 24 }} className="sub-title">
            QUYỀN LỢI KHÁCH HÀNG
          </h2>
        </div>
        <div className="row clearfix">
          {teamMembers.map((member, index) => (
            <div
              key={member.id}
              className="col-lg-3 col-md-6 col-sm-12 team-block"
            >
              <div
                className="team-block-one wow fadeInUp animated"
                data-wow-delay={`${index * 200}ms`}
                data-wow-duration="1500ms"
              >
                <div className="inner-box">
                  <div className="image-box">
                    <figure className="image">
                      <img src={member.image} alt={`${member.name}'s photo`} />
                    </figure>
                  </div>
                  <div className="lower-content">
                    <h3>{member.name}</h3>
                    <span className="designation">{member.role}</span>
                  </div>
                </div>
              </div>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
}
