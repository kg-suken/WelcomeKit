

---

##  各問題の解答です。

### **まず最初に**

①

```js
console.log("hellojapan");
```

②

```js
console.log("2025715");
```

③

```js
console.log("Bonjour");
console.log("Hola");
```

---

### **変数**

①

```js
let yama = 31;
console.log(yama);
```

②

```js
let miso = "味噌";
let soup = "汁";
console.log(miso);
console.log(soup);
```

③

```js
let empty;
console.log(empty); // undefinedと表示されます
```

---

### **再代入**

①

```js
let ramen = "menma";
ramen = "ontama";
console.log(ramen);
```

②

```js
let hakumai = "furikake";
hakumai = "namatamago";
hakumai = "nori";
console.log(hakumai);
```

---

### **定数**

```js
const rain = "ame";
console.log(rain);
```

---

### **データ型**

① `"helloamerica"` → **string 型**
② `71515` → **number 型**
③ `undefined` → **undefined 型**

---

### **演算子**

#### 算術演算子の記号：

1⃣ `+`（加算）
2⃣ `-`（減算）
3⃣ `*`（乗算）
4⃣ `/`（除算）
5⃣ `**`（べき乗）
6⃣ `%`（剰余）

#### 演算：

②

```js
console.log(4 + 9); // 13
```

③

```js
console.log(8 - 3); // 5
```

④

```js
console.log(5 * 6); // 30
```

⑤

```js
console.log(12 / 3); // 4
```

⑥

```js
console.log(4 ** 3); // 64
```

⑦

```js
console.log(14 % 5); // 4
```

---

### **比較演算子**

①
1⃣ → `===`
2⃣ → `!==`

---

### **条件分岐**

#### if文①

```js
let number = 7;

if (number > 3) {
  console.log("3より大きいです。");
}
```

#### if文②

```js
let number = 10;

if (number > 10) {
  console.log("10より大きいです");
} else if (number === 10) {
  console.log("10です");
} else {
  console.log("10より小さいです");
}
```

---

### **for文**

①

```js
for (let i = 1; i <= 10; i++) {
  console.log(i);
}
```

②

```js
for (let i = 1; i <= 21; i += 2) {
  console.log(i);
}
```

---

### **条件分岐応用：FizzBuzz**

```js
for (let i = 1; i <= 100; i++) {
  if (i % 15 === 0) {
    console.log("fizzbuzz");
  } else if (i % 3 === 0) {
    console.log("fizz");
  } else if (i % 5 === 0) {
    console.log("buzz");
  } else {
    console.log(i);
  }
}
```

---

### **while文**

```js
let i = 10;
while (i >= 1) {
  console.log(i);
  i--;
}
```

---

### **関数（y = 4x, x = 5）**

```js
function calc(x) {
  return 4 * x;
}

console.log(calc(5)); // 20
```

---

### **関数を使ったFizzBuzz**

```js
function fizzBuzzGame() {
  for (let i = 1; i <= 100; i++) {
    if (i % 15 === 0) {
      console.log("fizzbuzz");
    } else if (i % 3 === 0) {
      console.log("fizz");
    } else if (i % 5 === 0) {
      console.log("buzz");
    } else {
      console.log(i);
    }
  }
}

fizzBuzzGame();
```

---

### **アロー関数：y = 6x（x = 7）**

```js
const calc = x => 6 * x;
console.log(calc(7)); // 42
```



