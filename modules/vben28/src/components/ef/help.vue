<template>
  <a-modal
    title="帮助"
    v-model:visible="dialogVisible"
    width="70%"
    footer
    customClass="flowHelp"
  >
    <a-tabs tab-position="left">
      <a-tab-pane key="1" tab="如何新增">
        <a-divider orientation="left">如何新增</a-divider>
        <div>按住鼠标拖拽左侧组件到中间画布中松开鼠标即可</div>
      </a-tab-pane>
      <a-tab-pane key="2" tab="如何删除">
        <a-divider orientation="left">页面删除</a-divider>
        <div>鼠标点中需要删除的节点，点击左上角的删除图标</div>
        <a-divider orientation="left">通过代码删除</a-divider>
        <pre>this.deleteNode(nodeId)</pre>
      </a-tab-pane>
      <a-tab-pane key="3" tab="如何移动">
        <a-divider orientation="left">如何移动</a-divider>
        <div>
          鼠标移动到节点中，当鼠标变为可拖拽的图标时按下鼠标移动到新的位置松开鼠标
        </div>
      </a-tab-pane>
      <a-tab-pane key="4" tab="如何连线">
        <a-divider orientation="left">如何连线</a-divider>
        <div>
          鼠标移动到节点中左侧的图标上，当鼠标变为+时按下鼠标移动到另一个节点中松开鼠标
        </div>
      </a-tab-pane>
      <a-tab-pane key="5" tab="如何添加条件">
        <a-divider orientation="left">如何添加条件</a-divider>
        <div>
          点击画布中的连线，在页面右侧会出现一个表单，输入新的条件，点击【保存】
        </div>
      </a-tab-pane>
      <a-tab-pane key="6" tab="如何进行后端交互存储">
        <a-divider orientation="left">如何进行后端交互存储</a-divider>
        <div>参考: https://gitee.com/xiaoka2017/easy-flow-sdk</div>
      </a-tab-pane>
    </a-tabs>
  </a-modal>
</template>

<script>
import { Divider, Tabs, Modal, Select } from "ant-design-vue";
export default {
  data() {
    return {
      dialogVisible: false,
    }
  },
  components: {
    "a-divider": Divider,
    "a-tabs": Tabs,
    "a-modal": Modal
  },
  methods: {
    init() {
      this.dialogVisible = true
    },
  },
}
</script>

<style>
.flowHelp {
  height: 80%;
}
</style>
