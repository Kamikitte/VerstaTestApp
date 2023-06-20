import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Button, Modal, Row, Col } from 'antd';
import OrderList from './OrderList';
import OrderForm from './OrderForm';

const App = () => {
  const [isOrderFormVisible, setIsOrderFormVisible] = useState(false);
  const [orders, setOrders] = useState([]);

  useEffect(() => {
    document.title = 'Управление заказами';
    const fetchOrders = async () => {
      try {
        const response = await axios.get('https://localhost:7124/api/Orders');
        const transformedOrders = response.data.map((order) => {
          const dayjs = require('dayjs')
          const transformedOrder = {
            ...order,
            takeDate: dayjs(order.takeDate).format('DD.MM.YYYY')
          };
          return transformedOrder;
        });
        setOrders(transformedOrders);
      } catch (error) {
        console.log(error);
      }
    };
  
    fetchOrders();
  }, []);
  

  const handleAddOrderClick = () => {
    setIsOrderFormVisible(true);
  };

  const handleOrderCreated = (newOrder) => {
    setIsOrderFormVisible(false);
    setOrders((prevOrders) => [...prevOrders, newOrder]);
  };

  return (
    <div style={{ textAlign: 'center' }}>
      <h1>Управление заказами</h1>
      <Button type="primary" onClick={handleAddOrderClick}>
        Создать новый заказ
      </Button>
      <Row justify="center" style={{ marginTop: '20px' }}>
        <Col xs={24} sm={20} md={16} lg={12} xl={8}>
          <OrderList orders={orders} />
        </Col>
      </Row>
      <Modal
        title="Создание нового заказа"
        open={isOrderFormVisible}
        onCancel={() => setIsOrderFormVisible(false)}
        footer={null}
      >
        <OrderForm onOrderCreated={handleOrderCreated} />
      </Modal>
    </div>
  );
};

export default App;
