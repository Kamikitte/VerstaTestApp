import React from 'react';
import axios from 'axios';
import { Form, Input, Button, DatePicker, InputNumber } from 'antd';

// Форма для создания нового заказа
const OrderForm = ({ onOrderCreated }) => {
  const [form] = Form.useForm();

  const handleSubmit = async (values) => {
    try {
      const response = await axios.post('https://localhost:7124/api/Orders', values);
      const dayjs = require('dayjs')
      const modifiedOrder = {
        ...response.data,
        takeDate: dayjs(response.data.takeDate).format('DD.MM.YYYY')
      };
      form.resetFields();
      onOrderCreated(modifiedOrder);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <Form form={form} onFinish={handleSubmit} layout="vertical">
      <Form.Item name="senderCity" label="Город отправителя" rules={[{ required: true, message: 'Введите город отправителя' }]}>
        <Input />
      </Form.Item>
      <Form.Item name="senderAddress" label="Адрес отправителя" rules={[{ required: true, message: 'Введите адрес отправителя' }]}>
        <Input />
      </Form.Item>
      <Form.Item name="recipientCity" label="Город получателя" rules={[{ required: true, message: 'Введите город получателя' }]}>
        <Input />
      </Form.Item>
      <Form.Item name="recipientAddress" label="Адрес получателя" rules={[{ required: true, message: 'Введите адрес получателя' }]}>
        <Input />
      </Form.Item>
      <Form.Item name="weight" label="Вес груза" rules={[{ required: true, message: 'Введите вес груза' }]}>
        <InputNumber min={0} />
      </Form.Item>
      <Form.Item name="takeDate" label="Дата забора груза" rules={[{ required: true, message: 'Введите дату забора груза' }]}>
        <DatePicker format="DD.MM.YYYY" />
      </Form.Item>
      <Form.Item>
        <Button type="primary" htmlType="submit">
          Создать заказ
        </Button>
      </Form.Item>
    </Form>
  );
};

export default OrderForm;
