import { AxiosRequestConfig, AxiosResponse } from 'axios';
import { message } from 'ant-design-vue';
// import { useUserStoreWithOut } from '/@/store/modules/user';
// import { router } from '/@/router';
// import { PageEnum } from '/@/enums/pageEnum';
// import { useI18n } from '/@/hooks/web/useI18n';
// import { Modal } from 'ant-design-vue';
// import { useLocale } from '/@/locales/useLocale';
import { ACCESS_TOKEN, USER_INFO, ABP_LANGUE, ABP_TENANTID } from '@/store/mutation-types'
import { baseURL } from '@/utils/util'
import ls from '@/utils/Storage'
import { useRouter } from 'vue-router'
import jwt_decode from 'jwt-decode';
import { useI18n } from 'vue-i18n'
import { Modal } from 'ant-design-vue';
export class ServiceProxyBase {
    protected transformOptions(options: AxiosRequestConfig) {
        options.baseURL = baseURL as string;
        const guard: boolean = this.urlGuard(options.url as string);
        const router = useRouter()
        const language = ls.get(ABP_LANGUE)
        const token = ls.get(ACCESS_TOKEN)
        const tenantId = ls.get(ABP_TENANTID)
        if (!guard) {
            if (this.checkUserLoginExpire()) {
                router.push({ name: 'login' });
            } else {
                // 添加header
                options.headers = {
                    'accept-language': language,
                    'Content-Type': 'application/json',
                    Authorization: 'Bearer ' + token,
                    __tenant: tenantId,
                };
            }
        } else {
            options.headers = {
                'Content-Type': 'application/json',
                __tenant: tenantId,
                'accept-language': language,
            };
        }

        return Promise.resolve(options);
    }
    protected transformResult(
        _url: string,
        response: AxiosResponse,
        processor: (response: AxiosResponse) => Promise<any>,
    ): Promise<any> {
        const { t } = useI18n();
        const router = useRouter()
        if (response.status == 401) {
            message.error(t('common.authorityText'));
            router.push({ name: 'login' });
        } else if (response.status == 403) {
            message.error(t('common.permissionDenied'));
        } else if (response.status == 400) {
            Modal.error({
                title: t('common.parameterValidationFailure'),
                content: response.data.error.validationErrors[0].message,
            });
        } else if (response.status >= 500) {
            Modal.error({
                title: t('common.systemErrorText'),
                content: response.data.error.message,
            });
        }

        return processor(response);
    }

    //判决接口是否需要拦截
    private urlGuard(url: string): boolean {
        if (url == '/Tenants/find') {
            return true;
        }

        if (url.startsWith('/api/app/account')) {
            return true;
        }

        return false;
    }



    private checkUserLoginExpire(): boolean {
        try {
            const token = ls.get(ACCESS_TOKEN);
            if (!token) return true;
            const decoded: any = jwt_decode(token);
            // 获取当前时间戳
            let currentTimeStamp = new Date().getTime() / 1000;
            if (currentTimeStamp >= decoded.exp) {
                return true;
            } else {
                return false;
            }
        } catch (error) {
            return true;
        }
    }
}
