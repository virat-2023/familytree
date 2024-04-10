pipeline {
    agent any
    stages {
        stage('Git checkout') {
            steps {
                checkout([$class: 'GitSCM',
                          branches: [[name: '*/main']],
                          doGenerateSubmoduleConfigurations: false,
                          extensions: [],
                          submoduleCfg: [],
                          userRemoteConfigs: [[url: 'https://github.com/virat-2023/familytree.git']]])
            }
        }
        stage('build and test') {
            steps {
                
                     
                     sh 'dotnet build'
                
            }
        }
    }
}
