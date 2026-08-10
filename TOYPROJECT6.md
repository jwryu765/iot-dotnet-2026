# 토이프로젝트 6

## 컨베이어벨트 공정관리 시스템 2

### ESP32-CAM

#### 개요

![](assets/20260810_121203_image.png)

**Ai-Thinker ESP32-CAM**

ESP32 기반 프로세서 사용, WiFi, 블루투스를 지원하는 아두이노 호환보드

업로드 모듈을 사용안할 경우, 아래와 같이 브레드보드, USB 모듈을 직접 연결해야 함

![](assets/20260810_121634_image.png)

#### 기본사용 일부

- Bluetooth 4.2, BLE
- WiFi 802.11 전부 가능
- USB b타입 지원
- microSD 4G 까지 지원 - 사용할 필요 없음
- 외부 안테나 연결 가능

#### 활용처

- 카메라 촬영
- 실시간 영상 스트리밍
- Wi-Fi 통신
- 자체 웹 서버 기능
- 간다한 영상/물체 감지
- IoT 기능도 포함
- UART - Arduino, Raspberry Pi 와 시리얼 통신

#### 개발환경 설정

Arduino IDE 나 Visual Studio Code - Platform IO 확장으로 사용등 여러방법 존재

##### VS Code - PlatformIO IDE

![](assets/20260810_123116_image.png)


- VS Code 확장 `Platform IDE` 검색
- Install
- Python 설치되어 있지 않으면 병행 설치 됨
- 새로 리로드 필요
