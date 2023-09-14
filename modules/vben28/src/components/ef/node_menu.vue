<template>
  <div class="flow-menu" ref="tool">
    <div v-for="menu in menuList" :key="menu.id">
      <span class="ef-node-pmenu" @click="menu.open = !menu.open"
        ><CaretDownOutlined v-if="menu.open" /><CaretRightOutlined v-else />&nbsp;{{ menu.name }}</span
      >
      <ul v-show="menu.open" class="ef-node-menu-ul">
        <draggable
          @end="end"
          @start="move"
          v-model="menu.children"
          :options="draggableOptions"
          :itemKey="menu.id"
        >
          <template v-for="item in menu.children" :key="element.name" v-slot:item="{ element }">
            <li
              class="ef-node-menu-li"
              :type="element.type"
            >
            <RetweetOutlined v-if="element.type === 'timer'" />
            <VerticalAlignMiddleOutlined v-else-if="element.type === 'task'" />
            <LogoutOutlined v-else-if="element.type === 'end'" />
            <DeleteOutlined v-else />
            {{ element.name }}
            </li>
          </template>
        </draggable>
      </ul>
    </div>
  </div>
</template>

<script>
import { $on, $off, $once, $emit } from '../../utils/gogocodeTransfer'
import {
  CaretDownOutlined,
  CaretRightOutlined,
  RetweetOutlined,
  VerticalAlignMiddleOutlined,
  LogoutOutlined,
  DeleteOutlined
} from '@ant-design/icons-vue'
import draggable from 'vuedraggable'
var mousePosition = {
  left: -1,
  top: -1,
}
export default {
  data() {
    return {
      activeNames: '1',
      // draggable配置参数参考 https://www.cnblogs.com/weixin186/p/10108679.html
      draggableOptions: {
        preventOnFilter: false,
        sort: false,
        disabled: false,
        ghostClass: 'tt',
        // 不使用H5原生的配置
        forceFallback: true,
        // 拖拽的时候样式
        fallbackClass: 'flow-node-draggable',
      },
      // 默认打开的左侧菜单的id
      defaultOpeneds: ['1', '2'],
      menuList: [
        {
          id: '1',
          type: 'group',
          name: '开始节点',
          ico: 'CaretDownOutlined',
          open: true,
          children: [
            {
              id: '11',
              type: 'timer',
              name: '数据接入',
              ico: 'RetweetOutlined',
              // 自定义覆盖样式
              style: {},
            },
            {
              id: '12',
              type: 'task',
              name: '接口调用',
              ico: 'VerticalAlignMiddleOutlined',
              // 自定义覆盖样式
              style: {},
            },
          ],
        },
        {
          id: '2',
          type: 'group',
          name: '结束节点',
          ico: 'CaretDownOutlined',
          open: true,
          children: [
            {
              id: '21',
              type: 'end',
              name: '流程结束',
              ico: 'LogoutOutlined',
              // 自定义覆盖样式
              style: {},
            },
            {
              id: '22',
              type: 'over',
              name: '数据清理',
              ico: 'DeleteOutlined',
              // 自定义覆盖样式
              style: {},
            },
          ],
        },
      ],
      nodeMenu: {},
    }
  },
  components: {
    draggable,
    CaretDownOutlined,
    CaretRightOutlined,
    RetweetOutlined,
    VerticalAlignMiddleOutlined,
    LogoutOutlined,
    DeleteOutlined
  },
  created() {
    /**
     * 以下是为了解决在火狐浏览器上推拽时弹出tab页到搜索问题
     * @param event
     */
    if (this.isFirefox()) {
      document.body.ondrop = function (event) {
        // 解决火狐浏览器无法获取鼠标拖拽结束的坐标问题
        mousePosition.left = event.layerX
        mousePosition.top = event.clientY - 50
        event.preventDefault()
        event.stopPropagation()
      }
    }
  },
  methods: {
    // 根据类型获取左侧菜单对象
    getMenuByType(type) {
      for (let i = 0; i < this.menuList.length; i++) {
        let children = this.menuList[i].children
        for (let j = 0; j < children.length; j++) {
          if (children[j].type === type) {
            return children[j]
          }
        }
      }
    },
    // 拖拽开始时触发
    move(evt, a, b, c) {
      var type = evt.item.attributes.type.nodeValue
      this.nodeMenu = this.getMenuByType(type)
    },
    // 拖拽结束时触发
    end(evt, e) {
      $emit(this, 'addNode', evt, this.nodeMenu, mousePosition)
    },
    // 是否是火狐浏览器
    isFirefox() {
      var userAgent = navigator.userAgent
      if (userAgent.indexOf('Firefox') > -1) {
        return true
      }
      return false
    },
  },
  emits: ['addNode'],
}
</script>
