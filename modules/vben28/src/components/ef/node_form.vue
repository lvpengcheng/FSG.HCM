<template>
  <div>
    <div class="ef-node-form">
      <div class="ef-node-form-header">编辑</div>
      <div class="ef-node-form-body">
        <a-form
          :model="node"
          ref="dataForm"
          label-width="80px"
          :label-col="labelCol"
          :wrapper-col="wrapperCol"
          v-show="type === 'node'"
        >
          <a-form-item label="类型">
            <a-input v-model:value="node.type" :disabled="true"></a-input>
          </a-form-item>
          <a-form-item label="名称">
            <a-input v-model:value="node.name"></a-input>
          </a-form-item>
          <a-form-item label="left坐标">
            <a-input v-model:value="node.left" :disabled="true"></a-input>
          </a-form-item>
          <a-form-item label="top坐标">
            <a-input v-model:value="node.top" :disabled="true"></a-input>
          </a-form-item>
          <!-- <a-form-item label="ico图标">
            <a-input v-model:value="node.ico"></a-input>
          </a-form-item> -->
          <a-form-item label="状态">
            <a-select v-model:value="node.state" placeholder="请选择">
              <a-select-option
                v-for="item in stateList"
                :key="item.state"
                :value="item.state"
              >
              {{ item.label }}
              </a-select-option>
            </a-select>
          </a-form-item>
          <a-form-item class="ef-form-btn-box">
            <a-button class="ef-form-btn">
              <CloseOutlined />
               重置
            </a-button>
            <a-button class="ef-form-btn" type="primary" @click="save">
              <CheckOutlined />
               保存
            </a-button>
          </a-form-item>
        </a-form>

        <a-form
          :model="line"
          ref="dataForm"
          label-width="80px"
          v-show="type === 'line'"
        >
          <a-form-item label="条件">
            <a-input v-model:value="line.label"></a-input>
          </a-form-item>
          <a-form-item class="ef-form-btn-box">
            <a-button class="ef-form-btn">
              <CloseOutlined />
              重置
            </a-button>
            <a-button class="ef-form-btn" type="primary" ghost @click="saveLine">
              <CheckOutlined />
              保存
            </a-button>
          </a-form-item>
        </a-form>
      </div>
      <div class="el-node-form-tag"></div>
    </div>
  </div>
</template>

<script>
import { $on, $off, $once, $emit } from '../../utils/gogocodeTransfer'
import { cloneDeep } from 'lodash'
import { Form, Input, Select, Button, FormItem, SelectOption } from "ant-design-vue";
import { 
  CloseOutlined,
  CheckOutlined,
 } from '@ant-design/icons-vue'

export default {
  data() {
    return {
      visible: true,
      // node 或 line
      type: 'node',
      node: {},
      line: {},
      data: {},
      labelCol: { style: { width: '80px' } },
      wrapperCol: { span: 14 },
      stateList: [
        {
          state: 'success',
          label: '成功',
        },
        {
          state: 'warning',
          label: '警告',
        },
        {
          state: 'error',
          label: '错误',
        },
        {
          state: 'running',
          label: '运行中',
        },
      ],
    }
  },
  components: {
    CloseOutlined,
    CheckOutlined,
    "a-form": Form,
    "a-input": Input,
    "a-select": Select,
    "a-button": Button,
    "a-form-item": FormItem,
    "a-select-option": SelectOption,
  },
  methods: {
    /**
     * 表单修改，这里可以根据传入的ID进行业务信息获取
     * @param data
     * @param id
     */
    nodeInit(data, id) {
      this.type = 'node'
      this.data = data
      data.nodeList.filter((node) => {
        if (node.id === id) {
          this.node = cloneDeep(node)
        }
      })
    },
    lineInit(line) {
      this.type = 'line'
      this.line = line
    },
    // 修改连线
    saveLine() {
      $emit(this, 'setLineLabel', this.line.from, this.line.to, this.line.label)
    },
    save() {
      this.data.nodeList.filter((node) => {
        if (node.id === this.node.id) {
          node.name = this.node.name
          node.left = this.node.left
          node.top = this.node.top
          node.ico = this.node.ico
          node.state = this.node.state
          $emit(this, 'repaintEverything')
        }
      })
    },
  },
  emits: ['setLineLabel', 'repaintEverything'],
}
</script>

<style>
.a-node-form-tag {
  position: absolute;
  top: 50%;
  margin-left: -15px;
  height: 40px;
  width: 15px;
  background-color: #fbfbfb;
  border: 1px solid rgb(220, 227, 232);
  border-right: none;
  z-index: 0;
}
</style>
