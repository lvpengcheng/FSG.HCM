<template>
  <div
    ref="node"
    :style="nodeContainerStyle"
    @click="clickNode"
    @mouseup="changeNodeSite"
    :class="nodeContainerClass"
  >
    <!-- 最左侧的那条竖线 -->
    <div class="ef-node-left"></div>
    <!-- 节点类型的图标 -->
    <div class="ef-node-left-ico flow-node-drag">
        <RetweetOutlined :class="{'flow-node-drag': this.node.viewOnly ? false : true}" />
    </div>
    <div class="flow-node-drag drag-line"></div>
    <!-- 节点名称 -->
    <div class="ef-node-text" :show-overflow-tooltip="true">
      {{ node.name }}
    </div>
    <!-- 节点状态图标 -->
    <div class="ef-node-right-ico">
      <CheckCircleTwoTone class="a-node-state-success" two-tone-color="#52c41a"  v-show="node.state === 'success'" />
      <ExclamationCircleOutlined class="a-node-state-warning" two-tone-color="#eb2f96" v-show="node.state === 'warning'" />
      <CloseCircleOutlined  class="a-node-state-error" two-tone-color="#eb2f96" v-show="node.state === 'error'" />
      <LoadingOutlined  class="a-node-state-running" v-show="node.state === 'running'" />
    </div>
  </div>
</template>

<script>
import { $on, $off, $once, $emit } from '../../utils/gogocodeTransfer'
import { 
  CheckCircleTwoTone,
  ExclamationCircleOutlined,
  CloseCircleOutlined,
  LoadingOutlined,
  RetweetOutlined
 } from '@ant-design/icons-vue'
export default {
  props: {
    node: Object,
    activeElement: Object,
  },
  components: {
    CheckCircleTwoTone,
    ExclamationCircleOutlined,
    CloseCircleOutlined,
    LoadingOutlined,
    RetweetOutlined
  },
  computed: {
    nodeContainerClass() {
      return {
        'ef-node-container': true,
        'ef-node-active':
          this.activeElement.type == 'node'
            ? this.activeElement.nodeId === this.node.id
            : false,
      }
    },
    // 节点容器样式
    nodeContainerStyle() {
      return {
        top: this.node.top,
        left: this.node.left,
      }
    }
  },
  methods: {
    // 点击节点
    clickNode() {
      $emit(this, 'clickNode', this.node.id)
    },
    // 鼠标移动后抬起
    changeNodeSite() {
      // 避免抖动
      if (
        this.node.left == this.$refs.node.style.left &&
        this.node.top == this.$refs.node.style.top
      ) {
        return
      }
      $emit(this, 'changeNodeSite', {
        nodeId: this.node.id,
        left: this.$refs.node.style.left,
        top: this.$refs.node.style.top,
      })
    },
  },
  emits: ['clickNode', 'changeNodeSite'],
}
</script>
