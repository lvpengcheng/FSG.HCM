import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import store from './store';
import '@/style/global.less';
import i18n from '@/locales/useI18n'
import 'virtual:svg-icons-register';
import setupDefaultSetting from '@/utils/setupDefaultSetting'

import Antd from 'ant-design-vue';
import 'ant-design-vue/dist/reset.css'

import "@/utils/default-passive-events"

import { GcSpreadSheets, GcWorksheet, GcColumn } from '@grapecity/spread-sheets-vue'
let app = createApp(App)

app.component('gc-spread-sheets', GcSpreadSheets);
app.component('gc-worksheet', GcWorksheet);
app.component('gc-column', GcColumn);
app.use(Antd)
app.use(router)
app.use(store)
app.use(i18n)
app.mount('#app');

setupDefaultSetting()

window.env = import.meta.env.MODE
