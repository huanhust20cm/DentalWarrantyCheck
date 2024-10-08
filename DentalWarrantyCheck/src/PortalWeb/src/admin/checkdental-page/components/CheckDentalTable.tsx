import { DeleteOutlined, EditOutlined, SmileOutlined } from '@ant-design/icons';
import { Button, Popconfirm, Table, Tooltip } from 'antd';
import type { ColumnsType } from 'antd/es/table';
import Paragraph from 'antd/es/typography/Paragraph';
import dayjs from 'dayjs';
import { IPaginationProps } from '../CheckDental.model';
import styles from './CheckDental.module.scss';
// import MoreImage from '@/common/components/more-image/MoreImage';

interface IProp {
  list: A[];
  pagination: IPaginationProps;
  setPage: (page: number) => void;
  handleDelete: () => void;
}

const DentalTable = (props: IProp) => {
  const { list, pagination, setPage, handleDelete } = props;

  const columns: ColumnsType<A> = [
    {
      title: 'Số thẻ',
      dataIndex: 'cardNo',
      key: 'cardNo',
      className: `tableColumns`,
      render: (_, record) => {
        return <Paragraph className={`${styles.paragraph} cardNo`}>{record.cardNo}</Paragraph>;
      }
    },
    {
      title: 'Họ và tên',
      dataIndex: 'fullname',
      key: 'fullname',
      className: `tableColumns`,
      render: (_, record) => {
        return (
          <>
            <Tooltip placement="topLeft" title={<div className="customTooltip">{_}</div>} color="#ffffff" arrow={true}>
              <Paragraph className={`${styles.paragraph} fullName`} ellipsis={{ rows: 2, expandable: false }}>
                {record.fullname}
              </Paragraph>
            </Tooltip>
            <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
              {dayjs(record.dateofbirth).format('DD/MM/YYYY')}
            </Paragraph>
            <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
              {record.phoneNumber}
            </Paragraph>
          </>
        );
      }
    },
    {
      title: 'Răng sứ',
      dataIndex: 'Ceramictooth',
      key: 'Ceramictooth',
      className: `tableColumns`,
      render: (_, record) => {
        return (
          <>
            <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
              {record.Ceramictooth}
            </Paragraph>
            <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
              {record.color}
            </Paragraph>
          </>
        );
      }
    },
    {
      title: 'Ngày làm',
      dataIndex: 'dentalDay',
      key: 'dentalDay',
      className: `tableColumns`,
      render: (_, record) => {
        return (
          <Tooltip
            placement="topLeft"
            title={<div className="customTooltip">{dayjs(record.dentalDay).format('DD/MM/YYYY')}</div>}
            color="#ffffff"
            arrow={true}
          >
            <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
              {dayjs(record.dentalDay).format('DD/MM/YYYY')}
            </Paragraph>
          </Tooltip>
        );
      }
    },
    {
      title: 'Hạn sử dụng',
      dataIndex: 'guarantee',
      key: 'guarantee',
      className: `tableColumns`,
      render: (_, record) => {
        return (
          <Tooltip placement="topLeft" title={<div className="customTooltip">{_}</div>} color="#ffffff" arrow={true}>
            <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
              {record.guarantee}
            </Paragraph>
          </Tooltip>
        );
      }
    },
    {
      title: 'Labo/LAB',
      dataIndex: 'labolab',
      key: 'labolab',
      className: `tableColumns`,
      render: (_, record) => {
        return (
          <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
            {record.labolab}
          </Paragraph>
        );
      }
    },
    {
      title: 'Nguồn gốc',
      dataIndex: 'origin',
      key: 'origin',
      className: `tableColumns`,
      render: (_, record) => {
        return (
          <Paragraph className={styles.paragraph} ellipsis={{ rows: 2, expandable: false }}>
            {record.origin}
          </Paragraph>
        );
      }
    },
    {
      title: 'Action',
      dataIndex: 'action',
      key: 'action',
      align: 'center',
      fixed: 'right',
      className: `tableColumns ${styles.action}`,
      render: (_, record) => (
        <div className="actionclass" style={{ display: 'flex' }}>
          <Button
            type="text"
            icon={<EditOutlined color="#0E2554" style={{ fontSize: '18px' }} />}
            onClick={() => {
              // handleEdit(record);
            }}
          />
          <Popconfirm
            title="Delete"
            description="Are you sure to delete this record?"
            onConfirm={() => handleDelete()}
            onCancel={() => console.log('')}
            okText="Yes"
            cancelText="No"
          >
            <Button type="text" icon={<DeleteOutlined color="#0E2554" style={{ fontSize: '18px' }} />} />
          </Popconfirm>
        </div>
      )
    }
  ];

  return (
    <Table
      dataSource={list}
      columns={columns}
      pagination={{
        current: pagination?.currentPage,
        pageSize: 10,
        total: pagination?.totalRecordCount,
        simple: true,
        onChange: setPage
      }}
      locale={{
        emptyText: (
          <>
            <SmileOutlined style={{ marginRight: 5 }} /> Không có bài viết nào được hiển thị
          </>
        )
      }}
      rowKey={(record: A) => record.id ?? new Date().getTime()}
      scroll={{ x: 768 }}
      className="dt-border-table "
      rootClassName={styles.tableKnowledgeData}
    />
  );
};

export default DentalTable;
