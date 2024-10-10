import { Button, Col, Modal, Row } from "antd";
import TextItem from "./TexItem";

const ModalSearch = ({ open, setOpen, dataSearch }) => {
  return (
    <Modal open={open} closable={false} className="fullModal" footer={false}>
      <div className="role-header-wrap">
        {/* <img src={LogoURL} alt="Logo" /> */}
      </div>
      <div className="irSignatureWrap">
        <div className="title">Bảng thông tin bảo hành</div>
        <div className="bodya">
          <div className="hcis-flex">
            <div className="avatar">
              {/* <AvatarImage microServiceName="dataSearchprofile" id={dataSearch.id ?? dataSearch.dataSearchId} /> */}
            </div>
            <div className="nameCon">
              <div className="name hcis-two-rows">
                {dataSearch?.name ?? dataSearch?.dataSearchName}
              </div>
              <div className="time">
                {dataSearch?.age ?? dataSearch?.dataSearchAge ?? "N/A"}
              </div>
            </div>
            <div className="level"></div>
          </div>
          <Col>
            <Row>
              <TextItem label="PI Start Date">A</TextItem>
              <TextItem label="PI End Date">A</TextItem>
            </Row>
            <TextItem label="No. of Days on PI">A</TextItem>
          </Col>
          <Row className="action-bottom">
            <Button
              className="bg_red fw_sbold color_light"
              onClick={() => setOpen(false)}
            >
              Đóng lại
            </Button>
          </Row>
        </div>
      </div>
    </Modal>
  );
};

export default ModalSearch;
