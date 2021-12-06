개발환경
------------
 > VisualStudio 2022 Community - .NET6 ( ASP.NET 및 웹개발, .NET 데스크톱 개발)

![image](https://user-images.githubusercontent.com/67846924/144750599-8ab17601-315c-43b9-b45c-25d2794fac0e.png)



Setup
------------

    git clone https://github.com/lyself23/StatusBoard.git

최초 빌드 순서: 아래와 같이 실행(추후 winform이나 웹만 빌드 시 라이브러리도 같이 빌드되도록 변경예정)

1. StatusBoardLibrary 빌드 - 해당 라이브러리를 윈폼과 웹서버에서 공유
2. StatusBoardWinform 빌드
3. StatusBoardBlazor 빌드

최초빌드 시에만 위의 순서대로 하고 그 이후에는 winform이나 blazor 단독 빌드



    
사용된 컴포넌트
------------
 > Radzen Blazor 컴포넌트 (https://blazor.radzen.com/get-started)

