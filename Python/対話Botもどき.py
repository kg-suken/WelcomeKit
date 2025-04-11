keywords={'こんにちは':'こんにちは！調子はどうですか？', '天気':'天気ですか？よくわからないけど晴れているといいですね！','おはよう':'おはようございます！','こんばんは':'こんばんは！月は見えますか？',
'いい':'それは素晴らしいですね！','よくない':'あらら、お大事に！','はい':'いいですね！','いいえ':'そうですか！'}

def check_words(text):
  for word in keywords.keys():
    if word in text:
      return keywords[word]

  return 'すみません、よくわかりません。'

while True:
  text = input('お話ししましょう！:')
  print(check_words(text))
