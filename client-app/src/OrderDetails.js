import React from 'react';
import { List } from 'antd';

const OrderDetails = ({ order }) => {
  return (
    <div>
      <List bordered>
        <List.Item>
          <strong>Номер заказа:</strong> {order.id}
        </List.Item>
        <List.Item>
          <strong>Город отправителя:</strong> {order.senderCity}
        </List.Item>
        <List.Item>
          <strong>Адрес отправителя:</strong> {order.senderAddress}
        </List.Item>
        <List.Item>
          <strong>Город получателя:</strong> {order.recipientCity}
        </List.Item>
        <List.Item>
          <strong>Адрес получателя:</strong> {order.recipientAddress}
        </List.Item>
        <List.Item>
          <strong>Вес груза:</strong> {order.weight}
        </List.Item>
        <List.Item>
          <strong>Дата забора груза:</strong> {order.takeDate}
        </List.Item>
      </List>
    </div>
  );
};

export default OrderDetails;
