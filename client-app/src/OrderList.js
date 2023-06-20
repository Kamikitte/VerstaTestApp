import React, { useState } from 'react';
import { List, Modal, Pagination } from 'antd';
import OrderDetails from './OrderDetails';

const OrderList = ({ orders }) => {
  const [selectedOrder, setSelectedOrder] = useState(null);
  const [currentPage, setCurrentPage] = useState(1);
  const pageSize = 2;

  const handleOrderClick = (order) => {
    setSelectedOrder(order);
  };

  const handleModalClose = () => {
    setSelectedOrder(null);
  };

  const handlePageChange = (page) => {
    setCurrentPage(page);
  };

  const fieldNames = {
    id: 'Номер заказа',
    senderCity: 'Город отправителя',
    senderAddress: 'Адрес отправителя',
    recipientCity: 'Город получателя',
    recipientAddress: 'Адрес получателя',
    weight: 'Вес груза',
    takeDate: 'Дата забора груза'
  };

  const displayedOrders = orders.slice((currentPage - 1) * pageSize, currentPage * pageSize);

  return (
    <div>
      <h2>Список заказов</h2>
      <List 
        dataSource={displayedOrders} 
        renderItem={(order) => ( 
          <List.Item onClick={() => handleOrderClick(order)}> 
            <List.Item.Meta 
              title={`Номер заказа: ${order.id}`} 
              description={
                <div>
                  {Object.entries(order).map(([key, value]) => (
                    <div key={key}>
                    {`${fieldNames[key]}: ${value}`}
                    </div>
                  ))}
                </div>
              } 
            /> 
          </List.Item> 
        )} 
      />
      <Pagination
        simple
        current={currentPage}
        total={orders.length}
        pageSize={pageSize}
        onChange={handlePageChange}
      />
      <Modal
        title="Детали заказа"
        open={selectedOrder}
        onCancel={handleModalClose}
        footer={null}
      >
        {selectedOrder && <OrderDetails order={selectedOrder} />}
      </Modal>
    </div>
  );
};

export default OrderList;

