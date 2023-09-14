<template>
  <a-modal footer title="流程数据信息" v-model:visible="dialogVisible" width="70%">
    <a-alert
      title="使用说明"
      type="warning"
      description="以下流程信息可以被存储起来，方便下一次流程加载"
      show-icon
      close-text="知道了"
    >
    </a-alert>
    <br />
    <!--一个高亮显示的插件-->
    <codemirror
      v-model="flowJsonData"
      :options="options"
      class="code"
    ></codemirror>
  </a-modal>
</template>

<script>
// import 'codemirror/lib/codemirror.css'
import { Codemirror } from 'vue-codemirror'
import { Modal, Alert } from "ant-design-vue";
// require("codemirror/mode/javascript/javascript.js")

export default {
  props: {
    data: Object,
  },
  data() {
    return {
      dialogVisible: false,
      flowJsonData: {},
      options: {
        mode: { name: 'javascript', json: true },
        lineNumbers: true,
      },
    }
  },
  components: {
    Codemirror,
    "a-modal": Modal,
    "a-alert": Alert
  },
  methods: {
    init() {
      this.dialogVisible = true
      this.flowJsonData = JSON.stringify(this.data, null, 4).toString()
    },
  },
}
</script>
