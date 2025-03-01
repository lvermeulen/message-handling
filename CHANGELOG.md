# [4.3.0](https://github.com/informatievlaanderen/message-handling/compare/v4.2.3...v4.3.0) (2022-09-05)


### Features

* add deduplication id ([3a072cb](https://github.com/informatievlaanderen/message-handling/commit/3a072cbfa8bcef07e74a212a0d11339fa70bf056))

## [4.2.3](https://github.com/informatievlaanderen/message-handling/compare/v4.2.2...v4.2.3) (2022-07-08)


### Bug Fixes

* SqsQueueOptions to record ([562f7e5](https://github.com/informatievlaanderen/message-handling/commit/562f7e52f23010c4b0d4466d04d36f16f303ed82))

## [4.2.2](https://github.com/informatievlaanderen/message-handling/compare/v4.2.1...v4.2.2) (2022-07-08)


### Bug Fixes

* add SqsQueueOptions ([6f15411](https://github.com/informatievlaanderen/message-handling/commit/6f15411fcec9da6f30fcd44190e2819d5de82127))

## [4.2.1](https://github.com/informatievlaanderen/message-handling/compare/v4.2.0...v4.2.1) (2022-06-28)


### Bug Fixes

* allow messageGroupId in CopyToQueue ([b635a4d](https://github.com/informatievlaanderen/message-handling/commit/b635a4de7effeac6b2174cc3d0adb66247e667b6))

# [4.2.0](https://github.com/informatievlaanderen/message-handling/compare/v4.1.7...v4.2.0) (2022-06-24)


### Features

* add copy to queue & create queue if not exists ([20392d5](https://github.com/informatievlaanderen/message-handling/commit/20392d5932d00207d02e4fb9e53a707ef66b4443))

## [4.1.7](https://github.com/informatievlaanderen/message-handling/compare/v4.1.6...v4.1.7) (2022-06-22)


### Bug Fixes

* add ctor without credentials ([5d4132f](https://github.com/informatievlaanderen/message-handling/commit/5d4132f4b8bf230decc9cb7269ca19046092ad92))

## [4.1.6](https://github.com/informatievlaanderen/message-handling/compare/v4.1.5...v4.1.6) (2022-06-21)


### Bug Fixes

* remove region endpoint ([32597b5](https://github.com/informatievlaanderen/message-handling/commit/32597b54b571d3c6536827981ecbe22cc248b91e))

## [4.1.5](https://github.com/informatievlaanderen/message-handling/compare/v4.1.4...v4.1.5) (2022-06-21)


### Bug Fixes

* add basic auth ([83a627c](https://github.com/informatievlaanderen/message-handling/commit/83a627cb4e7e78f055700bacaa5a72664f7dfd65))

## [4.1.4](https://github.com/informatievlaanderen/message-handling/compare/v4.1.3...v4.1.4) (2022-06-08)


### Bug Fixes

* change AWS SQS call interface ([3890d6f](https://github.com/informatievlaanderen/message-handling/commit/3890d6f4848a884605535277c7e82f1c5bd08f2a))

## [4.1.3](https://github.com/informatievlaanderen/message-handling/compare/v4.1.2...v4.1.3) (2022-06-08)


### Bug Fixes

* correct build.fsx ([752c7af](https://github.com/informatievlaanderen/message-handling/commit/752c7af45dcb5979271cc137f89ac33a51ce4d6b))

## [4.1.2](https://github.com/informatievlaanderen/message-handling/compare/v4.1.1...v4.1.2) (2022-06-08)


### Bug Fixes

* add sqs lib to nuget ([5772edb](https://github.com/informatievlaanderen/message-handling/commit/5772edb61a1b46ae3903f8824243a10df44df1d3))

## [4.1.1](https://github.com/informatievlaanderen/message-handling/compare/v4.1.0...v4.1.1) (2022-06-08)


### Bug Fixes

* fix build.fsx ([8c8e19b](https://github.com/informatievlaanderen/message-handling/commit/8c8e19bf5f0916323f42de25b29010da0bc13bfb))

# [4.1.0](https://github.com/informatievlaanderen/message-handling/compare/v4.0.0...v4.1.0) (2022-06-08)


### Features

* add AWS SQS support ([5f7da68](https://github.com/informatievlaanderen/message-handling/commit/5f7da6865ab37524476d29de855978ab8eadf7e9))

# [4.0.0](https://github.com/informatievlaanderen/message-handling/compare/v3.0.0...v4.0.0) (2022-05-13)


### Features

* add delay when no message was found ([52bcb9e](https://github.com/informatievlaanderen/message-handling/commit/52bcb9e5638a37ca74edc27ece44dadcbb7bd2dd))


### BREAKING CHANGES

* refactored the options into producer & consumer options

# [3.0.0](https://github.com/informatievlaanderen/message-handling/compare/v2.1.0...v3.0.0) (2022-04-06)


### Features

* add consumption from specific offset ([da870bd](https://github.com/informatievlaanderen/message-handling/commit/da870bd98185740c9847f2fa0fa5440eb915bd25))


### BREAKING CHANGES

* Consumer now returns `Result<KafkaJsonMessage>` instead of `Result`

# [2.1.0](https://github.com/informatievlaanderen/message-handling/compare/v2.0.0...v2.1.0) (2022-04-05)


### Features

* add kafka topic management ([d0d13ae](https://github.com/informatievlaanderen/message-handling/commit/d0d13aefa43c0210a59ba3cba099a12dcc6cd608))

# [2.0.0](https://github.com/informatievlaanderen/message-handling/compare/v1.3.2...v2.0.0) (2022-03-28)


### Features

* move to dotnet 6.0.3 ([aa04c41](https://github.com/informatievlaanderen/message-handling/commit/aa04c4124d3b1519b74216df64ef33bf68517a9c))


### BREAKING CHANGES

* move to dotnet 6.0.3

## [1.3.2](https://github.com/informatievlaanderen/message-handling/compare/v1.3.1...v1.3.2) (2022-03-02)


### Bug Fixes

* cleanup kafka auth ([8ce39f7](https://github.com/informatievlaanderen/message-handling/commit/8ce39f71e658433928af6c930c0db1cf048a9430))
* fix kafka authn ([f057a24](https://github.com/informatievlaanderen/message-handling/commit/f057a24fb13590d467dd34981f6e0c8b3e803c69))
* fix KafkaAuthentication ([#72](https://github.com/informatievlaanderen/message-handling/issues/72)) ([1774517](https://github.com/informatievlaanderen/message-handling/commit/177451776b2739f65764976696845993871fab64))

## [1.3.1](https://github.com/informatievlaanderen/message-handling/compare/v1.3.0...v1.3.1) (2022-02-17)


### Bug Fixes

* add kafka authentication extensions ([06366cc](https://github.com/informatievlaanderen/message-handling/commit/06366cc2aee9ff5dbaf16ed263f629b0280164c4))

# [1.3.0](https://github.com/informatievlaanderen/message-handling/compare/v1.2.4...v1.3.0) (2022-02-16)


### Features

* add Sasl authentication options ([5030daf](https://github.com/informatievlaanderen/message-handling/commit/5030daf777be6b3ae70b0d52c87defa431328f0e))

## [1.2.4](https://github.com/informatievlaanderen/message-handling/compare/v1.2.3...v1.2.4) (2022-01-28)


### Bug Fixes

* consume now accepts object ([380333f](https://github.com/informatievlaanderen/message-handling/commit/380333fa2079cc0d718f8e7c927a5bc64c51b368))

## [1.2.3](https://github.com/informatievlaanderen/message-handling/compare/v1.2.2...v1.2.3) (2022-01-27)


### Reverts

* Revert "feature: kafka json message serdes" ([e99684f](https://github.com/informatievlaanderen/message-handling/commit/e99684f8ee15671ff2fb326a50a44076b31e7656))

## [1.2.2](https://github.com/informatievlaanderen/message-handling/compare/v1.2.1...v1.2.2) (2022-01-27)


### Bug Fixes

* fix build.fsx ([0b8306b](https://github.com/informatievlaanderen/message-handling/commit/0b8306bf5169134108a45dcb239d23c181d1aca3))
* readd file correct naming ([88e7867](https://github.com/informatievlaanderen/message-handling/commit/88e7867ea9a12e9a0f11e79e070d3b57d8a0fc34))

## [1.2.1](https://github.com/informatievlaanderen/message-handling/compare/v1.2.0...v1.2.1) (2022-01-27)


### Bug Fixes

* change build to not run tests ([7af7676](https://github.com/informatievlaanderen/message-handling/commit/7af7676e9c47e276798a056c749b8c55254b23b8))

# [1.2.0](https://github.com/informatievlaanderen/message-handling/compare/v1.1.5...v1.2.0) (2022-01-26)


### Bug Fixes

* add KafkaOptions.cs ([2a244f2](https://github.com/informatievlaanderen/message-handling/commit/2a244f26052ba9a1327d586773e9254e1d43a6ee))
* change namespace ([#49](https://github.com/informatievlaanderen/message-handling/issues/49)) ([dc77b36](https://github.com/informatievlaanderen/message-handling/commit/dc77b363883748566d02887ffef36d54043f762a))
* create KafkaOptions.cs ([ed2bc10](https://github.com/informatievlaanderen/message-handling/commit/ed2bc1015fb0cc676b7129ff321280cd4d92283c))
* remove LibTest from build.fsx ([fc97169](https://github.com/informatievlaanderen/message-handling/commit/fc9716960a79f36a148fb6ef320f6c92e5fd9f34))
* remove test project from build.fsx ([b9f3b98](https://github.com/informatievlaanderen/message-handling/commit/b9f3b98e61a5602ff9275a596c9f73239a039a18))


### Features

* add kafka options ([d354284](https://github.com/informatievlaanderen/message-handling/commit/d35428448b7209ac4d9c7f87ed64e6d7d16b02ae))

## [1.1.5](https://github.com/informatievlaanderen/message-handling/compare/v1.1.4...v1.1.5) (2022-01-24)


### Bug Fixes

* switch build to kafka only ([cb30bb9](https://github.com/informatievlaanderen/message-handling/commit/cb30bb9299df0a5be6802fb13e5033b3339aef7e))

## [1.1.4](https://github.com/informatievlaanderen/message-handling/compare/v1.1.3...v1.1.4) (2022-01-24)


### Bug Fixes

* remove kafka from build to try build again ([b7dc412](https://github.com/informatievlaanderen/message-handling/commit/b7dc412bdbd2de39d9ba5331ca8a06db26b5f8f8))

## [1.1.3](https://github.com/informatievlaanderen/message-handling/compare/v1.1.2...v1.1.3) (2022-01-24)


### Bug Fixes

* style to trigger build ([689fcfb](https://github.com/informatievlaanderen/message-handling/commit/689fcfb21c8be2c4f733e69ca1377f6c04d60e40))

## [1.1.2](https://github.com/informatievlaanderen/message-handling/compare/v1.1.1...v1.1.2) (2022-01-24)


### Bug Fixes

* style to trigger build ([c32094e](https://github.com/informatievlaanderen/message-handling/commit/c32094e301477bd693053ede22399bbf2b2c2f03))

## [1.1.1](https://github.com/informatievlaanderen/message-handling/compare/v1.1.0...v1.1.1) (2022-01-24)


### Bug Fixes

* publish kafka simple to nuget ([7f58909](https://github.com/informatievlaanderen/message-handling/commit/7f5890994ec0d23fc97b1fc88125b628c4eb1b18))

# [1.1.0](https://github.com/informatievlaanderen/message-handling/compare/v1.0.7...v1.1.0) (2022-01-24)


### Bug Fixes

* add kafka lib to build ([905e874](https://github.com/informatievlaanderen/message-handling/commit/905e874f867cee11d01f5d7f6b2bf2f77fdd6fd8))


### Features

* add kafka simple lib ([c4bf57b](https://github.com/informatievlaanderen/message-handling/commit/c4bf57b4237fa70784755e41547e303b2aadd226))

## [1.0.7](https://github.com/informatievlaanderen/message-handling/compare/v1.0.6...v1.0.7) (2022-01-24)


### Bug Fixes

* build rabbitmq but don't push to nuget ([04b5ed8](https://github.com/informatievlaanderen/message-handling/commit/04b5ed8897f12a02e602bc551e82b0c44c3b885f))
* clean up + fix build ([ff697db](https://github.com/informatievlaanderen/message-handling/commit/ff697db68e77af182065b08b1ea94ca6b9ebdde9))
* revert to last working build ([58d03f6](https://github.com/informatievlaanderen/message-handling/commit/58d03f60c0ca66859ed893f09bbc81a243258dae)), closes [#36](https://github.com/informatievlaanderen/message-handling/issues/36) [#35](https://github.com/informatievlaanderen/message-handling/issues/35)

## [1.0.3](https://github.com/informatievlaanderen/message-handling/compare/v1.0.2...v1.0.3) (2021-11-17)

## [1.0.2](https://github.com/informatievlaanderen/message-handling/compare/v1.0.1...v1.0.2) (2021-11-15)


### Bug Fixes

* use polly for retries & fix bugs ([da7c4be](https://github.com/informatievlaanderen/message-handling/commit/da7c4beb6a4fba83ac9f2bbbdea7b89367c15d04))

## [1.0.1](https://github.com/informatievlaanderen/message-handling/compare/v1.0.0...v1.0.1) (2021-11-09)


### Bug Fixes

* use `npm ci` instead of install ([74f7092](https://github.com/informatievlaanderen/message-handling/commit/74f709240079b323d7f7af996c7e7b945a54b216))

# 1.0.0 (2021-11-09)


### Features

* add rabbitmq ([1535b3e](https://github.com/informatievlaanderen/message-handling/commit/1535b3eb113648d80e85dba6cc355d9b5343afee))
