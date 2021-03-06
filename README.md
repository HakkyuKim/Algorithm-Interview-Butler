# 알고리즘 인터뷰 집사

## :memo: 개요

알고리즘 인터뷰 집사는 스터디 그룹원들이 알고리즘 인터뷰 문제들을 연습하고 기록하는데 도움을 주는 웹 애플리케이션이다. 다수의 사람들이 함께하는 스터디그룹이 장기화 될수록 지금까지 어떠한 문제들을 풀었는지 관리하기가 힘들어진다. 또한 서로 풀어보지 않은 새로운 모의 인터뷰 문제를 선택할 때, 서로의 풀이 기록을 대조하면서 문제를 골라야 하는 번거로움이 있다. 마지막으로 모의 인터뷰를 마무리하고 피드백, 특이사항, 및 코드를 함께 기록하고 싶다면 관리해야할 문서와 툴이 더욱 많아지게 되는 문제점이 발생한다. 알고리즘 인터뷰 집사는 따분할 수 있는 기록/관리를 편하게 할 수 있도록 하여 모의 인터뷰를 통한 학습 효율성을 증가시키고자 한다.

## :hammer: 개발환경

* 사용언어: HTML, CSS, C#
* 코드 에디터/IDE: Visual Studio Code + Extensions
  *  [Markdown Emoji](https://marketplace.visualstudio.com/items?itemName=bierner.markdown-emoji)
  *  [PlantUML](https://marketplace.visualstudio.com/items?itemName=jebbs.plantuml)
* 프레임워크: [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) (.NET 웹앱 개발 프레임워크)
* 운영체제: Windows 10

## :file_folder: 프로젝트 구조

```bash
├── 문서
│   ├── 1-문제시나리오.md // 개발하는 소프트웨어가 풀고자하는 문제를 시나리오 형식으로 자유롭게 작성한 문서
│   └── 2-개발디자인문서.md // Design Doc: 프로그램 구현 요소들과 API 스펙을 설계하는 문서
├── 이미지 // 문서에 사용하는 이미지 폴더
├── src
│   └── AlgorithmInterviewButler // Blazor 앱 소스 코드
└── README.md // 프로젝트를 소개하는 문서
```
