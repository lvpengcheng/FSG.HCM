FROM node:17
COPY ./ /vue-docker
WORKDIR /vue-docker

FROM nginx
RUN mkdir /vue-docker
COPY --from=0 /vue-docker/dist /vue-docker
COPY nginx.conf /etc/nginx/nginx.conf