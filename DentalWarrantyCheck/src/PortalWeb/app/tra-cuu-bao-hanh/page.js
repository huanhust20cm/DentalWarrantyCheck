"use client";
import Layout from "@/components/layout/Layout";
import ModalSearch from "@/components/modal/modalSearch";
import About1 from "@/components/sections/home1/About1";
import service from "@/services/apis";
import { Button, Form, Input, Spin } from "antd";
import { useState } from "react";

export default function Home() {
  const [isOpen, setOpen] = useState(false);
  const [isSpin, setShowSpin] = useState(false);
  const [dataSearch, setDataSearch] = useState();
  const [form] = Form.useForm();

  const onFinish = async (values) => {
    setShowSpin(true);
    try {
      const model = { ...values };
      const { data } = await service.dental.searchnumbercard(model);
      if (data) {
        setOpen(true);
        setDataSearch(data);
      }
    } catch (error) {
      console.error(error);
    } finally {
      setShowSpin(false);
    }
  };

  return (
    <Spin spinning={isSpin} tip="Loading..." size="large">
      <Layout
        headerStyle={2}
        footerStyle={1}
        breadcrumbTitle="Tra cứu bảo hành"
      >
        <ModalSearch open={isOpen} setOpen={setOpen} dataSearch={dataSearch} />
        <section className="process-section sec-pad bg-color-1">
          <div className="process-section-block">
            <div className="process-section-block-one">
              <img src="assets/images/banner/smartcard.png" alt="" />
            </div>
            <div className="process-section-block-one">
              <img src="assets/images/banner/smartcard2.png" alt="" />
            </div>
          </div>
          <div className="align-2 flexbox_1 p_20 mwp_100">
            <div className="align-2 flexbox_1 p_20 wp_50 wpmb_100">
              <Form
                size="large"
                layout="vertical"
                onFinish={onFinish}
                form={form}
                className="wp_100"
              >
                <Form.Item
                  name="numberCard"
                  rules={[
                    {
                      required: true,
                      message: "Vui lòng điền Mã số thẻ!",
                    },
                  ]}
                  required
                  label="Mã số thẻ"
                >
                  <Input required placeholder="Mã số thẻ"></Input>
                </Form.Item>
                <Form.Item
                  rules={[
                    {
                      required: true,
                      message: "Vui lòng điền năm sinh",
                    },
                  ]}
                  name="dateOfBirth"
                  required
                  label="Năm sinh"
                >
                  <Input required placeholder="Năm sinh"></Input>
                </Form.Item>
              </Form>
              <Button
                style={{ height: "3rem" }}
                className="theme-btn btn-one"
                onClick={() => {
                  form.submit();
                }}
              >
                <span className="px_24"> Tra cứu bảo hành</span>
              </Button>
              {dataSearch && (
                <Button
                  style={{ height: "3rem" }}
                  className="theme-btn btn-two"
                  onClick={() => setOpen(true)}
                >
                  <span className="px_24"> Xem bảng tra cứu</span>
                </Button>
              )}
            </div>
          </div>
        </section>
        <About1 />
        <section className="about-style-two pt_120 pb_120">
          <div className="pattern-layer pdt_10">
            <div
              className="pattern-1 rotate-me"
              style={{
                backgroundImage: "url(assets/images/shape/shape-8.png)",
              }}
            ></div>
            <div
              className="pattern-2 rotate-me"
              style={{
                backgroundImage: "url(assets/images/shape/shape-9.png)",
              }}
            ></div>
            <div
              className="pattern-3"
              style={{
                backgroundImage: "url(assets/images/shape/shape-11.png)",
              }}
            ></div>
            <div
              className="pattern-4"
              style={{
                backgroundImage: "url(assets/images/shape/shape-35.png)",
              }}
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
                    <div
                      className="image-shape"
                      style={{
                        backgroundImage:
                          "url(assets/images/shape/shape-26.png)",
                      }}
                    ></div>
                    <figure className="image-2">
                      <img src="assets/images/resource/about2.jpg" alt="" />
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
                  <div className="content-box ml_30">
                    <div className="sec-title mb_15">
                      {/* <span className="sub-title">About Us</span> */}
                      <h3 className="text-box mb_40">
                        Một Số Lưu Ý Khi Sử Dụng Phục Hình Cercon
                      </h3>
                    </div>
                    <div className="text-box mb_40">
                      <ul className="list-style-one clearfix">
                        <li>
                          Sau khi gắn phục hình bạn cần thời gian để quen với
                          phục hình mới, răng và nướu có thể nhạy cảm vài ngày
                          đầu khi mang phục hình.
                        </li>
                        <li>
                          Cũng như răng thật bạn nên bảo vệ phục hình bằng cách
                          không dùng răng cắn hoặc thức ăn quá cứng (xương, nước
                          đá...). Bạn nên tránh dùng thức ăn quá nóng hay quá
                          lạnh. Súc miệng bằng nước muối ấm có thể mang lại cảm
                          giác dễ chịu hơn.
                        </li>
                        <li>
                          Giữ vệ sinh răng miệng sau khi ăn, luôn chải răng,
                          dùng chỉ nha khoa nếu cần để bảo vệ nướu và phần răng
                          thật bên dưới phục hình.
                        </li>
                        <li>
                          Nếu phục hình không thăng bằng khi ăn nhai bạn nên
                          liên hệ bác sĩ điều trị.
                        </li>
                      </ul>
                    </div>
                    <div className="lower-box">
                      <figure className="author-thumb">
                        <img src="assets/images/resource/author-1.jpg" alt="" />
                      </figure>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>
      </Layout>
    </Spin>
  );
}
